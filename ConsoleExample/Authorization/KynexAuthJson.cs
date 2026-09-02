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
}
