# 🛡️ KynexAuth C# (.NET) SDK & GUI Integration Guide

[![.NET](https://img.shields.io/badge/.NET-6.0%20%7C%207.0%20%7C%208.0%20%7C%20Framework%204.8-blue.svg)](https://dotnet.microsoft.com/)
[![Platform](https://img.shields.io/badge/Platform-Windows%20(WinForms%20%7C%20WPF%20%7C%20Console)-lightgrey.svg)](https://microsoft.com/windows)
[![GUI Ready](https://img.shields.io/badge/GUI-WinForms%20%7C%20WPF%20%7C%20GunaUI-purple.svg)]()
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
[![Status](https://img.shields.io/badge/Status-Stable-brightgreen.svg)]()

Welcome to the official **KynexAuth C# (.NET) Client SDK** documentation. This guide will walk you through setting up, configuring, and integrating secure licensing, user authentication, HWID locking, and cloud variables into your C# applications (**Console**, **Windows Forms / WinForms**, and **WPF**).

---

## 📺 Video Tutorial

> 🎥 **Step-by-Step C# Video Walkthrough:**  
> [![Watch Video Tutorial](https://img.shields.io/badge/YouTube-Watch%20Tutorial%20Video-red?style=for-the-badge&logo=youtube)](https://www.youtube.com/watch?v=YOUR_C_SHARP_VIDEO_ID_HERE)  
> *(Link: `https://www.youtube.com/watch?v=YOUR_C_SHARP_VIDEO_ID_HERE` — Replace with your video URL)*

---

## ✨ Features

- **Robust Authentication**: Login with username/password or direct license key.
- **Hardware ID (HWID) Locking**: Automatic machine binding to prevent unauthorized account sharing.
- **Expiry & Subscription Handling**: Precise timestamp calculations for account and subscription expiration.
- **Cloud Variables**: Securely fetch secret keys, strings, or configs from the server at runtime.
- **Webhooks & Audit Logs**: Trigger Discord/Custom webhooks and transmit client logs directly to the dashboard.
- **Async & Responsive GUI**: Smooth non-blocking asynchronous calls in WinForms & WPF.
- **Zero-Crash Exception Safety**: Null-safe JSON deserialization protecting against unexpected server payloads.

---

## 📋 Prerequisites

Before getting started, ensure you have:
1. **IDE**: [Visual Studio 2019 or 2022](https://visualstudio.microsoft.com/) with **.NET desktop development** workload installed.
2. **Target Framework**: .NET Framework 4.7.2+ OR .NET 6.0 / 7.0 / 8.0+.
3. **Dependencies**: `System.Runtime.Serialization` (Standard .NET Library).
4. An active application configured on the [KynexAuth Dashboard](https://kynexauth.com).

---

## 🚀 Step 1: SDK Installation & Setup

1. Copy the `Authorization` folder (`KynexAuth.cs`) into your C# project.
2. Ensure `using KynexAuth;` is included at the top of your files.
3. Instantiate the static `api` instance:

```csharp
using System;
using KynexAuth;

namespace MyApp
{
    public static class AuthConfig
    {
        public static api KynexAuthApp = new api(
            name: "YOUR_APP_NAME",       // App Name from dashboard
            ownerid: "YOUR_APP_KEY",     // App Key (Owner ID)
            version: "1.0",              // App Version matching dashboard
            url: "https://kynexauth.com/api/v1/client" // API Endpoint
        );
    }
}
```

---

## 💻 Part 1: Console Application Integration

Here is a full sample for initializing and authenticating inside a C# Console Application:

```csharp
using System;
using System.Diagnostics;
using System.Threading;
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

        static void Main(string[] args)
        {
            Console.Title = "KynexAuth Loader";
            Console.WriteLine("\n Connecting to server...");

            // 1. Initialize Connection
            KynexAuthApp.init();

            if (!KynexAuthApp.response.success)
            {
                Console.WriteLine("\n Error: " + KynexAuthApp.response.message);

                // Open auto-update link if version mismatch occurs
                if (!string.IsNullOrEmpty(KynexAuthApp.app_data.downloadLink))
                {
                    Console.WriteLine("\n Opening update download link...");
                    Process.Start(new ProcessStartInfo(KynexAuthApp.app_data.downloadLink) { UseShellExecute = true });
                }

                Thread.Sleep(3000);
                return;
            }

            Console.WriteLine("\n Connected successfully!");
            Console.WriteLine("\n [1] Login (Username & Password)");
            Console.WriteLine(" [2] Register (Username, Password & License Key)");
            Console.WriteLine(" [3] License Only Login");
            Console.Write("\n Select option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Username: ");
                    string user = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    string pass = Console.ReadLine();

                    KynexAuthApp.login(user, pass);
                    break;

                case "2":
                    Console.Write("Enter Username: ");
                    string regUser = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    string regPass = Console.ReadLine();
                    Console.Write("Enter License Key: ");
                    string key = Console.ReadLine();

                    KynexAuthApp.regstr(regUser, regPass, key);
                    break;

                case "3":
                    Console.Write("Enter License Key: ");
                    string licKey = Console.ReadLine();

                    KynexAuthApp.license(licKey);
                    break;
            }

            // Verify Result
            if (KynexAuthApp.response.success)
            {
                Console.WriteLine("\n Authenticated successfully!");
                Console.WriteLine(" Username: " + KynexAuthApp.user_data.username);
                Console.WriteLine(" HWID: " + KynexAuthApp.user_data.hwid);
                Console.WriteLine(" Created: " + KynexAuthApp.user_data.createdate);

                foreach (var sub in KynexAuthApp.user_data.subscriptions)
                {
                    Console.WriteLine($" Subscription: {sub.name} | Expiry: {sub.expiry}");
                }
            }
            else
            {
                Console.WriteLine("\n Authentication Failed: " + KynexAuthApp.response.message);
            }

            Console.WriteLine("\n Press any key to exit...");
            Console.ReadKey();
        }
    }
}
```

---

## 🎨 Part 2: Windows Forms (WinForms) GUI Integration

When building a **Windows Forms (WinForms)** loader, execute authentication calls using `async Task.Run` to **prevent the UI from freezing or lagging**.

### 1. Form Load Event (`LoginForm_Load`)
Call `init()` when the form loads:

```csharp
private async void LoginForm_Load(object sender, EventArgs e)
{
    statusLabel.Text = "Connecting to KynexAuth server...";
    loginButton.Enabled = false;

    bool initSuccess = false;
    string errorMessage = "";

    await Task.Run(() =>
    {
        AuthConfig.KynexAuthApp.init();
        initSuccess = AuthConfig.KynexAuthApp.response.success;
        errorMessage = AuthConfig.KynexAuthApp.response.message;
    });

    if (initSuccess)
    {
        statusLabel.Text = "Connected. Please log in.";
        loginButton.Enabled = true;
    }
    else
    {
        statusLabel.Text = "Connection Error: " + errorMessage;
        MessageBox.Show(errorMessage, "Initialization Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

        // Open auto-update link if available
        if (!string.IsNullOrEmpty(AuthConfig.KynexAuthApp.app_data.downloadLink))
        {
            Process.Start(new ProcessStartInfo(AuthConfig.KynexAuthApp.app_data.downloadLink) { UseShellExecute = true });
        }
    }
}
```

---

### 2. Login Button Click Event (`LoginButton_Click`)

```csharp
private async void LoginButton_Click(object sender, EventArgs e)
{
    string username = usernameTextBox.Text.Trim();
    string password = passwordTextBox.Text.Trim();

    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
    {
        MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    loginButton.Enabled = false;
    statusLabel.Text = "Logging in...";

    bool loginSuccess = false;
    string message = "";

    await Task.Run(() =>
    {
        AuthConfig.KynexAuthApp.login(username, password);
        loginSuccess = AuthConfig.KynexAuthApp.response.success;
        message = AuthConfig.KynexAuthApp.response.message;
    });

    if (loginSuccess)
    {
        statusLabel.Text = "Login successful!";
        
        // Hide login form and open main dashboard form
        this.Hide();
        DashboardForm dashboard = new DashboardForm();
        dashboard.Show();
    }
    else
    {
        loginButton.Enabled = true;
        statusLabel.Text = "Error: " + message;
        MessageBox.Show(message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
```

---

### 3. License Key Only Login Event

```csharp
private async void LicenseLoginButton_Click(object sender, EventArgs e)
{
    string licenseKey = licenseTextBox.Text.Trim();

    if (string.IsNullOrEmpty(licenseKey))
    {
        MessageBox.Show("Please enter your license key.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    licenseLoginButton.Enabled = false;
    statusLabel.Text = "Verifying license...";

    bool authSuccess = false;
    string message = "";

    await Task.Run(() =>
    {
        AuthConfig.KynexAuthApp.license(licenseKey);
        authSuccess = AuthConfig.KynexAuthApp.response.success;
        message = AuthConfig.KynexAuthApp.response.message;
    });

    if (authSuccess)
    {
        this.Hide();
        DashboardForm dashboard = new DashboardForm();
        dashboard.Show();
    }
    else
    {
        licenseLoginButton.Enabled = true;
        statusLabel.Text = "Error: " + message;
        MessageBox.Show(message, "License Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
```

---

### 4. Displaying User Info in Dashboard Form (`DashboardForm_Load`)

```csharp
private void DashboardForm_Load(object sender, EventArgs e)
{
    welcomeLabel.Text = "Welcome, " + AuthConfig.KynexAuthApp.user_data.username;
    hwidLabel.Text = "HWID: " + AuthConfig.KynexAuthApp.user_data.hwid;
    createdDateLabel.Text = "Created: " + AuthConfig.KynexAuthApp.user_data.createdate;

    if (AuthConfig.KynexAuthApp.user_data.subscriptions.Count > 0)
    {
        var sub = AuthConfig.KynexAuthApp.user_data.subscriptions[0];
        subscriptionLabel.Text = "Subscription: " + sub.name;
        expiryLabel.Text = "Expires: " + sub.expiry;
    }

    // Start background session heartbeat
    StartSessionTimer();
}
```

---

## ⚡ Part 3: Background Session Keep-Alive / Heartbeat

Keep your session verified in the background and auto-kick revoked or expired users:

```csharp
private System.Windows.Forms.Timer sessionTimer;

private void StartSessionTimer()
{
    sessionTimer = new System.Windows.Forms.Timer();
    sessionTimer.Interval = 60000; // Check every 60 seconds
    sessionTimer.Tick += async (s, ev) =>
    {
        bool isSessionValid = true;

        await Task.Run(() =>
        {
            AuthConfig.KynexAuthApp.check();
            isSessionValid = AuthConfig.KynexAuthApp.response.success;
        });

        if (!isSessionValid)
        {
            sessionTimer.Stop();
            MessageBox.Show("Your session has expired or was revoked by the server.", "Session Expired", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Application.Exit();
        }
    };
    sessionTimer.Start();
}
```

---

## ☁️ Part 4: Advanced Features

### 1. Fetching Cloud Variables
```csharp
string secretKey = AuthConfig.KynexAuthApp.var("my_secret_var_id");
```

### 2. Transmitting Client Logs
```csharp
AuthConfig.KynexAuthApp.log("User opened feature panel");
```

### 3. Firing Webhooks
```csharp
AuthConfig.KynexAuthApp.webhook("webhook_id", "param1=value&param2=value");
```

---

## ❓ Frequently Asked Questions (FAQ) & Troubleshooting

| Issue / Error | Cause | Solution |
| :--- | :--- | :--- |
| **`Version mismatch`** | The `version` string in C# does not match the dashboard app version. | Update the version in your `api` declaration or in your KynexAuth dashboard settings. |
| **`Status: Internal Server Error`** | Server connection or Redis issue. | Ensure the backend server and Redis are running and reachable. |
| **UI Freezes / Unresponsive** | Running network calls synchronously on the UI thread. | Wrap all `login`, `init`, and `license` calls with `await Task.Run(...)` as demonstrated above. |
| **`NullReferenceException`** | Missing null checks on server responses. | Use the updated `KynexAuth.cs` which has built-in null-conditional handling. |

---

## 📄 License & Support

This project is licensed under the **MIT License**.

- 🌐 **Website**: [https://kynexauth.com](https://kynexauth.com)
- 💬 **Discord Support**: [Join Discord](https://discord.gg/upms5k9Sct)
- 📧 **Support Email**: `support@kynexauth.com`
