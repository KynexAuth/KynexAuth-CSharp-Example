using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using KynexAuth;

namespace GuiExample
{
    public partial class LoginForm : Form
    {
        // -------------------------------------------------------------
        // CONFIGURE YOUR APP CREDENTIALS HERE
        // -------------------------------------------------------------
        public static api KynexAuthApp = new api(
            name: "YOUR_APP_NAME",       // App Name from dashboard
            ownerid: "YOUR_APP_KEY",     // App Key (Owner ID)
            version: "1.0",              // App Version matching dashboard
            url: "https://kynexauth.com/api/v1/client" // API Endpoint
        );

        private enum AuthMode { UserLogin, LicenseLogin, Register }
        private AuthMode currentMode = AuthMode.UserLogin;

        public LoginForm()
        {
            InitializeComponent();
        }

        private async void LoginForm_Load(object sender, EventArgs e)
        {
            SetStatus("Connecting to KynexAuth server...", Color.FromArgb(148, 163, 184));
            SetLoading(true);

            bool initSuccess = await Task.Run(() =>
            {
                KynexAuthApp.init();
                return KynexAuthApp.response.success;
            });

            SetLoading(false);

            if (initSuccess)
            {
                SetStatus("Connected. Ready to authenticate.", Color.FromArgb(16, 185, 129));
            }
            else
            {
                SetStatus(KynexAuthApp.response.message, Color.FromArgb(239, 68, 68));
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTabUserLogin_Click(object sender, EventArgs e)
        {
            currentMode = AuthMode.UserLogin;
            UpdateTabStyles();
            txtUsername.Visible = true;
            txtPassword.Visible = true;
            txtLicense.Visible = false;
            txtEmail.Visible = false;
            btnAction.Text = "LOGIN";
            txtUsername.Location = new Point(32, 78);
            txtPassword.Location = new Point(32, 134);
            btnAction.Location = new Point(32, 200);
            lblStatus.Location = new Point(28, 260);
            Height = 370;
        }

        private void btnTabLicenseLogin_Click(object sender, EventArgs e)
        {
            currentMode = AuthMode.LicenseLogin;
            UpdateTabStyles();
            txtUsername.Visible = false;
            txtPassword.Visible = false;
            txtLicense.Visible = true;
            txtEmail.Visible = false;
            btnAction.Text = "LICENSE LOGIN";
            txtLicense.Location = new Point(32, 78);
            btnAction.Location = new Point(32, 140);
            lblStatus.Location = new Point(28, 200);
            Height = 310;
        }

        private void btnTabRegister_Click(object sender, EventArgs e)
        {
            currentMode = AuthMode.Register;
            UpdateTabStyles();
            txtUsername.Visible = true;
            txtPassword.Visible = true;
            txtLicense.Visible = true;
            txtEmail.Visible = true;
            btnAction.Text = "REGISTER";
            txtUsername.Location = new Point(32, 78);
            txtPassword.Location = new Point(32, 134);
            txtLicense.Location = new Point(32, 190);
            txtEmail.Location = new Point(32, 246);
            btnAction.Location = new Point(32, 306);
            lblStatus.Location = new Point(28, 360);
            Height = 470;
        }

        private void UpdateTabStyles()
        {
            Color activeBg = Color.FromArgb(30, 38, 60);
            Color activeFg = Color.White;
            Color inactiveBg = Color.Transparent;
            Color inactiveFg = Color.FromArgb(148, 163, 184);

            btnTabUserLogin.FillColor = currentMode == AuthMode.UserLogin ? activeBg : inactiveBg;
            btnTabUserLogin.ForeColor = currentMode == AuthMode.UserLogin ? activeFg : inactiveFg;

            btnTabLicenseLogin.FillColor = currentMode == AuthMode.LicenseLogin ? activeBg : inactiveBg;
            btnTabLicenseLogin.ForeColor = currentMode == AuthMode.LicenseLogin ? activeFg : inactiveFg;

            btnTabRegister.FillColor = currentMode == AuthMode.Register ? activeBg : inactiveBg;
            btnTabRegister.ForeColor = currentMode == AuthMode.Register ? activeFg : inactiveFg;
        }

        private async void btnAction_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string key = txtLicense.Text.Trim();
            string email = txtEmail.Text.Trim();

            SetLoading(true);

            if (currentMode == AuthMode.UserLogin)
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    SetStatus("Please enter username and password.", Color.FromArgb(239, 68, 68));
                    SetLoading(false);
                    return;
                }

                SetStatus("Authenticating...", Color.FromArgb(99, 102, 241));
                await Task.Run(() => KynexAuthApp.login(username, password));
            }
            else if (currentMode == AuthMode.LicenseLogin)
            {
                if (string.IsNullOrEmpty(key))
                {
                    SetStatus("Please enter your license key.", Color.FromArgb(239, 68, 68));
                    SetLoading(false);
                    return;
                }

                SetStatus("Verifying License Key...", Color.FromArgb(99, 102, 241));
                await Task.Run(() => KynexAuthApp.license(key));
            }
            else if (currentMode == AuthMode.Register)
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(key))
                {
                    SetStatus("Please fill in username, password, and license key.", Color.FromArgb(239, 68, 68));
                    SetLoading(false);
                    return;
                }

                SetStatus("Registering account...", Color.FromArgb(99, 102, 241));
                await Task.Run(() => KynexAuthApp.regstr(username, password, key, email));
            }

            SetLoading(false);

            if (KynexAuthApp.response.success)
            {
                SetStatus("Success! Launching dashboard...", Color.FromArgb(16, 185, 129));
                await Task.Delay(400);

                MainForm mainForm = new MainForm(this);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                SetStatus(KynexAuthApp.response.message, Color.FromArgb(239, 68, 68));
            }
        }

        private void SetStatus(string message, Color color)
        {
            lblStatus.Text = message;
            lblStatus.ForeColor = color;
        }

        private void SetLoading(bool loading)
        {
            btnAction.Enabled = !loading;
            progressIndicator.Visible = loading;
        }

        private void progressIndicator_Click(object sender, EventArgs e)
        {

        }
    }
}
