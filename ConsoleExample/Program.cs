using System;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;
using KynexAuth;

namespace ConsoleExample
{
    class Program
    {
        static api KynexAuthApp = new api(
            name: "YOUR_APP_NAME",
            ownerid: "YOUR_APP_KEY",
            version: "1.0",
            url: "https://kynexauth.com/api/v1/client"
        );

        static void init_fail_delay() { Thread.Sleep(3000); }
        static void bad_input_delay() { Thread.Sleep(3000); }
        static void close_delay() { Thread.Sleep(3000); }

        static void print_user_data(api app)
        {
            Console.WriteLine("\n User data:");
            Console.WriteLine("\n Username: " + app.user_data.username);
            Console.WriteLine("\n IP address: " + app.user_data.ip);
            Console.WriteLine("\n Hardware-Id: " + app.user_data.hwid);
            Console.WriteLine("\n Create date: " + app.user_data.createdate);
            Console.WriteLine("\n Last login: " + app.user_data.lastlogin);

            Console.WriteLine("\n Subscription(s): ");
            foreach (var sub in app.user_data.subscriptions)
            {
                Console.Write("\n name: " + sub.name);
                Console.Write(" : expiry: " + sub.expiry);
                Console.WriteLine();
            }
        }

        static void sessionStatus()
        {
            KynexAuthApp.check(true);
            if (!KynexAuthApp.response.success) return;

            if (KynexAuthApp.response.isPaid) {
                while (true) {
                    Thread.Sleep(20000);
                    KynexAuthApp.check();
                    if (!KynexAuthApp.response.success) return;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Loader - Built at:  " + DateTime.Now.ToString("MMM dd yyyy HH:mm:ss");
            Console.WriteLine("\n\n Connecting..");

            KynexAuthApp.init();
            if (!KynexAuthApp.response.success)
            {
                Console.WriteLine("\n Status: " + KynexAuthApp.response.message);
                if (!string.IsNullOrEmpty(KynexAuthApp.app_data.downloadLink))
                {
                    Console.WriteLine("\n\n Opening auto-update link in browser...");
                    Thread.Sleep(1500);
                    Process.Start(KynexAuthApp.app_data.downloadLink);
                }
                init_fail_delay();
                Environment.Exit(1);
            }

            string ownerid_copy = KynexAuthApp.ownerid;

            string username = "";
            string password = "";
            string key = "";
            string TfaCode = "";

            Console.Write("\n\n [1] Login\n [2] Register\n [3] Upgrade\n [4] License key only\n\n Choose option: ");
            
            if (!int.TryParse(Console.ReadLine(), out int option))
            {
                Console.WriteLine("\n\n Status: Failure: Invalid Selection");
                bad_input_delay();
                Environment.Exit(1);
            }

            switch (option)
            {
                case 1:
                    Console.Write("\n\n Enter username: ");
                    username = Console.ReadLine();
                    Console.Write("\n Enter password: ");
                    password = Console.ReadLine();
                    KynexAuthApp.login(username, password, "");
                    break;
                case 2:
                    Console.Write("\n\n Enter username: ");
                    username = Console.ReadLine();
                    Console.Write("\n Enter password: ");
                    password = Console.ReadLine();
                    Console.Write("\n Enter license: ");
                    key = Console.ReadLine();
                    KynexAuthApp.regstr(username, password, key);
                    break;
                case 3:
                    Console.Write("\n\n Enter username: ");
                    username = Console.ReadLine();
                    Console.Write("\n Enter license: ");
                    key = Console.ReadLine();
                    KynexAuthApp.upgrade(username, key);
                    break;
                case 4:
                    Console.Write("\n Enter license: ");
                    key = Console.ReadLine();
                    KynexAuthApp.license(key, "");
                    break;
                default:
                    Console.WriteLine("\n\n Status: Failure: Invalid Selection");
                    bad_input_delay();
                    Environment.Exit(1);
                    break;
            }

            if (string.IsNullOrEmpty(KynexAuthApp.response.message))
                Environment.Exit(11);

            if (!KynexAuthApp.response.success)
            {
                if (KynexAuthApp.response.message == "2FA code required.")
                {
                    Console.Write("\n Your account has 2FA enabled, please enter 6-digit code:");
                    TfaCode = Console.ReadLine();
                    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                    {
                        KynexAuthApp.license(key, TfaCode);
                    }
                    else
                    {
                        KynexAuthApp.login(username, password, TfaCode);
                    }

                    if (string.IsNullOrEmpty(KynexAuthApp.response.message)) Environment.Exit(11);
                    if (!KynexAuthApp.response.success)
                    {
                        Console.WriteLine("\n Status: " + KynexAuthApp.response.message);
                        init_fail_delay();
                        Environment.Exit(1);
                    }
                }
                else
                {
                    Console.WriteLine("\n Status: " + KynexAuthApp.response.message);
                    init_fail_delay();
                    Environment.Exit(1);
                }
            }

            Thread sessionCheck = new Thread(sessionStatus);
            sessionCheck.IsBackground = true;
            sessionCheck.Start();

            if (string.IsNullOrEmpty(KynexAuthApp.user_data.username))
                Environment.Exit(10);

            print_user_data(KynexAuthApp);

            Console.WriteLine("\n\n Status: " + KynexAuthApp.response.message);
            Console.WriteLine("\n\n Closing in five seconds...");
            close_delay();
        }
    }
}
