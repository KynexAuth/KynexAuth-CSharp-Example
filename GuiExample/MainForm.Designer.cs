namespace GuiExample
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel topPanel;
        private System.Windows.Forms.Label lblHeaderTitle;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
        private Guna.UI2.WinForms.Guna2Panel sidebarPanel;
        private Guna.UI2.WinForms.Guna2Button btnNavAimbot;
        private Guna.UI2.WinForms.Guna2Button btnNavSniper;
        private Guna.UI2.WinForms.Guna2Button btnNavMisc;
        private Guna.UI2.WinForms.Guna2Button btnNavSetting;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Panel contentPanel;

        // -------------------------------------------------------------
        // AIMBOT TAB CONTROLS
        // -------------------------------------------------------------
        private Guna.UI2.WinForms.Guna2Panel pnlAimbot;
        private System.Windows.Forms.Label lblAimbotHeader;
        private Guna.UI2.WinForms.Guna2Panel cardAimbot;
        private System.Windows.Forms.Label lblAimbotToggle;
        private Guna.UI2.WinForms.Guna2ToggleSwitch swAimbot;
        private System.Windows.Forms.Label lblDrawFovToggle;
        private Guna.UI2.WinForms.Guna2ToggleSwitch swDrawFov;
        private System.Windows.Forms.Label lblSilentAimToggle;
        private Guna.UI2.WinForms.Guna2ToggleSwitch swSilentAim;
        private System.Windows.Forms.Label lblBoneTitle;
        private Guna.UI2.WinForms.Guna2ComboBox cbBone;
        private System.Windows.Forms.Label lblFovTitle;
        private System.Windows.Forms.Label lblFovVal;
        private Guna.UI2.WinForms.Guna2TrackBar tbFov;
        private System.Windows.Forms.Label lblSmoothTitle;
        private System.Windows.Forms.Label lblSmoothVal;
        private Guna.UI2.WinForms.Guna2TrackBar tbSmooth;

        // -------------------------------------------------------------
        // SNIPER TAB CONTROLS
        // -------------------------------------------------------------
        private Guna.UI2.WinForms.Guna2Panel pnlSniper;
        private System.Windows.Forms.Label lblSniperHeader;
        private Guna.UI2.WinForms.Guna2Panel cardSniper;
        private System.Windows.Forms.Label lblFastScopeToggle;
        private Guna.UI2.WinForms.Guna2ToggleSwitch swFastScope;
        private System.Windows.Forms.Label lblQuickSwitchToggle;
        private Guna.UI2.WinForms.Guna2ToggleSwitch swQuickSwitch;
        private System.Windows.Forms.Label lblBulletPredictionToggle;
        private Guna.UI2.WinForms.Guna2ToggleSwitch swBulletPrediction;
        private System.Windows.Forms.Label lblScopeDelayTitle;
        private System.Windows.Forms.Label lblScopeDelayVal;
        private Guna.UI2.WinForms.Guna2TrackBar tbScopeDelay;

        // -------------------------------------------------------------
        // MISC TAB CONTROLS
        // -------------------------------------------------------------
        private Guna.UI2.WinForms.Guna2Panel pnlMisc;
        private System.Windows.Forms.Label lblMiscHeader;
        private Guna.UI2.WinForms.Guna2Panel cardMisc;
        private System.Windows.Forms.Label lblBunnyHopToggle;
        private Guna.UI2.WinForms.Guna2ToggleSwitch swBunnyHop;
        private System.Windows.Forms.Label lblStreamProofToggle;
        private Guna.UI2.WinForms.Guna2ToggleSwitch swStreamProof;
        private System.Windows.Forms.Label lblWatermarkToggle;
        private Guna.UI2.WinForms.Guna2ToggleSwitch swWatermark;
        private Guna.UI2.WinForms.Guna2Button btnVerifyIntegrity;

        // -------------------------------------------------------------
        // SETTING TAB CONTROLS
        // -------------------------------------------------------------
        private Guna.UI2.WinForms.Guna2Panel pnlSetting;
        private System.Windows.Forms.Label lblSettingHeader;
        private Guna.UI2.WinForms.Guna2Panel cardSetting;
        private System.Windows.Forms.Label lblTitleUsername;
        private System.Windows.Forms.Label lblValUsername;
        private System.Windows.Forms.Label lblTitleHwid;
        private System.Windows.Forms.Label lblValHwid;
        private System.Windows.Forms.Label lblTitleIp;
        private System.Windows.Forms.Label lblValIp;
        private System.Windows.Forms.Label lblTitleCreated;
        private System.Windows.Forms.Label lblValCreated;
        private System.Windows.Forms.Label lblTitleLastLogin;
        private System.Windows.Forms.Label lblValLastLogin;
        private System.Windows.Forms.Label lblTitleExpiry;
        private System.Windows.Forms.Label lblValExpiry;
        private System.Windows.Forms.Label lblUpgradeTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtUpgradeKey;
        private Guna.UI2.WinForms.Guna2Button btnUpgrade;
        private System.Windows.Forms.Label lblUpgradeStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.topPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.sidebarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnNavSetting = new Guna.UI2.WinForms.Guna2Button();
            this.btnNavMisc = new Guna.UI2.WinForms.Guna2Button();
            this.btnNavSniper = new Guna.UI2.WinForms.Guna2Button();
            this.btnNavAimbot = new Guna.UI2.WinForms.Guna2Button();
            this.contentPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlAimbot = new Guna.UI2.WinForms.Guna2Panel();
            this.cardAimbot = new Guna.UI2.WinForms.Guna2Panel();
            this.tbSmooth = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lblSmoothVal = new System.Windows.Forms.Label();
            this.lblSmoothTitle = new System.Windows.Forms.Label();
            this.tbFov = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lblFovVal = new System.Windows.Forms.Label();
            this.lblFovTitle = new System.Windows.Forms.Label();
            this.cbBone = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblBoneTitle = new System.Windows.Forms.Label();
            this.swSilentAim = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lblSilentAimToggle = new System.Windows.Forms.Label();
            this.swDrawFov = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lblDrawFovToggle = new System.Windows.Forms.Label();
            this.swAimbot = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lblAimbotToggle = new System.Windows.Forms.Label();
            this.lblAimbotHeader = new System.Windows.Forms.Label();
            this.pnlSniper = new Guna.UI2.WinForms.Guna2Panel();
            this.cardSniper = new Guna.UI2.WinForms.Guna2Panel();
            this.tbScopeDelay = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lblScopeDelayVal = new System.Windows.Forms.Label();
            this.lblScopeDelayTitle = new System.Windows.Forms.Label();
            this.swBulletPrediction = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lblBulletPredictionToggle = new System.Windows.Forms.Label();
            this.swQuickSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lblQuickSwitchToggle = new System.Windows.Forms.Label();
            this.swFastScope = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lblFastScopeToggle = new System.Windows.Forms.Label();
            this.lblSniperHeader = new System.Windows.Forms.Label();
            this.pnlMisc = new Guna.UI2.WinForms.Guna2Panel();
            this.cardMisc = new Guna.UI2.WinForms.Guna2Panel();
            this.btnVerifyIntegrity = new Guna.UI2.WinForms.Guna2Button();
            this.swWatermark = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lblWatermarkToggle = new System.Windows.Forms.Label();
            this.swStreamProof = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lblStreamProofToggle = new System.Windows.Forms.Label();
            this.swBunnyHop = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lblBunnyHopToggle = new System.Windows.Forms.Label();
            this.lblMiscHeader = new System.Windows.Forms.Label();
            this.pnlSetting = new Guna.UI2.WinForms.Guna2Panel();
            this.cardSetting = new Guna.UI2.WinForms.Guna2Panel();
            this.lblUpgradeStatus = new System.Windows.Forms.Label();
            this.btnUpgrade = new Guna.UI2.WinForms.Guna2Button();
            this.txtUpgradeKey = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUpgradeTitle = new System.Windows.Forms.Label();
            this.lblValExpiry = new System.Windows.Forms.Label();
            this.lblTitleExpiry = new System.Windows.Forms.Label();
            this.lblValLastLogin = new System.Windows.Forms.Label();
            this.lblTitleLastLogin = new System.Windows.Forms.Label();
            this.lblValCreated = new System.Windows.Forms.Label();
            this.lblTitleCreated = new System.Windows.Forms.Label();
            this.lblValIp = new System.Windows.Forms.Label();
            this.lblTitleIp = new System.Windows.Forms.Label();
            this.lblValHwid = new System.Windows.Forms.Label();
            this.lblTitleHwid = new System.Windows.Forms.Label();
            this.lblValUsername = new System.Windows.Forms.Label();
            this.lblTitleUsername = new System.Windows.Forms.Label();
            this.lblSettingHeader = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.sidebarPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.pnlAimbot.SuspendLayout();
            this.cardAimbot.SuspendLayout();
            this.pnlSniper.SuspendLayout();
            this.cardSniper.SuspendLayout();
            this.pnlMisc.SuspendLayout();
            this.cardMisc.SuspendLayout();
            this.pnlSetting.SuspendLayout();
            this.cardSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 16;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 16;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.topPanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.topPanel.Controls.Add(this.lblHeaderTitle);
            this.topPanel.Controls.Add(this.btnMinimize);
            this.topPanel.Controls.Add(this.btnClose);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(820, 48);
            this.topPanel.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(18, 14);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(253, 19);
            this.lblHeaderTitle.TabIndex = 2;
            this.lblHeaderTitle.Text = "KYNEXAUTH DASHBOARD - LOADER";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimize.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnMinimize.Location = new System.Drawing.Point(736, 7);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(34, 34);
            this.btnMinimize.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnClose.HoverState.IconColor = System.Drawing.Color.White;
            this.btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnClose.Location = new System.Drawing.Point(776, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 34);
            this.btnClose.TabIndex = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.sidebarPanel.Controls.Add(this.btnLogout);
            this.sidebarPanel.Controls.Add(this.btnNavSetting);
            this.sidebarPanel.Controls.Add(this.btnNavMisc);
            this.sidebarPanel.Controls.Add(this.btnNavSniper);
            this.sidebarPanel.Controls.Add(this.btnNavAimbot);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 48);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(180, 472);
            this.sidebarPanel.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.Animated = true;
            this.btnLogout.BorderRadius = 8;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnLogout.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(14, 416);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(152, 42);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnNavSetting
            // 
            this.btnNavSetting.Animated = true;
            this.btnNavSetting.BorderRadius = 8;
            this.btnNavSetting.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNavSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavSetting.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnNavSetting.FillColor = System.Drawing.Color.Transparent;
            this.btnNavSetting.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnNavSetting.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnNavSetting.Location = new System.Drawing.Point(14, 182);
            this.btnNavSetting.Name = "btnNavSetting";
            this.btnNavSetting.Size = new System.Drawing.Size(152, 46);
            this.btnNavSetting.TabIndex = 3;
            this.btnNavSetting.Text = "⚙  SETTING";
            this.btnNavSetting.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNavSetting.Click += new System.EventHandler(this.btnNavSetting_Click);
            // 
            // btnNavMisc
            // 
            this.btnNavMisc.Animated = true;
            this.btnNavMisc.BorderRadius = 8;
            this.btnNavMisc.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNavMisc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavMisc.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnNavMisc.FillColor = System.Drawing.Color.Transparent;
            this.btnNavMisc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavMisc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnNavMisc.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnNavMisc.Location = new System.Drawing.Point(14, 128);
            this.btnNavMisc.Name = "btnNavMisc";
            this.btnNavMisc.Size = new System.Drawing.Size(152, 46);
            this.btnNavMisc.TabIndex = 2;
            this.btnNavMisc.Text = "🔧  MISC";
            this.btnNavMisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNavMisc.Click += new System.EventHandler(this.btnNavMisc_Click);
            // 
            // btnNavSniper
            // 
            this.btnNavSniper.Animated = true;
            this.btnNavSniper.BorderRadius = 8;
            this.btnNavSniper.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNavSniper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavSniper.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnNavSniper.FillColor = System.Drawing.Color.Transparent;
            this.btnNavSniper.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavSniper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnNavSniper.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnNavSniper.Location = new System.Drawing.Point(14, 74);
            this.btnNavSniper.Name = "btnNavSniper";
            this.btnNavSniper.Size = new System.Drawing.Size(152, 46);
            this.btnNavSniper.TabIndex = 1;
            this.btnNavSniper.Text = "🔭  SNIPER";
            this.btnNavSniper.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNavSniper.Click += new System.EventHandler(this.btnNavSniper_Click);
            // 
            // btnNavAimbot
            // 
            this.btnNavAimbot.Animated = true;
            this.btnNavAimbot.BorderRadius = 8;
            this.btnNavAimbot.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNavAimbot.Checked = true;
            this.btnNavAimbot.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.btnNavAimbot.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnNavAimbot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavAimbot.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnNavAimbot.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.btnNavAimbot.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavAimbot.ForeColor = System.Drawing.Color.White;
            this.btnNavAimbot.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.btnNavAimbot.Location = new System.Drawing.Point(14, 20);
            this.btnNavAimbot.Name = "btnNavAimbot";
            this.btnNavAimbot.Size = new System.Drawing.Size(152, 46);
            this.btnNavAimbot.TabIndex = 0;
            this.btnNavAimbot.Text = "🎯  AIMBOT";
            this.btnNavAimbot.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNavAimbot.Click += new System.EventHandler(this.btnNavAimbot_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(20)))));
            this.contentPanel.Controls.Add(this.pnlAimbot);
            this.contentPanel.Controls.Add(this.pnlSniper);
            this.contentPanel.Controls.Add(this.pnlMisc);
            this.contentPanel.Controls.Add(this.pnlSetting);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(180, 48);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(16);
            this.contentPanel.Size = new System.Drawing.Size(640, 472);
            this.contentPanel.TabIndex = 2;
            // 
            // pnlAimbot
            // 
            this.pnlAimbot.Controls.Add(this.cardAimbot);
            this.pnlAimbot.Controls.Add(this.lblAimbotHeader);
            this.pnlAimbot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAimbot.Location = new System.Drawing.Point(16, 16);
            this.pnlAimbot.Name = "pnlAimbot";
            this.pnlAimbot.Size = new System.Drawing.Size(608, 440);
            this.pnlAimbot.TabIndex = 0;
            // 
            // cardAimbot
            // 
            this.cardAimbot.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.cardAimbot.BorderRadius = 12;
            this.cardAimbot.BorderThickness = 1;
            this.cardAimbot.Controls.Add(this.tbSmooth);
            this.cardAimbot.Controls.Add(this.lblSmoothVal);
            this.cardAimbot.Controls.Add(this.lblSmoothTitle);
            this.cardAimbot.Controls.Add(this.tbFov);
            this.cardAimbot.Controls.Add(this.lblFovVal);
            this.cardAimbot.Controls.Add(this.lblFovTitle);
            this.cardAimbot.Controls.Add(this.cbBone);
            this.cardAimbot.Controls.Add(this.lblBoneTitle);
            this.cardAimbot.Controls.Add(this.swSilentAim);
            this.cardAimbot.Controls.Add(this.lblSilentAimToggle);
            this.cardAimbot.Controls.Add(this.swDrawFov);
            this.cardAimbot.Controls.Add(this.lblDrawFovToggle);
            this.cardAimbot.Controls.Add(this.swAimbot);
            this.cardAimbot.Controls.Add(this.lblAimbotToggle);
            this.cardAimbot.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.cardAimbot.Location = new System.Drawing.Point(8, 36);
            this.cardAimbot.Name = "cardAimbot";
            this.cardAimbot.Size = new System.Drawing.Size(590, 390);
            this.cardAimbot.TabIndex = 1;
            // 
            // tbSmooth
            // 
            this.tbSmooth.BackColor = System.Drawing.Color.Transparent;
            this.tbSmooth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbSmooth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.tbSmooth.HoverState.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.tbSmooth.Location = new System.Drawing.Point(24, 305);
            this.tbSmooth.Maximum = 30;
            this.tbSmooth.Minimum = 1;
            this.tbSmooth.Name = "tbSmooth";
            this.tbSmooth.Size = new System.Drawing.Size(532, 24);
            this.tbSmooth.TabIndex = 13;
            this.tbSmooth.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.tbSmooth.Value = 8;
            this.tbSmooth.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tbSmooth_Scroll);
            // 
            // lblSmoothVal
            // 
            this.lblSmoothVal.AutoSize = true;
            this.lblSmoothVal.BackColor = System.Drawing.Color.Transparent;
            this.lblSmoothVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmoothVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.lblSmoothVal.Location = new System.Drawing.Point(533, 278);
            this.lblSmoothVal.Name = "lblSmoothVal";
            this.lblSmoothVal.Size = new System.Drawing.Size(17, 19);
            this.lblSmoothVal.TabIndex = 12;
            this.lblSmoothVal.Text = "8";
            // 
            // lblSmoothTitle
            // 
            this.lblSmoothTitle.AutoSize = true;
            this.lblSmoothTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSmoothTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmoothTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSmoothTitle.Location = new System.Drawing.Point(24, 280);
            this.lblSmoothTitle.Name = "lblSmoothTitle";
            this.lblSmoothTitle.Size = new System.Drawing.Size(108, 17);
            this.lblSmoothTitle.TabIndex = 11;
            this.lblSmoothTitle.Text = "Aim Smoothness:";
            // 
            // tbFov
            // 
            this.tbFov.BackColor = System.Drawing.Color.Transparent;
            this.tbFov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbFov.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.tbFov.HoverState.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.tbFov.Location = new System.Drawing.Point(24, 235);
            this.tbFov.Maximum = 300;
            this.tbFov.Minimum = 10;
            this.tbFov.Name = "tbFov";
            this.tbFov.Size = new System.Drawing.Size(532, 24);
            this.tbFov.TabIndex = 10;
            this.tbFov.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.tbFov.Value = 90;
            this.tbFov.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tbFov_Scroll);
            // 
            // lblFovVal
            // 
            this.lblFovVal.AutoSize = true;
            this.lblFovVal.BackColor = System.Drawing.Color.Transparent;
            this.lblFovVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFovVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.lblFovVal.Location = new System.Drawing.Point(525, 208);
            this.lblFovVal.Name = "lblFovVal";
            this.lblFovVal.Size = new System.Drawing.Size(25, 19);
            this.lblFovVal.TabIndex = 9;
            this.lblFovVal.Text = "90";
            // 
            // lblFovTitle
            // 
            this.lblFovTitle.AutoSize = true;
            this.lblFovTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFovTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFovTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblFovTitle.Location = new System.Drawing.Point(24, 210);
            this.lblFovTitle.Name = "lblFovTitle";
            this.lblFovTitle.Size = new System.Drawing.Size(104, 17);
            this.lblFovTitle.TabIndex = 8;
            this.lblFovTitle.Text = "FOV Radius (px):";
            // 
            // cbBone
            // 
            this.cbBone.BackColor = System.Drawing.Color.Transparent;
            this.cbBone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.cbBone.BorderRadius = 8;
            this.cbBone.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.cbBone.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.cbBone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.cbBone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbBone.ForeColor = System.Drawing.Color.White;
            this.cbBone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.cbBone.ItemHeight = 30;
            this.cbBone.Items.AddRange(new object[] {
            "Head",
            "Neck",
            "Chest",
            "Pelvis"});
            this.cbBone.Location = new System.Drawing.Point(370, 144);
            this.cbBone.Name = "cbBone";
            this.cbBone.Size = new System.Drawing.Size(180, 36);
            this.cbBone.StartIndex = 0;
            this.cbBone.TabIndex = 7;
            // 
            // lblBoneTitle
            // 
            this.lblBoneTitle.AutoSize = true;
            this.lblBoneTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBoneTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoneTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblBoneTitle.Location = new System.Drawing.Point(24, 160);
            this.lblBoneTitle.Name = "lblBoneTitle";
            this.lblBoneTitle.Size = new System.Drawing.Size(81, 17);
            this.lblBoneTitle.TabIndex = 6;
            this.lblBoneTitle.Text = "Target Bone:";
            // 
            // swSilentAim
            // 
            this.swSilentAim.Animated = true;
            this.swSilentAim.BackColor = System.Drawing.Color.Transparent;
            this.swSilentAim.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.swSilentAim.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.swSilentAim.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.swSilentAim.CheckedState.InnerColor = System.Drawing.Color.White;
            this.swSilentAim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swSilentAim.Location = new System.Drawing.Point(510, 110);
            this.swSilentAim.Name = "swSilentAim";
            this.swSilentAim.Size = new System.Drawing.Size(46, 24);
            this.swSilentAim.TabIndex = 5;
            this.swSilentAim.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.swSilentAim.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.swSilentAim.UncheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.swSilentAim.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.swSilentAim.CheckedChanged += new System.EventHandler(this.swSilentAim_CheckedChanged);
            // 
            // lblSilentAimToggle
            // 
            this.lblSilentAimToggle.AutoSize = true;
            this.lblSilentAimToggle.BackColor = System.Drawing.Color.Transparent;
            this.lblSilentAimToggle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSilentAimToggle.ForeColor = System.Drawing.Color.White;
            this.lblSilentAimToggle.Location = new System.Drawing.Point(24, 112);
            this.lblSilentAimToggle.Name = "lblSilentAimToggle";
            this.lblSilentAimToggle.Size = new System.Drawing.Size(102, 19);
            this.lblSilentAimToggle.TabIndex = 4;
            this.lblSilentAimToggle.Text = "Silent Aim Lock";
            // 
            // swDrawFov
            // 
            this.swDrawFov.Animated = true;
            this.swDrawFov.BackColor = System.Drawing.Color.Transparent;
            this.swDrawFov.Checked = true;
            this.swDrawFov.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.swDrawFov.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.swDrawFov.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.swDrawFov.CheckedState.InnerColor = System.Drawing.Color.White;
            this.swDrawFov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swDrawFov.Location = new System.Drawing.Point(510, 66);
            this.swDrawFov.Name = "swDrawFov";
            this.swDrawFov.Size = new System.Drawing.Size(46, 24);
            this.swDrawFov.TabIndex = 3;
            this.swDrawFov.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.swDrawFov.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.swDrawFov.UncheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.swDrawFov.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            // 
            // lblDrawFovToggle
            // 
            this.lblDrawFovToggle.AutoSize = true;
            this.lblDrawFovToggle.BackColor = System.Drawing.Color.Transparent;
            this.lblDrawFovToggle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawFovToggle.ForeColor = System.Drawing.Color.White;
            this.lblDrawFovToggle.Location = new System.Drawing.Point(24, 68);
            this.lblDrawFovToggle.Name = "lblDrawFovToggle";
            this.lblDrawFovToggle.Size = new System.Drawing.Size(109, 19);
            this.lblDrawFovToggle.TabIndex = 2;
            this.lblDrawFovToggle.Text = "Draw FOV Circle";
            // 
            // swAimbot
            // 
            this.swAimbot.Animated = true;
            this.swAimbot.BackColor = System.Drawing.Color.Transparent;
            this.swAimbot.Checked = true;
            this.swAimbot.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.swAimbot.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.swAimbot.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.swAimbot.CheckedState.InnerColor = System.Drawing.Color.White;
            this.swAimbot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swAimbot.Location = new System.Drawing.Point(510, 22);
            this.swAimbot.Name = "swAimbot";
            this.swAimbot.Size = new System.Drawing.Size(46, 24);
            this.swAimbot.TabIndex = 1;
            this.swAimbot.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.swAimbot.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.swAimbot.UncheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.swAimbot.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            // 
            // lblAimbotToggle
            // 
            this.lblAimbotToggle.AutoSize = true;
            this.lblAimbotToggle.BackColor = System.Drawing.Color.Transparent;
            this.lblAimbotToggle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAimbotToggle.ForeColor = System.Drawing.Color.White;
            this.lblAimbotToggle.Location = new System.Drawing.Point(24, 24);
            this.lblAimbotToggle.Name = "lblAimbotToggle";
            this.lblAimbotToggle.Size = new System.Drawing.Size(98, 19);
            this.lblAimbotToggle.TabIndex = 0;
            this.lblAimbotToggle.Text = "Enable Aimbot";
            // 
            // lblAimbotHeader
            // 
            this.lblAimbotHeader.AutoSize = true;
            this.lblAimbotHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAimbotHeader.ForeColor = System.Drawing.Color.White;
            this.lblAimbotHeader.Location = new System.Drawing.Point(8, 4);
            this.lblAimbotHeader.Name = "lblAimbotHeader";
            this.lblAimbotHeader.Size = new System.Drawing.Size(222, 20);
            this.lblAimbotHeader.TabIndex = 0;
            this.lblAimbotHeader.Text = "🎯 AIMBOT CONFIGURATION";
            // 
            // pnlSniper
            // 
            this.pnlSniper.Controls.Add(this.cardSniper);
            this.pnlSniper.Controls.Add(this.lblSniperHeader);
            this.pnlSniper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSniper.Location = new System.Drawing.Point(16, 16);
            this.pnlSniper.Name = "pnlSniper";
            this.pnlSniper.Size = new System.Drawing.Size(608, 440);
            this.pnlSniper.TabIndex = 1;
            this.pnlSniper.Visible = false;
            // 
            // cardSniper
            // 
            this.cardSniper.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.cardSniper.BorderRadius = 12;
            this.cardSniper.BorderThickness = 1;
            this.cardSniper.Controls.Add(this.tbScopeDelay);
            this.cardSniper.Controls.Add(this.lblScopeDelayVal);
            this.cardSniper.Controls.Add(this.lblScopeDelayTitle);
            this.cardSniper.Controls.Add(this.swBulletPrediction);
            this.cardSniper.Controls.Add(this.lblBulletPredictionToggle);
            this.cardSniper.Controls.Add(this.swQuickSwitch);
            this.cardSniper.Controls.Add(this.lblQuickSwitchToggle);
            this.cardSniper.Controls.Add(this.swFastScope);
            this.cardSniper.Controls.Add(this.lblFastScopeToggle);
            this.cardSniper.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.cardSniper.Location = new System.Drawing.Point(8, 36);
            this.cardSniper.Name = "cardSniper";
            this.cardSniper.Size = new System.Drawing.Size(590, 390);
            this.cardSniper.TabIndex = 1;
            // 
            // tbScopeDelay
            // 
            this.tbScopeDelay.BackColor = System.Drawing.Color.Transparent;
            this.tbScopeDelay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbScopeDelay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.tbScopeDelay.HoverState.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.tbScopeDelay.Location = new System.Drawing.Point(24, 210);
            this.tbScopeDelay.Maximum = 200;
            this.tbScopeDelay.Name = "tbScopeDelay";
            this.tbScopeDelay.Size = new System.Drawing.Size(532, 24);
            this.tbScopeDelay.TabIndex = 8;
            this.tbScopeDelay.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.tbScopeDelay.Value = 25;
            this.tbScopeDelay.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tbScopeDelay_Scroll);
            // 
            // lblScopeDelayVal
            // 
            this.lblScopeDelayVal.AutoSize = true;
            this.lblScopeDelayVal.BackColor = System.Drawing.Color.Transparent;
            this.lblScopeDelayVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScopeDelayVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.lblScopeDelayVal.Location = new System.Drawing.Point(525, 183);
            this.lblScopeDelayVal.Name = "lblScopeDelayVal";
            this.lblScopeDelayVal.Size = new System.Drawing.Size(25, 19);
            this.lblScopeDelayVal.TabIndex = 7;
            this.lblScopeDelayVal.Text = "25";
            // 
            // lblScopeDelayTitle
            // 
            this.lblScopeDelayTitle.AutoSize = true;
            this.lblScopeDelayTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblScopeDelayTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScopeDelayTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblScopeDelayTitle.Location = new System.Drawing.Point(24, 185);
            this.lblScopeDelayTitle.Name = "lblScopeDelayTitle";
            this.lblScopeDelayTitle.Size = new System.Drawing.Size(112, 17);
            this.lblScopeDelayTitle.TabIndex = 6;
            this.lblScopeDelayTitle.Text = "Scope Delay (ms):";
            // 
            // swBulletPrediction
            // 
            this.swBulletPrediction.Animated = true;
            this.swBulletPrediction.BackColor = System.Drawing.Color.Transparent;
            this.swBulletPrediction.Checked = true;
            this.swBulletPrediction.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.swBulletPrediction.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.swBulletPrediction.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.swBulletPrediction.CheckedState.InnerColor = System.Drawing.Color.White;
            this.swBulletPrediction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swBulletPrediction.Location = new System.Drawing.Point(510, 123);
            this.swBulletPrediction.Name = "swBulletPrediction";
            this.swBulletPrediction.Size = new System.Drawing.Size(46, 24);
            this.swBulletPrediction.TabIndex = 5;
            this.swBulletPrediction.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.swBulletPrediction.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.swBulletPrediction.UncheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.swBulletPrediction.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            // 
            // lblBulletPredictionToggle
            // 
            this.lblBulletPredictionToggle.AutoSize = true;
            this.lblBulletPredictionToggle.BackColor = System.Drawing.Color.Transparent;
            this.lblBulletPredictionToggle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBulletPredictionToggle.ForeColor = System.Drawing.Color.White;
            this.lblBulletPredictionToggle.Location = new System.Drawing.Point(24, 125);
            this.lblBulletPredictionToggle.Name = "lblBulletPredictionToggle";
            this.lblBulletPredictionToggle.Size = new System.Drawing.Size(143, 19);
            this.lblBulletPredictionToggle.TabIndex = 4;
            this.lblBulletPredictionToggle.Text = "Bullet Drop Prediction";
            // 
            // swQuickSwitch
            // 
            this.swQuickSwitch.Animated = true;
            this.swQuickSwitch.BackColor = System.Drawing.Color.Transparent;
            this.swQuickSwitch.Checked = true;
            this.swQuickSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.swQuickSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.swQuickSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.swQuickSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.swQuickSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swQuickSwitch.Location = new System.Drawing.Point(510, 73);
            this.swQuickSwitch.Name = "swQuickSwitch";
            this.swQuickSwitch.Size = new System.Drawing.Size(46, 24);
            this.swQuickSwitch.TabIndex = 3;
            this.swQuickSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.swQuickSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.swQuickSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.swQuickSwitch.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            // 
            // lblQuickSwitchToggle
            // 
            this.lblQuickSwitchToggle.AutoSize = true;
            this.lblQuickSwitchToggle.BackColor = System.Drawing.Color.Transparent;
            this.lblQuickSwitchToggle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuickSwitchToggle.ForeColor = System.Drawing.Color.White;
            this.lblQuickSwitchToggle.Location = new System.Drawing.Point(24, 75);
            this.lblQuickSwitchToggle.Name = "lblQuickSwitchToggle";
            this.lblQuickSwitchToggle.Size = new System.Drawing.Size(161, 19);
            this.lblQuickSwitchToggle.TabIndex = 2;
            this.lblQuickSwitchToggle.Text = "Auto Quick Switch (Q-Q)";
            // 
            // swFastScope
            // 
            this.swFastScope.Animated = true;
            this.swFastScope.BackColor = System.Drawing.Color.Transparent;
            this.swFastScope.Checked = true;
            this.swFastScope.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.swFastScope.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.swFastScope.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.swFastScope.CheckedState.InnerColor = System.Drawing.Color.White;
            this.swFastScope.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swFastScope.Location = new System.Drawing.Point(510, 23);
            this.swFastScope.Name = "swFastScope";
            this.swFastScope.Size = new System.Drawing.Size(46, 24);
            this.swFastScope.TabIndex = 1;
            this.swFastScope.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.swFastScope.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.swFastScope.UncheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.swFastScope.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            // 
            // lblFastScopeToggle
            // 
            this.lblFastScopeToggle.AutoSize = true;
            this.lblFastScopeToggle.BackColor = System.Drawing.Color.Transparent;
            this.lblFastScopeToggle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFastScopeToggle.ForeColor = System.Drawing.Color.White;
            this.lblFastScopeToggle.Location = new System.Drawing.Point(24, 25);
            this.lblFastScopeToggle.Name = "lblFastScopeToggle";
            this.lblFastScopeToggle.Size = new System.Drawing.Size(117, 19);
            this.lblFastScopeToggle.TabIndex = 0;
            this.lblFastScopeToggle.Text = "Fast Scope Switch";
            // 
            // lblSniperHeader
            // 
            this.lblSniperHeader.AutoSize = true;
            this.lblSniperHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSniperHeader.ForeColor = System.Drawing.Color.White;
            this.lblSniperHeader.Location = new System.Drawing.Point(8, 4);
            this.lblSniperHeader.Name = "lblSniperHeader";
            this.lblSniperHeader.Size = new System.Drawing.Size(268, 20);
            this.lblSniperHeader.TabIndex = 0;
            this.lblSniperHeader.Text = "🔭 SNIPER ASSIST CONFIGURATION";
            // 
            // pnlMisc
            // 
            this.pnlMisc.Controls.Add(this.cardMisc);
            this.pnlMisc.Controls.Add(this.lblMiscHeader);
            this.pnlMisc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMisc.Location = new System.Drawing.Point(16, 16);
            this.pnlMisc.Name = "pnlMisc";
            this.pnlMisc.Size = new System.Drawing.Size(608, 440);
            this.pnlMisc.TabIndex = 2;
            this.pnlMisc.Visible = false;
            // 
            // cardMisc
            // 
            this.cardMisc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.cardMisc.BorderRadius = 12;
            this.cardMisc.BorderThickness = 1;
            this.cardMisc.Controls.Add(this.btnVerifyIntegrity);
            this.cardMisc.Controls.Add(this.swWatermark);
            this.cardMisc.Controls.Add(this.lblWatermarkToggle);
            this.cardMisc.Controls.Add(this.swStreamProof);
            this.cardMisc.Controls.Add(this.lblStreamProofToggle);
            this.cardMisc.Controls.Add(this.swBunnyHop);
            this.cardMisc.Controls.Add(this.lblBunnyHopToggle);
            this.cardMisc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.cardMisc.Location = new System.Drawing.Point(8, 36);
            this.cardMisc.Name = "cardMisc";
            this.cardMisc.Size = new System.Drawing.Size(590, 390);
            this.cardMisc.TabIndex = 1;
            // 
            // btnVerifyIntegrity
            // 
            this.btnVerifyIntegrity.Animated = true;
            this.btnVerifyIntegrity.BorderRadius = 8;
            this.btnVerifyIntegrity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerifyIntegrity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnVerifyIntegrity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifyIntegrity.ForeColor = System.Drawing.Color.White;
            this.btnVerifyIntegrity.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.btnVerifyIntegrity.Location = new System.Drawing.Point(24, 185);
            this.btnVerifyIntegrity.Name = "btnVerifyIntegrity";
            this.btnVerifyIntegrity.Size = new System.Drawing.Size(260, 44);
            this.btnVerifyIntegrity.TabIndex = 6;
            this.btnVerifyIntegrity.Text = "VERIFY MEMORY INTEGRITY";
            this.btnVerifyIntegrity.Click += new System.EventHandler(this.btnVerifyIntegrity_Click);
            // 
            // swWatermark
            // 
            this.swWatermark.Animated = true;
            this.swWatermark.BackColor = System.Drawing.Color.Transparent;
            this.swWatermark.Checked = true;
            this.swWatermark.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.swWatermark.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.swWatermark.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.swWatermark.CheckedState.InnerColor = System.Drawing.Color.White;
            this.swWatermark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swWatermark.Location = new System.Drawing.Point(510, 123);
            this.swWatermark.Name = "swWatermark";
            this.swWatermark.Size = new System.Drawing.Size(46, 24);
            this.swWatermark.TabIndex = 5;
            this.swWatermark.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.swWatermark.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.swWatermark.UncheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.swWatermark.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            // 
            // lblWatermarkToggle
            // 
            this.lblWatermarkToggle.AutoSize = true;
            this.lblWatermarkToggle.BackColor = System.Drawing.Color.Transparent;
            this.lblWatermarkToggle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWatermarkToggle.ForeColor = System.Drawing.Color.White;
            this.lblWatermarkToggle.Location = new System.Drawing.Point(24, 125);
            this.lblWatermarkToggle.Name = "lblWatermarkToggle";
            this.lblWatermarkToggle.Size = new System.Drawing.Size(170, 19);
            this.lblWatermarkToggle.TabIndex = 4;
            this.lblWatermarkToggle.Text = "Draw In-Game Watermark";
            // 
            // swStreamProof
            // 
            this.swStreamProof.Animated = true;
            this.swStreamProof.BackColor = System.Drawing.Color.Transparent;
            this.swStreamProof.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.swStreamProof.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.swStreamProof.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.swStreamProof.CheckedState.InnerColor = System.Drawing.Color.White;
            this.swStreamProof.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swStreamProof.Location = new System.Drawing.Point(510, 73);
            this.swStreamProof.Name = "swStreamProof";
            this.swStreamProof.Size = new System.Drawing.Size(46, 24);
            this.swStreamProof.TabIndex = 3;
            this.swStreamProof.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.swStreamProof.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.swStreamProof.UncheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.swStreamProof.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            // 
            // lblStreamProofToggle
            // 
            this.lblStreamProofToggle.AutoSize = true;
            this.lblStreamProofToggle.BackColor = System.Drawing.Color.Transparent;
            this.lblStreamProofToggle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreamProofToggle.ForeColor = System.Drawing.Color.White;
            this.lblStreamProofToggle.Location = new System.Drawing.Point(24, 75);
            this.lblStreamProofToggle.Name = "lblStreamProofToggle";
            this.lblStreamProofToggle.Size = new System.Drawing.Size(184, 19);
            this.lblStreamProofToggle.TabIndex = 2;
            this.lblStreamProofToggle.Text = "Stream-Proof / Screen Shield";
            // 
            // swBunnyHop
            // 
            this.swBunnyHop.Animated = true;
            this.swBunnyHop.BackColor = System.Drawing.Color.Transparent;
            this.swBunnyHop.Checked = true;
            this.swBunnyHop.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.swBunnyHop.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.swBunnyHop.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.swBunnyHop.CheckedState.InnerColor = System.Drawing.Color.White;
            this.swBunnyHop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swBunnyHop.Location = new System.Drawing.Point(510, 23);
            this.swBunnyHop.Name = "swBunnyHop";
            this.swBunnyHop.Size = new System.Drawing.Size(46, 24);
            this.swBunnyHop.TabIndex = 1;
            this.swBunnyHop.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.swBunnyHop.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.swBunnyHop.UncheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.swBunnyHop.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            // 
            // lblBunnyHopToggle
            // 
            this.lblBunnyHopToggle.AutoSize = true;
            this.lblBunnyHopToggle.BackColor = System.Drawing.Color.Transparent;
            this.lblBunnyHopToggle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBunnyHopToggle.ForeColor = System.Drawing.Color.White;
            this.lblBunnyHopToggle.Location = new System.Drawing.Point(24, 25);
            this.lblBunnyHopToggle.Name = "lblBunnyHopToggle";
            this.lblBunnyHopToggle.Size = new System.Drawing.Size(149, 19);
            this.lblBunnyHopToggle.TabIndex = 0;
            this.lblBunnyHopToggle.Text = "Bunny Hop Auto Jump";
            // 
            // lblMiscHeader
            // 
            this.lblMiscHeader.AutoSize = true;
            this.lblMiscHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiscHeader.ForeColor = System.Drawing.Color.White;
            this.lblMiscHeader.Location = new System.Drawing.Point(8, 4);
            this.lblMiscHeader.Name = "lblMiscHeader";
            this.lblMiscHeader.Size = new System.Drawing.Size(230, 20);
            this.lblMiscHeader.TabIndex = 0;
            this.lblMiscHeader.Text = "🔧 MISCELLANEOUS SETTINGS";
            // 
            // pnlSetting
            // 
            this.pnlSetting.Controls.Add(this.cardSetting);
            this.pnlSetting.Controls.Add(this.lblSettingHeader);
            this.pnlSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSetting.Location = new System.Drawing.Point(16, 16);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Size = new System.Drawing.Size(608, 440);
            this.pnlSetting.TabIndex = 3;
            this.pnlSetting.Visible = false;
            // 
            // cardSetting
            // 
            this.cardSetting.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.cardSetting.BorderRadius = 12;
            this.cardSetting.BorderThickness = 1;
            this.cardSetting.Controls.Add(this.lblUpgradeStatus);
            this.cardSetting.Controls.Add(this.btnUpgrade);
            this.cardSetting.Controls.Add(this.txtUpgradeKey);
            this.cardSetting.Controls.Add(this.lblUpgradeTitle);
            this.cardSetting.Controls.Add(this.lblValExpiry);
            this.cardSetting.Controls.Add(this.lblTitleExpiry);
            this.cardSetting.Controls.Add(this.lblValLastLogin);
            this.cardSetting.Controls.Add(this.lblTitleLastLogin);
            this.cardSetting.Controls.Add(this.lblValCreated);
            this.cardSetting.Controls.Add(this.lblTitleCreated);
            this.cardSetting.Controls.Add(this.lblValIp);
            this.cardSetting.Controls.Add(this.lblTitleIp);
            this.cardSetting.Controls.Add(this.lblValHwid);
            this.cardSetting.Controls.Add(this.lblTitleHwid);
            this.cardSetting.Controls.Add(this.lblValUsername);
            this.cardSetting.Controls.Add(this.lblTitleUsername);
            this.cardSetting.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.cardSetting.Location = new System.Drawing.Point(8, 36);
            this.cardSetting.Name = "cardSetting";
            this.cardSetting.Size = new System.Drawing.Size(590, 390);
            this.cardSetting.TabIndex = 1;
            // 
            // lblUpgradeStatus
            // 
            this.lblUpgradeStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblUpgradeStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblUpgradeStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblUpgradeStatus.Location = new System.Drawing.Point(24, 325);
            this.lblUpgradeStatus.Name = "lblUpgradeStatus";
            this.lblUpgradeStatus.Size = new System.Drawing.Size(480, 25);
            this.lblUpgradeStatus.TabIndex = 15;
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.Animated = true;
            this.btnUpgrade.BorderRadius = 8;
            this.btnUpgrade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpgrade.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnUpgrade.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpgrade.ForeColor = System.Drawing.Color.White;
            this.btnUpgrade.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.btnUpgrade.Location = new System.Drawing.Point(375, 275);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(130, 40);
            this.btnUpgrade.TabIndex = 14;
            this.btnUpgrade.Text = "UPGRADE";
            this.btnUpgrade.Click += new System.EventHandler(this.btnUpgrade_Click);
            // 
            // txtUpgradeKey
            // 
            this.txtUpgradeKey.Animated = true;
            this.txtUpgradeKey.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.txtUpgradeKey.BorderRadius = 8;
            this.txtUpgradeKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpgradeKey.DefaultText = "";
            this.txtUpgradeKey.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.txtUpgradeKey.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.txtUpgradeKey.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUpgradeKey.ForeColor = System.Drawing.Color.White;
            this.txtUpgradeKey.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            this.txtUpgradeKey.Location = new System.Drawing.Point(24, 275);
            this.txtUpgradeKey.Name = "txtUpgradeKey";
            this.txtUpgradeKey.PasswordChar = '\0';
            this.txtUpgradeKey.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.txtUpgradeKey.PlaceholderText = "Enter Upgrade License Key";
            this.txtUpgradeKey.SelectedText = "";
            this.txtUpgradeKey.Size = new System.Drawing.Size(340, 40);
            this.txtUpgradeKey.TabIndex = 13;
            // 
            // lblUpgradeTitle
            // 
            this.lblUpgradeTitle.AutoSize = true;
            this.lblUpgradeTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblUpgradeTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblUpgradeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblUpgradeTitle.Location = new System.Drawing.Point(24, 245);
            this.lblUpgradeTitle.Name = "lblUpgradeTitle";
            this.lblUpgradeTitle.Size = new System.Drawing.Size(216, 17);
            this.lblUpgradeTitle.TabIndex = 12;
            this.lblUpgradeTitle.Text = "Extend / Upgrade Subscription Key:";
            // 
            // lblValExpiry
            // 
            this.lblValExpiry.AutoSize = true;
            this.lblValExpiry.BackColor = System.Drawing.Color.Transparent;
            this.lblValExpiry.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblValExpiry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblValExpiry.Location = new System.Drawing.Point(180, 195);
            this.lblValExpiry.Name = "lblValExpiry";
            this.lblValExpiry.Size = new System.Drawing.Size(20, 17);
            this.lblValExpiry.TabIndex = 11;
            this.lblValExpiry.Text = "...";
            // 
            // lblTitleExpiry
            // 
            this.lblTitleExpiry.AutoSize = true;
            this.lblTitleExpiry.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleExpiry.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTitleExpiry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTitleExpiry.Location = new System.Drawing.Point(24, 195);
            this.lblTitleExpiry.Name = "lblTitleExpiry";
            this.lblTitleExpiry.Size = new System.Drawing.Size(122, 17);
            this.lblTitleExpiry.TabIndex = 10;
            this.lblTitleExpiry.Text = "Subscription Expiry:";
            // 
            // lblValLastLogin
            // 
            this.lblValLastLogin.AutoSize = true;
            this.lblValLastLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblValLastLogin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblValLastLogin.ForeColor = System.Drawing.Color.White;
            this.lblValLastLogin.Location = new System.Drawing.Point(180, 160);
            this.lblValLastLogin.Name = "lblValLastLogin";
            this.lblValLastLogin.Size = new System.Drawing.Size(20, 17);
            this.lblValLastLogin.TabIndex = 9;
            this.lblValLastLogin.Text = "...";
            // 
            // lblTitleLastLogin
            // 
            this.lblTitleLastLogin.AutoSize = true;
            this.lblTitleLastLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleLastLogin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTitleLastLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTitleLastLogin.Location = new System.Drawing.Point(24, 160);
            this.lblTitleLastLogin.Name = "lblTitleLastLogin";
            this.lblTitleLastLogin.Size = new System.Drawing.Size(102, 17);
            this.lblTitleLastLogin.TabIndex = 8;
            this.lblTitleLastLogin.Text = "Last Login Time:";
            // 
            // lblValCreated
            // 
            this.lblValCreated.AutoSize = true;
            this.lblValCreated.BackColor = System.Drawing.Color.Transparent;
            this.lblValCreated.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblValCreated.ForeColor = System.Drawing.Color.White;
            this.lblValCreated.Location = new System.Drawing.Point(180, 125);
            this.lblValCreated.Name = "lblValCreated";
            this.lblValCreated.Size = new System.Drawing.Size(20, 17);
            this.lblValCreated.TabIndex = 7;
            this.lblValCreated.Text = "...";
            // 
            // lblTitleCreated
            // 
            this.lblTitleCreated.AutoSize = true;
            this.lblTitleCreated.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleCreated.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTitleCreated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTitleCreated.Location = new System.Drawing.Point(24, 125);
            this.lblTitleCreated.Name = "lblTitleCreated";
            this.lblTitleCreated.Size = new System.Drawing.Size(107, 17);
            this.lblTitleCreated.TabIndex = 6;
            this.lblTitleCreated.Text = "Account Created:";
            // 
            // lblValIp
            // 
            this.lblValIp.AutoSize = true;
            this.lblValIp.BackColor = System.Drawing.Color.Transparent;
            this.lblValIp.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblValIp.ForeColor = System.Drawing.Color.White;
            this.lblValIp.Location = new System.Drawing.Point(180, 90);
            this.lblValIp.Name = "lblValIp";
            this.lblValIp.Size = new System.Drawing.Size(20, 17);
            this.lblValIp.TabIndex = 5;
            this.lblValIp.Text = "...";
            // 
            // lblTitleIp
            // 
            this.lblTitleIp.AutoSize = true;
            this.lblTitleIp.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleIp.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTitleIp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTitleIp.Location = new System.Drawing.Point(24, 90);
            this.lblTitleIp.Name = "lblTitleIp";
            this.lblTitleIp.Size = new System.Drawing.Size(109, 17);
            this.lblTitleIp.TabIndex = 4;
            this.lblTitleIp.Text = "Client IP Address:";
            // 
            // lblValHwid
            // 
            this.lblValHwid.AutoSize = true;
            this.lblValHwid.BackColor = System.Drawing.Color.Transparent;
            this.lblValHwid.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblValHwid.ForeColor = System.Drawing.Color.White;
            this.lblValHwid.Location = new System.Drawing.Point(180, 55);
            this.lblValHwid.Name = "lblValHwid";
            this.lblValHwid.Size = new System.Drawing.Size(20, 17);
            this.lblValHwid.TabIndex = 3;
            this.lblValHwid.Text = "...";
            // 
            // lblTitleHwid
            // 
            this.lblTitleHwid.AutoSize = true;
            this.lblTitleHwid.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleHwid.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTitleHwid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTitleHwid.Location = new System.Drawing.Point(24, 55);
            this.lblTitleHwid.Name = "lblTitleHwid";
            this.lblTitleHwid.Size = new System.Drawing.Size(129, 17);
            this.lblTitleHwid.TabIndex = 2;
            this.lblTitleHwid.Text = "Hardware ID (HWID):";
            // 
            // lblValUsername
            // 
            this.lblValUsername.AutoSize = true;
            this.lblValUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblValUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblValUsername.ForeColor = System.Drawing.Color.White;
            this.lblValUsername.Location = new System.Drawing.Point(180, 20);
            this.lblValUsername.Name = "lblValUsername";
            this.lblValUsername.Size = new System.Drawing.Size(20, 17);
            this.lblValUsername.TabIndex = 1;
            this.lblValUsername.Text = "...";
            // 
            // lblTitleUsername
            // 
            this.lblTitleUsername.AutoSize = true;
            this.lblTitleUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTitleUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTitleUsername.Location = new System.Drawing.Point(24, 20);
            this.lblTitleUsername.Name = "lblTitleUsername";
            this.lblTitleUsername.Size = new System.Drawing.Size(70, 17);
            this.lblTitleUsername.TabIndex = 0;
            this.lblTitleUsername.Text = "Username:";
            // 
            // lblSettingHeader
            // 
            this.lblSettingHeader.AutoSize = true;
            this.lblSettingHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingHeader.ForeColor = System.Drawing.Color.White;
            this.lblSettingHeader.Location = new System.Drawing.Point(8, 4);
            this.lblSettingHeader.Name = "lblSettingHeader";
            this.lblSettingHeader.Size = new System.Drawing.Size(250, 20);
            this.lblSettingHeader.TabIndex = 0;
            this.lblSettingHeader.Text = "⚙ USER PROFILE & SUBSCRIPTION";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(820, 520);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KynexAuth Dashboard";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.sidebarPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.pnlAimbot.ResumeLayout(false);
            this.pnlAimbot.PerformLayout();
            this.cardAimbot.ResumeLayout(false);
            this.cardAimbot.PerformLayout();
            this.pnlSniper.ResumeLayout(false);
            this.pnlSniper.PerformLayout();
            this.cardSniper.ResumeLayout(false);
            this.cardSniper.PerformLayout();
            this.pnlMisc.ResumeLayout(false);
            this.pnlMisc.PerformLayout();
            this.cardMisc.ResumeLayout(false);
            this.cardMisc.PerformLayout();
            this.pnlSetting.ResumeLayout(false);
            this.pnlSetting.PerformLayout();
            this.cardSetting.ResumeLayout(false);
            this.cardSetting.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
