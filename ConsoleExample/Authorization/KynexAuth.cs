using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Diagnostics;

namespace KynexAuth
{
    public class channel_struct
    {
        public string author;
        public string message;
        public string timestamp;
    }

    public class subscriptions_class
    {
        public string name;
        public string expiry;
    }

    public class userdata
    {
        public string username;
        public string ip;
        public string hwid;
        public string createdate;
        public string lastlogin;
        
        public string area;
        public string rank;
        public string role;
        public string owner;

        public List<subscriptions_class> subscriptions = new List<subscriptions_class>();
    }

    public class appdata
    {
        public string numUsers;
        public string numOnlineUsers;
        public string numKeys;
        public string version;
        public string customerPanelLink;
        public string downloadLink;
        public string serverTime;
    }

    public class responsedata
    {
        public List<channel_struct> channeldata = new List<channel_struct>();
        public bool success;
        public string message;
        public bool isPaid;
    }

    public class Tfa
    {
        public string secret;
        public string link;

        public Tfa handleInput(api apiInstance)
        {
            return this;
        }

        private void QrCode() {}
    }

    public static class Logger
    {
        public static bool IsLoggingEnabled { get; set; } = false;
        public static void LogEvent(string content)
        {
            if (!IsLoggingEnabled) return;

            string exeName = Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location);
            string logDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "KynexAuth", "debug", exeName);
            
            if (!Directory.Exists(logDirectory)) Directory.CreateDirectory(logDirectory);

            string logFilePath = Path.Combine(logDirectory, $"{DateTime.Now:MMM_dd_yyyy}_logs.txt");
            try {
                using (StreamWriter writer = File.AppendText(logFilePath)) {
                    writer.WriteLine($"[{DateTime.Now}] [{AppDomain.CurrentDomain.FriendlyName}] {content}");
                }
            } catch {}
        }
    }

    public class api
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool TerminateProcess(IntPtr hProcess, uint uExitCode);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetCurrentProcess();

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern ushort GlobalAddAtom(string lpString);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern ushort GlobalFindAtom(string lpString);

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        private static extern bool IsDebuggerPresent();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        public string name, ownerid, version, url, seed;
        public string sessionid, enckey;
        public bool activate = false;
        private bool initialized = false;

        public bool require_pinning = false;
        public bool block_proxy = false;
        public bool block_custom_ca = false;
        public bool block_private_dns = false;

        public userdata user_data = new userdata();
        public appdata app_data = new appdata();
        public responsedata response = new responsedata();
        public Tfa tfa = new Tfa();

        private List<string> allowed_hosts = new List<string>();
        private List<string> pinned_public_keys = new List<string>();
        private bool secure_strings_enabled_ = false;

        private static bool debug = false;

        public api(string ownerid, string version, string url, string seed = "")
        {
            this.name = "";
            this.ownerid = ownerid;
            this.version = version;
            this.url = url;
            this.seed = seed;
        }

        public api(string name, string ownerid, string version, string url, string seed = "")
        {
            this.name = name;
            this.ownerid = ownerid;
            this.version = version;
            this.url = url;
            this.seed = seed;
        }

        public static void setDebug(bool value)
        {
            debug = value;
        }

        private static void debugInfo(string data, string endpointUrl, string responseText, string headers)
        {
            if (debug)
            {
                Console.WriteLine("\n[DEBUG] URL: " + endpointUrl);
                Console.WriteLine("\n[DEBUG] Data: " + data);
                Console.WriteLine("\n[DEBUG] Response: " + responseText + "\n");
            }
        }

        public static void error(string message)
        {
            Console.Error.WriteLine("Error: " + message);
            Logger.LogEvent("Error: " + message);

            try
            {
                MessageBox(IntPtr.Zero, message, "KynexAuth Error", 0x10); // 0x10 = MB_ICONERROR
            }
            catch {}

            Environment.Exit(0);
        }

        public void CheckInit()
        {
            if (!initialized)
            {
                error("You must run KynexAuthApp.init(); first");
                TerminateProcess(GetCurrentProcess(), 1);
            }
        }

        public static string checksum(string filename)
        {
            try {
                using (MD5 md = MD5.Create())
                using (FileStream fileStream = File.OpenRead(filename))
                {
                    byte[] value = md.ComputeHash(fileStream);
                    return BitConverter.ToString(value).Replace("-", "").ToLowerInvariant();
                }
            } catch { return "UNKNOWN_HASH"; }
        }

        void checkAtom()
        {
            Thread atomCheckThread = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(60000); 
                    if (!string.IsNullOrEmpty(seed)) {
                        ushort foundAtom = GlobalFindAtom(seed);
                        if (foundAtom == 0)
                        {
                            Logger.LogEvent("Memory Atom check failed (tampering detected)");
                            TerminateProcess(GetCurrentProcess(), 1);
                        }
                    }
                }
            });
            atomCheckThread.IsBackground = true;
            atomCheckThread.Start();
        }

        public void init()
        {
            if (IsDebuggerPresent())
            {
                error("Debugger Detected!");
                TerminateProcess(GetCurrentProcess(), 1);
            }

            Random random = new Random();
            seed = Guid.NewGuid().ToString("N");
            checkAtom();

            var dict = new Dictionary<string, object> {
                { "name", name },
                { "appKey", ownerid },
                { "version", version },
                { "hash", checksum(Process.GetCurrentProcess().MainModule.FileName) }
            };
            string res = req(KynexAuthJson.Serialize(dict), "/init");
            
            try {
                var data = KynexAuthJson.Deserialize(res);
                response.success = data.ContainsKey("success") && (data["success"] is bool b ? b : false);
                response.message = data.ContainsKey("message") ? data["message"]?.ToString() : "";
                
                if (response.success) {
                    GlobalAddAtom(seed);
                    initialized = true;

                    if (data.ContainsKey("sessionToken")) sessionid = data["sessionToken"]?.ToString();
                    if (data.ContainsKey("appInfo")) {
                        var appInfo = data["appInfo"] as Dictionary<string, object>;
                        if (appInfo != null) {
                            if (appInfo.ContainsKey("version")) app_data.version = appInfo["version"]?.ToString();
                            if (appInfo.ContainsKey("name") && string.IsNullOrEmpty(this.name)) this.name = appInfo["name"]?.ToString();
                        }
                    }
                }
                if (data.ContainsKey("downloadLink")) {
                    app_data.downloadLink = data["downloadLink"]?.ToString();
                }

                if (!response.success) {
                    if (!string.IsNullOrEmpty(app_data.downloadLink)) {
                        try { Process.Start(new ProcessStartInfo(app_data.downloadLink) { UseShellExecute = true }); } catch {}
                    }
                    error(response.message);
                }
            } catch {
                response.success = false;
                response.message = "Failed to parse init response";
                error(response.message);
            }
        }

        public void login(string username, string password, string code = "")
        {
            CheckInit();
            var dict = new Dictionary<string, object> {
                { "username", username },
                { "password", password },
                { "hwid", get_hwid() },
                { "sessionToken", sessionid }
            };
            string res = req(KynexAuthJson.Serialize(dict), "/login");
            parse_login_response(res, username, "login");
        }

        public void regstr(string username, string password, string key, string email = "")
        {
            var dict = new Dictionary<string, object> {
                { "username", username },
                { "password", password },
                { "licenseKey", key },
                { "hwid", get_hwid() },
                { "sessionToken", sessionid }
            };
            string res = req(KynexAuthJson.Serialize(dict), "/register");
            parse_login_response(res, username, "register");
        }

        public void license(string key, string code = "")
        {
            var dict = new Dictionary<string, object> {
                { "licenseKey", key },
                { "hwid", get_hwid() },
                { "sessionToken", sessionid }
            };
            string res = req(KynexAuthJson.Serialize(dict), "/license");
            parse_login_response(res, "LicenseUser", "license");
        }

        public void check(bool check_paid = false)
        {
            var dict = new Dictionary<string, object> {
                { "sessionToken", sessionid }
            };
            string res = req(KynexAuthJson.Serialize(dict), "/check");
            try {
                var data = KynexAuthJson.Deserialize(res);
                response.success = data.ContainsKey("success") && (data["success"] is bool b ? b : false);
                response.message = data.ContainsKey("message") ? data["message"]?.ToString() : "";
            } catch {
                response.success = false;
            }
        }

        public void log(string msg)
        {
            var dict = new Dictionary<string, object> {
                { "sessionToken", sessionid },
                { "message", msg }
            };
            req(KynexAuthJson.Serialize(dict), "/log");
        }

        public void ban(string reason = "")
        {
            var dict = new Dictionary<string, object> {
                { "sessionToken", sessionid },
                { "reason", reason },
                { "username", user_data.username }
            };
            string res = req(KynexAuthJson.Serialize(dict), "/ban");
            try {
                var data = KynexAuthJson.Deserialize(res);
                response.success = data.ContainsKey("success") && (data["success"] is bool b ? b : false);
                response.message = data.ContainsKey("message") ? data["message"]?.ToString() : "";
            } catch {}
        }

        public string webhook(string id, string params_val, string body = "", string contenttype = "")
        {
            var dict = new Dictionary<string, object> {
                { "sessionToken", sessionid },
                { "webhookId", id },
                { "params", params_val }
            };
            string res = req(KynexAuthJson.Serialize(dict), "/webhook");
            try {
                var data = KynexAuthJson.Deserialize(res);
                if (data.ContainsKey("success") && (data["success"] is bool b ? b : false))
                    return data.ContainsKey("data") ? data["data"]?.ToString() : "";
            } catch {}
            return "";
        }

        public void setvar(string var, string vardata)
        {
            var dict = new Dictionary<string, object> {
                { "sessionToken", sessionid },
                { "varName", var },
                { "varData", vardata }
            };
            req(KynexAuthJson.Serialize(dict), "/var");
        }

        public string getvar(string var)
        {
            var dict = new Dictionary<string, object> {
                { "sessionToken", sessionid },
                { "varName", var }
            };
            string res = req(KynexAuthJson.Serialize(dict), "/var");
            try {
                var data = KynexAuthJson.Deserialize(res);
                if (data.ContainsKey("success") && (data["success"] is bool b ? b : false))
                    return data.ContainsKey("data") ? data["data"]?.ToString() : "";
            } catch {}
            return "";
        }

        public void chatget(string channel)
        {
            var dict = new Dictionary<string, object> {
                { "sessionToken", sessionid },
                { "channel", channel }
            };
            string res = req(KynexAuthJson.Serialize(dict), "/chat");
            try {
                var data = KynexAuthJson.Deserialize(res);
                response.success = data.ContainsKey("success") && (data["success"] is bool b ? b : false);
                response.message = data.ContainsKey("message") ? data["message"]?.ToString() : "";
                
                response.channeldata.Clear();
                if (data.ContainsKey("messages")) {
                    var msgs = data["messages"] as System.Collections.ArrayList;
                    if (msgs != null) {
                        foreach(Dictionary<string, object> msg in msgs) {
                            var output = new channel_struct();
                            output.author = msg.ContainsKey("author") ? msg["author"].ToString() : "";
                            output.message = msg.ContainsKey("message") ? msg["message"].ToString() : "";
                            output.timestamp = msg.ContainsKey("timestamp") ? msg["timestamp"].ToString() : "";
                            response.channeldata.Add(output);
                        }
                    }
                }
            } catch {}
        }

        public bool chatsend(string message, string channel)
        {
            var dict = new Dictionary<string, object> {
                { "sessionToken", sessionid },
                { "message", message },
                { "channel", channel }
            };
            string res = req(KynexAuthJson.Serialize(dict), "/chat");
            try {
                var data = KynexAuthJson.Deserialize(res);
                return data.ContainsKey("success") && (data["success"] is bool b ? b : false);
            } catch { return false; }
        }

        public void changeUsername(string newusername) {}
        
        public string fetchonline() { return ""; }
        
        public void fetchstats() {}
        
        public void forgot(string username, string email) {}
        
        public void upgrade(string username, string key)
        {
            var dict = new Dictionary<string, object> {
                { "sessionToken", sessionid },
                { "username", username },
                { "licenseKey", key }
            };
            string res = req(KynexAuthJson.Serialize(dict), "/upgrade");
            try {
                var data = KynexAuthJson.Deserialize(res);
                response.success = data.ContainsKey("success") && (data["success"] is bool b ? b : false);
                response.message = data.ContainsKey("message") ? data["message"]?.ToString() : "";
            } catch {}
        }

        public void logout()
        {
            var dict = new Dictionary<string, object> {
                { "sessionToken", sessionid }
            };
            req(KynexAuthJson.Serialize(dict), "/logout");
            sessionid = "";
        }

        public void start_ban_monitor(int interval_seconds = 45, bool check_session = false, Action on_ban = null) {}
        public void stop_ban_monitor() {}
        public bool ban_monitor_running() { return false; }
        public bool ban_monitor_detected() { return false; }
        
        public Tfa enable2fa(string code = "") { return tfa; }
        public Tfa disable2fa(string code = "") { return tfa; }
        
        public void enable_secure_strings(bool enable = true) { secure_strings_enabled_ = enable; }
        public void set_allowed_hosts(List<string> hosts) { allowed_hosts = hosts; }
        public void add_allowed_host(string host) { allowed_hosts.Add(host); }
        public void clear_allowed_hosts() { allowed_hosts.Clear(); }
        public void set_pinned_public_keys(List<string> pins) { pinned_public_keys = pins; }
        public void add_pinned_public_key(string pin) { pinned_public_keys.Add(pin); }
        public void clear_pinned_public_keys() { pinned_public_keys.Clear(); }

        private static string TmToReadableTime(string timestamp)
        {
            if (string.IsNullOrEmpty(timestamp)) return "";
            if (long.TryParse(timestamp, out long unixTime)) {
                try {
                    return DateTimeOffset.FromUnixTimeSeconds(unixTime).ToLocalTime().ToString("ddd MM/dd/yy HH:mm:ss");
                } catch { }
            }
            if (DateTime.TryParse(timestamp, out DateTime dt)) {
                return dt.ToLocalTime().ToString("ddd MM/dd/yy HH:mm:ss");
            }
            return timestamp;
        }

        private void parse_login_response(string res, string username, string actionName)
        {
            try {
                var data = KynexAuthJson.Deserialize(res);
                response.success = data.ContainsKey("success") && (data["success"] is bool b ? b : false);
                response.message = data.ContainsKey("message") ? data["message"]?.ToString() : "";
                
                if (response.success) {
                    GlobalAddAtom(seed);
                    initialized = true;

                    if (data.ContainsKey("sessionToken")) sessionid = data["sessionToken"]?.ToString();
                    if (data.ContainsKey("appInfo")) {
                        var appInfo = data["appInfo"] as Dictionary<string, object>;
                        if (appInfo != null) {
                            if (appInfo.ContainsKey("downloadLink")) app_data.downloadLink = appInfo["downloadLink"]?.ToString();
                        }
                    }

                    user_data.username = username;
                    user_data.hwid = get_hwid();
                    
                    if (data.ContainsKey("serverTime")) {
                        app_data.serverTime = data["serverTime"].ToString();
                    }
                    
                    if (data.ContainsKey("userInfo")) {
                        var userInfo = data["userInfo"] as Dictionary<string, object>;
                        if (userInfo != null) {
                            if (userInfo.ContainsKey("createdAt")) user_data.createdate = TmToReadableTime(userInfo["createdAt"]?.ToString());
                            
                            if (userInfo.ContainsKey("ip")) user_data.ip = userInfo["ip"]?.ToString();
                            if (string.IsNullOrEmpty(user_data.ip)) {
                                try { user_data.ip = new System.Net.WebClient().DownloadString("https://api.ipify.org").Trim(); } catch { user_data.ip = "Unknown"; }
                            }

                            if (userInfo.ContainsKey("lastlogin")) user_data.lastlogin = TmToReadableTime(userInfo["lastlogin"]?.ToString());
                            if (string.IsNullOrEmpty(user_data.lastlogin)) user_data.lastlogin = "N/A";

                            if (userInfo.ContainsKey("area")) user_data.area = userInfo["area"]?.ToString();
                            if (userInfo.ContainsKey("rank")) user_data.rank = userInfo["rank"]?.ToString();
                            if (userInfo.ContainsKey("role")) user_data.role = userInfo["role"]?.ToString();
                            if (userInfo.ContainsKey("owner")) user_data.owner = userInfo["owner"]?.ToString();
                            
                            if (userInfo.ContainsKey("expiresAt")) {
                                user_data.subscriptions.Add(new subscriptions_class {
                                    name = "default",
                                    expiry = TmToReadableTime(userInfo["expiresAt"]?.ToString())
                                });
                            }
                        }
                    }
                }
            } catch {
                response.success = false;
                response.message = "Failed to parse " + actionName + " response";
            }
        }

        private string req(string json_data, string endpoint)
        {
            try {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                
                string fullUrl = url + endpoint;
                var request = (HttpWebRequest)WebRequest.Create(fullUrl);
                request.Method = "POST";
                request.ContentType = "application/json";
                request.Headers.Add("X-App-Name", name);
                request.Headers.Add("X-Owner-ID", ownerid);

                using (var streamWriter = new StreamWriter(request.GetRequestStream())) {
                    streamWriter.Write(json_data);
                }

                using (var httpResponse = (HttpWebResponse)request.GetResponse())
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream())) {
                    string responseString = streamReader.ReadToEnd();
                    debugInfo(json_data, fullUrl, responseString, "");
                    return responseString;
                }
            } catch (WebException ex) {
                if (ex.Response != null) {
                    using (var streamReader = new StreamReader(ex.Response.GetResponseStream())) {
                        string responseString = streamReader.ReadToEnd();
                        debugInfo(json_data, url + endpoint, responseString, "");
                        return responseString;
                    }
                }
                return "{\"success\":false,\"message\":\"Connection failed\"}";
            } catch {
                return "{\"success\":false,\"message\":\"Request error\"}";
            }
        }

        private static string hwid_cache = "";
        public static string get_hwid()
        {
            if (!string.IsNullOrEmpty(hwid_cache)) return hwid_cache;

            try {
                hwid_cache = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;
                return hwid_cache;
            } catch {
                return "UNKNOWN_HWID";
            }
        }
    }
}
