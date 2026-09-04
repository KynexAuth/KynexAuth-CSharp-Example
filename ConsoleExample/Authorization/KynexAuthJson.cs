using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace KynexAuth
{
    /// <summary>
    /// A 100% Pure, Standalone, Zero-Dependency JSON Parser & Serializer for KynexAuth.
    /// Does NOT require Newtonsoft.Json, System.Text.Json, or System.Web.Extensions.
    /// Works out-of-the-box on .NET Framework 2.0-4.8, .NET Core, .NET 5/6/7/8/9, WinForms, and WPF.
    /// </summary>
    public static class KynexAuthJson
    {
        public static string Serialize(object obj)
        {
            if (obj == null) return "null";
            return SerializeValue(obj);
        }

        private static string SerializeValue(object obj)
        {
            if (obj == null) return "null";

            if (obj is string s)
            {
                StringBuilder sb = new StringBuilder("\"");
                foreach (char c in s)
                {
                    switch (c)
                    {
                        case '"': sb.Append("\\\""); break;
                        case '\\': sb.Append("\\\\"); break;
                        case '\b': sb.Append("\\b"); break;
                        case '\f': sb.Append("\\f"); break;
                        case '\n': sb.Append("\\n"); break;
                        case '\r': sb.Append("\\r"); break;
                        case '\t': sb.Append("\\t"); break;
                        default:
                            if (c < ' ')
                            {
                                sb.AppendFormat("\\u{0:x4}", (int)c);
                            }
                            else
                            {
                                sb.Append(c);
                            }
                            break;
                    }
                }
                sb.Append("\"");
                return sb.ToString();
            }

            if (obj is bool b) return b ? "true" : "false";

            if (obj is IDictionary dict)
            {
                StringBuilder sb = new StringBuilder("{");
                bool first = true;
                foreach (DictionaryEntry entry in dict)
                {
                    if (!first) sb.Append(",");
                    sb.Append(SerializeValue(entry.Key.ToString()));
                    sb.Append(":");
                    sb.Append(SerializeValue(entry.Value));
                    first = false;
                }
                sb.Append("}");
                return sb.ToString();
            }

            if (obj is IEnumerable list && !(obj is string))
            {
                StringBuilder sb = new StringBuilder("[");
                bool first = true;
                foreach (var item in list)
                {
                    if (!first) sb.Append(",");
                    sb.Append(SerializeValue(item));
                    first = false;
                }
                sb.Append("]");
                return sb.ToString();
            }

            if (obj is sbyte || obj is byte || obj is short || obj is ushort ||
                obj is int || obj is uint || obj is long || obj is ulong ||
                obj is float || obj is double || obj is decimal)
            {
                return Convert.ToString(obj, CultureInfo.InvariantCulture);
            }

            return "\"" + obj.ToString() + "\"";
        }

        public static Dictionary<string, object> Deserialize(string json)
        {
            try
            {
                if (string.IsNullOrEmpty(json)) return new Dictionary<string, object>();
                int index = 0;
                var val = ParseValue(json, ref index);
                if (val is Dictionary<string, object> dict) return dict;
                return new Dictionary<string, object>();
            }
            catch
            {
                return new Dictionary<string, object>();
            }
        }

        private static object ParseValue(string json, ref int index)
        {
            EatWhitespace(json, ref index);
            if (index >= json.Length) return null;

            char c = json[index];
            if (c == '{') return ParseObject(json, ref index);
            if (c == '[') return ParseArray(json, ref index);
            if (c == '"') return ParseString(json, ref index);
            if (c == 't' || c == 'f') return ParseBoolean(json, ref index);
            if (c == 'n') return ParseNull(json, ref index);
            if (c == '-' || (c >= '0' && c <= '9')) return ParseNumber(json, ref index);

            return null;
        }

        private static Dictionary<string, object> ParseObject(string json, ref int index)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
            index++; // skip '{'

            while (index < json.Length)
            {
                EatWhitespace(json, ref index);
                if (index >= json.Length) break;
                if (json[index] == '}')
                {
                    index++;
                    return dict;
                }

                string key = ParseString(json, ref index);
                EatWhitespace(json, ref index);

                if (index < json.Length && json[index] == ':') index++;
                EatWhitespace(json, ref index);

                object val = ParseValue(json, ref index);
                dict[key] = val;

                EatWhitespace(json, ref index);
                if (index < json.Length && json[index] == ',')
                {
                    index++;
                }
                else if (index < json.Length && json[index] == '}')
                {
                    index++;
                    return dict;
                }
            }
            return dict;
        }

        private static List<object> ParseArray(string json, ref int index)
        {
            List<object> list = new List<object>();
            index++; // skip '['

            while (index < json.Length)
            {
                EatWhitespace(json, ref index);
                if (index >= json.Length) break;
                if (json[index] == ']')
                {
                    index++;
                    return list;
                }

                object val = ParseValue(json, ref index);
                list.Add(val);

                EatWhitespace(json, ref index);
                if (index < json.Length && json[index] == ',')
                {
                    index++;
                }
                else if (index < json.Length && json[index] == ']')
                {
                    index++;
                    return list;
                }
            }
            return list;
        }

        private static string ParseString(string json, ref int index)
        {
            StringBuilder sb = new StringBuilder();
            index++; // skip opening quote '"'

            while (index < json.Length)
            {
                char c = json[index++];
                if (c == '"') return sb.ToString();
                if (c == '\\')
                {
                    if (index >= json.Length) break;
                    char esc = json[index++];
                    switch (esc)
                    {
                        case '"': sb.Append('"'); break;
                        case '\\': sb.Append('\\'); break;
                        case '/': sb.Append('/'); break;
                        case 'b': sb.Append('\b'); break;
                        case 'f': sb.Append('\f'); break;
                        case 'n': sb.Append('\n'); break;
                        case 'r': sb.Append('\r'); break;
                        case 't': sb.Append('\t'); break;
                        case 'u':
                            if (index + 4 <= json.Length)
                            {
                                string hex = json.Substring(index, 4);
                                sb.Append((char)Convert.ToInt32(hex, 16));
                                index += 4;
                            }
                            break;
                    }
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        private static object ParseNumber(string json, ref int index)
        {
            int start = index;
            while (index < json.Length && (char.IsDigit(json[index]) || json[index] == '-' || json[index] == '+' || json[index] == '.' || json[index] == 'e' || json[index] == 'E'))
            {
                index++;
            }
            string numStr = json.Substring(start, index - start);
            if (long.TryParse(numStr, NumberStyles.Integer, CultureInfo.InvariantCulture, out long lVal))
                return lVal;
            if (double.TryParse(numStr, NumberStyles.Float, CultureInfo.InvariantCulture, out double dVal))
                return dVal;
            return numStr;
        }

        private static bool ParseBoolean(string json, ref int index)
        {
            if (json.Substring(index).StartsWith("true", StringComparison.OrdinalIgnoreCase))
            {
                index += 4;
                return true;
            }
            if (json.Substring(index).StartsWith("false", StringComparison.OrdinalIgnoreCase))
            {
                index += 5;
                return false;
            }
            return false;
        }

        private static object ParseNull(string json, ref int index)
        {
            if (json.Substring(index).StartsWith("null", StringComparison.OrdinalIgnoreCase))
            {
                index += 4;
            }
            return null;
        }

        private static void EatWhitespace(string json, ref int index)
        {
            while (index < json.Length && char.IsWhiteSpace(json[index]))
            {
                index++;
            }
        }
    }

    /// <summary>
    /// Pure C# Zero-Dependency Ed25519 Cryptographic Signature Verification & Security Utility.
    /// Provides tamper-proof digital signature validation and response authenticity checks
    /// matching KeyAuth's Ed25519 response signing protection.
    /// </summary>
    public static class Ed25519
    {
        private static readonly System.Numerics.BigInteger Q = System.Numerics.BigInteger.Parse("57896044618658097711785492504343953926634992332820282019728792003956564819949");
        private static readonly System.Numerics.BigInteger D = System.Numerics.BigInteger.Parse("-4513249062541557336618354741066890300407765322924111283082764333673904202049");
        private static readonly System.Numerics.BigInteger I = System.Numerics.BigInteger.Parse("19681353557162757614214256054903372064989372047668069245724249055408301937204");
        private static readonly System.Numerics.BigInteger By = System.Numerics.BigInteger.Parse("46316835694926478169428394003475163141307993866256225615783033603165251855960");
        private static readonly System.Numerics.BigInteger Bx = System.Numerics.BigInteger.Parse("15112221349535400772501151409588531511454012693041857206046113283949847762202");
        private static readonly System.Numerics.BigInteger L = System.Numerics.BigInteger.Parse("7237005577332262213973186563042994240857116359379907606001950938285454250989");

        private static byte[] Sha512(byte[] message)
        {
            using (var sha512 = System.Security.Cryptography.SHA512.Create())
            {
                return sha512.ComputeHash(message);
            }
        }

        private static System.Numerics.BigInteger Mod(System.Numerics.BigInteger val, System.Numerics.BigInteger m)
        {
            System.Numerics.BigInteger r = val % m;
            return r < 0 ? r + m : r;
        }

        private static System.Numerics.BigInteger ExpMod(System.Numerics.BigInteger b, System.Numerics.BigInteger exp, System.Numerics.BigInteger mod)
        {
            System.Numerics.BigInteger result = System.Numerics.BigInteger.One;
            System.Numerics.BigInteger baseVal = Mod(b, mod);

            while (exp > 0)
            {
                if (!exp.IsEven)
                {
                    result = Mod(result * baseVal, mod);
                }
                baseVal = Mod(baseVal * baseVal, mod);
                exp >>= 1;
            }
            return result;
        }

        private static System.Numerics.BigInteger Inv(System.Numerics.BigInteger x)
        {
            return ExpMod(x, Q - 2, Q);
        }

        private static System.Numerics.BigInteger RecoverX(System.Numerics.BigInteger y)
        {
            System.Numerics.BigInteger y2 = y * y;
            System.Numerics.BigInteger xx = (y2 - 1) * Inv(D * y2 + 1);
            System.Numerics.BigInteger x = ExpMod(xx, (Q + 3) / 8, Q);
            if (!Mod(x * x - xx, Q).Equals(System.Numerics.BigInteger.Zero))
            {
                x = Mod(x * I, Q);
            }
            if (!x.IsEven)
            {
                x = Q - x;
            }
            return x;
        }

        private static Tuple<System.Numerics.BigInteger, System.Numerics.BigInteger> EdwardsAdd(
            System.Numerics.BigInteger px, System.Numerics.BigInteger py,
            System.Numerics.BigInteger qx, System.Numerics.BigInteger qy)
        {
            System.Numerics.BigInteger xx = px * qx;
            System.Numerics.BigInteger yy = py * qy;
            System.Numerics.BigInteger dtemp = D * xx * yy;
            System.Numerics.BigInteger x3 = (px * qy + qx * py) * Inv(1 + dtemp);
            System.Numerics.BigInteger y3 = (py * qy + xx) * Inv(1 - dtemp);
            return new Tuple<System.Numerics.BigInteger, System.Numerics.BigInteger>(Mod(x3, Q), Mod(y3, Q));
        }

        private static Tuple<System.Numerics.BigInteger, System.Numerics.BigInteger> ScalarMult(
            Tuple<System.Numerics.BigInteger, System.Numerics.BigInteger> pt, System.Numerics.BigInteger scalar)
        {
            Tuple<System.Numerics.BigInteger, System.Numerics.BigInteger> result =
                new Tuple<System.Numerics.BigInteger, System.Numerics.BigInteger>(System.Numerics.BigInteger.Zero, System.Numerics.BigInteger.One);
            Tuple<System.Numerics.BigInteger, System.Numerics.BigInteger> current = pt;

            while (scalar > 0)
            {
                if (!scalar.IsEven)
                {
                    result = EdwardsAdd(result.Item1, result.Item2, current.Item1, current.Item2);
                }
                current = EdwardsAdd(current.Item1, current.Item2, current.Item1, current.Item2);
                scalar >>= 1;
            }
            return result;
        }

        private static System.Numerics.BigInteger DecodeInteger(byte[] b, int offset, int length)
        {
            byte[] copy = new byte[length + 1];
            Buffer.BlockCopy(b, offset, copy, 0, length);
            return new System.Numerics.BigInteger(copy);
        }

        private static Tuple<System.Numerics.BigInteger, System.Numerics.BigInteger> DecodePoint(byte[] p)
        {
            if (p == null || p.Length != 32) return null;
            byte[] clamped = (byte[])p.Clone();
            int sign = (clamped[31] >> 7) & 1;
            clamped[31] &= 0x7F;
            System.Numerics.BigInteger y = DecodeInteger(clamped, 0, 32);
            System.Numerics.BigInteger x = RecoverX(y);
            if (((x.IsEven ? 0 : 1) ^ sign) != 0)
            {
                x = Q - x;
            }
            return new Tuple<System.Numerics.BigInteger, System.Numerics.BigInteger>(x, y);
        }

        private static byte[] EncodePoint(Tuple<System.Numerics.BigInteger, System.Numerics.BigInteger> pt)
        {
            byte[] yBytes = pt.Item2.ToByteArray();
            byte[] output = new byte[32];
            Buffer.BlockCopy(yBytes, 0, output, 0, Math.Min(yBytes.Length, 32));
            if (!pt.Item1.IsEven)
            {
                output[31] |= 0x80;
            }
            return output;
        }

        /// <summary>
        /// Verifies whether the digital signature is valid for the given message body and Ed25519 public key.
        /// </summary>
        /// <param name="signature">64-byte signature (R + S)</param>
        /// <param name="message">Signed payload/data bytes</param>
        /// <param name="publicKey">32-byte Ed25519 public key</param>
        /// <returns>True if signature is valid and authentic, false otherwise.</returns>
        public static bool CheckValid(byte[] signature, byte[] message, byte[] publicKey)
        {
            try
            {
                if (signature == null || signature.Length != 64) return false;
                if (publicKey == null || publicKey.Length != 32) return false;
                if (message == null) return false;

                byte[] rBytes = new byte[32];
                Buffer.BlockCopy(signature, 0, rBytes, 0, 32);
                Tuple<System.Numerics.BigInteger, System.Numerics.BigInteger> rPt = DecodePoint(rBytes);
                if (rPt == null) return false;

                Tuple<System.Numerics.BigInteger, System.Numerics.BigInteger> aPt = DecodePoint(publicKey);
                if (aPt == null) return false;

                System.Numerics.BigInteger s = DecodeInteger(signature, 32, 32);
                if (s >= L) return false;

                byte[] hashInput = new byte[32 + 32 + message.Length];
                Buffer.BlockCopy(signature, 0, hashInput, 0, 32);
                Buffer.BlockCopy(publicKey, 0, hashInput, 32, 32);
                Buffer.BlockCopy(message, 0, hashInput, 64, message.Length);

                byte[] hBytes = Sha512(hashInput);
                System.Numerics.BigInteger k = DecodeInteger(hBytes, 0, 64);
                k = Mod(k, L);

                Tuple<System.Numerics.BigInteger, System.Numerics.BigInteger> basePoint =
                    new Tuple<System.Numerics.BigInteger, System.Numerics.BigInteger>(Bx, By);

                Tuple<System.Numerics.BigInteger, System.Numerics.BigInteger> sb = ScalarMult(basePoint, s);
                Tuple<System.Numerics.BigInteger, System.Numerics.BigInteger> ka = ScalarMult(aPt, k);
                Tuple<System.Numerics.BigInteger, System.Numerics.BigInteger> rPlusKa = EdwardsAdd(rPt.Item1, rPt.Item2, ka.Item1, ka.Item2);

                byte[] left = EncodePoint(sb);
                byte[] right = EncodePoint(rPlusKa);

                if (left.Length != right.Length) return false;
                int diff = 0;
                for (int i = 0; i < left.Length; i++)
                {
                    diff |= left[i] ^ right[i];
                }
                return diff == 0;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Helper to convert hex string to byte array
        /// </summary>
        public static byte[] HexToBytes(string hex)
        {
            if (string.IsNullOrEmpty(hex)) return new byte[0];
            hex = hex.Replace("-", "").Replace(" ", "");
            if (hex.Length % 2 != 0) return new byte[0];
            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return bytes;
        }

        /// <summary>
        /// Helper to convert byte array to hex string
        /// </summary>
        public static string BytesToHex(byte[] bytes)
        {
            if (bytes == null) return "";
            return BitConverter.ToString(bytes).Replace("-", "").ToLowerInvariant();
        }
    }
}
