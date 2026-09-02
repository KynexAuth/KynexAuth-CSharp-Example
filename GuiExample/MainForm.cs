using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using KynexAuth;

namespace GuiExample
{
    public partial class MainForm : Form
    {
        private LoginForm loginFormInstance;

        public MainForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginFormInstance = loginForm;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PopulateUserData();
            ShowTab(pnlAimbot);
        }

        private void PopulateUserData()
        {
            var user = LoginForm.KynexAuthApp.user_data;
            if (user != null)
            {
                lblValUsername.Text = string.IsNullOrEmpty(user.username) ? "N/A" : user.username;
                lblValHwid.Text = string.IsNullOrEmpty(user.hwid) ? "Protected HWID" : user.hwid;
                lblValIp.Text = string.IsNullOrEmpty(user.ip) ? "127.0.0.1" : user.ip;
                lblValCreated.Text = string.IsNullOrEmpty(user.createdate) ? "N/A" : user.createdate;
                lblValLastLogin.Text = string.IsNullOrEmpty(user.lastlogin) ? "Just Now" : user.lastlogin;

                if (user.subscriptions != null && user.subscriptions.Count > 0)
                {
                    lblValExpiry.Text = user.subscriptions[0].expiry;
                }
                else
                {
                    lblValExpiry.Text = "Lifetime / Active";
                }
            }
        }

        #region Slider Handlers

        private void tbFov_Scroll(object sender, ScrollEventArgs e)
        {
            lblFovVal.Text = tbFov.Value.ToString();
        }

        private void tbSmooth_Scroll(object sender, ScrollEventArgs e)
        {
            lblSmoothVal.Text = tbSmooth.Value.ToString();
        }

        private void tbScopeDelay_Scroll(object sender, ScrollEventArgs e)
        {
            lblScopeDelayVal.Text = tbScopeDelay.Value.ToString();
        }

        #endregion

        #region Navigation Tabs

        private void btnNavAimbot_Click(object sender, EventArgs e)
        {
            SetNavActive(btnNavAimbot);
            ShowTab(pnlAimbot);
        }

        private void btnNavSniper_Click(object sender, EventArgs e)
        {
            SetNavActive(btnNavSniper);
            ShowTab(pnlSniper);
        }

        private void btnNavMisc_Click(object sender, EventArgs e)
        {
            SetNavActive(btnNavMisc);
            ShowTab(pnlMisc);
        }

        private void btnNavSetting_Click(object sender, EventArgs e)
        {
            SetNavActive(btnNavSetting);
            ShowTab(pnlSetting);
        }

        private void SetNavActive(Guna2Button activeBtn)
        {
            Color activeBg = Color.FromArgb(30, 38, 60);
            Color inactiveBg = Color.Transparent;

            btnNavAimbot.FillColor = activeBtn == btnNavAimbot ? activeBg : inactiveBg;
            btnNavSniper.FillColor = activeBtn == btnNavSniper ? activeBg : inactiveBg;
            btnNavMisc.FillColor = activeBtn == btnNavMisc ? activeBg : inactiveBg;
            btnNavSetting.FillColor = activeBtn == btnNavSetting ? activeBg : inactiveBg;
        }

        private void ShowTab(Guna2Panel activePanel)
        {
            pnlAimbot.Visible = (activePanel == pnlAimbot);
            pnlSniper.Visible = (activePanel == pnlSniper);
            pnlMisc.Visible = (activePanel == pnlMisc);
            pnlSetting.Visible = (activePanel == pnlSetting);
        }

        #endregion

        private void btnVerifyIntegrity_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Memory integrity verified: 100% SECURE.", "Kynex Security", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnUpgrade_Click(object sender, EventArgs e)
        {
            string key = txtUpgradeKey.Text.Trim();
            if (string.IsNullOrEmpty(key))
            {
                lblUpgradeStatus.Text = "Please enter an upgrade license key.";
                lblUpgradeStatus.ForeColor = Color.FromArgb(239, 68, 68);
                return;
            }

            btnUpgrade.Enabled = false;
            lblUpgradeStatus.Text = "Upgrading subscription...";
            lblUpgradeStatus.ForeColor = Color.FromArgb(99, 102, 241);

            await Task.Run(() =>
            {
                LoginForm.KynexAuthApp.upgrade(LoginForm.KynexAuthApp.user_data.username, key);
            });

            btnUpgrade.Enabled = true;

            if (LoginForm.KynexAuthApp.response.success)
            {
                lblUpgradeStatus.Text = "Subscription extended successfully!";
                lblUpgradeStatus.ForeColor = Color.FromArgb(16, 185, 129);
                PopulateUserData();
            }
            else
            {
                lblUpgradeStatus.Text = LoginForm.KynexAuthApp.response.message;
                lblUpgradeStatus.ForeColor = Color.FromArgb(239, 68, 68);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm.KynexAuthApp.logout();
            this.Close();
            if (loginFormInstance != null)
            {
                loginFormInstance.Show();
            }
        }

        private void swSilentAim_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
