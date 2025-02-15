namespace Manager_de_Jeu.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            btnLogin = new Button();
            txtPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            lblTitle = new Label();
            lblPassword = new Label();
            txtUsername = new Bunifu.UI.WinForms.BunifuTextBox();
            lblUsername = new Label();
            lblError = new Label();
            panelContainer = new Panel();
            bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBox1).BeginInit();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // bunifuShadowPanel1
            // 
            bunifuShadowPanel1.BackColor = Color.Transparent;
            bunifuShadowPanel1.BorderColor = Color.WhiteSmoke;
            bunifuShadowPanel1.BorderRadius = 1;
            bunifuShadowPanel1.BorderThickness = 1;
            bunifuShadowPanel1.Controls.Add(bunifuPictureBox1);
            bunifuShadowPanel1.Controls.Add(btnLogin);
            bunifuShadowPanel1.Controls.Add(txtPassword);
            bunifuShadowPanel1.Controls.Add(lblTitle);
            bunifuShadowPanel1.Controls.Add(lblPassword);
            bunifuShadowPanel1.Controls.Add(txtUsername);
            bunifuShadowPanel1.Controls.Add(lblUsername);
            bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            resources.ApplyResources(bunifuShadowPanel1, "bunifuShadowPanel1");
            bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            bunifuShadowPanel1.PanelColor = Color.WhiteSmoke;
            bunifuShadowPanel1.PanelColor2 = Color.WhiteSmoke;
            bunifuShadowPanel1.ShadowColor = Color.DarkGray;
            bunifuShadowPanel1.ShadowDept = 2;
            bunifuShadowPanel1.ShadowDepth = 5;
            bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            bunifuShadowPanel1.ShadowTopLeftVisible = false;
            bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            // 
            // bunifuPictureBox1
            // 
            bunifuPictureBox1.AllowFocused = false;
            resources.ApplyResources(bunifuPictureBox1, "bunifuPictureBox1");
            bunifuPictureBox1.AutoSizeHeight = true;
            bunifuPictureBox1.BorderRadius = 35;
            bunifuPictureBox1.IsCircle = true;
            bunifuPictureBox1.Name = "bunifuPictureBox1";
            bunifuPictureBox1.TabStop = false;
            bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 122, 204);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.ForeColor = Color.White;
            btnLogin.Name = "btnLogin";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.MouseEnter += btnLogin_MouseEnter;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            // 
            // txtPassword
            // 
            txtPassword.AcceptsReturn = false;
            txtPassword.AcceptsTab = false;
            txtPassword.AnimationSpeed = 200;
            txtPassword.AutoCompleteMode = AutoCompleteMode.None;
            txtPassword.AutoCompleteSource = AutoCompleteSource.None;
            txtPassword.AutoSizeHeight = true;
            txtPassword.BackColor = Color.Transparent;
            resources.ApplyResources(txtPassword, "txtPassword");
            txtPassword.BorderColorActive = Color.DodgerBlue;
            txtPassword.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            txtPassword.BorderColorHover = Color.FromArgb(105, 181, 255);
            txtPassword.BorderColorIdle = Color.Silver;
            txtPassword.BorderRadius = 1;
            txtPassword.BorderThickness = 1;
            txtPassword.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            txtPassword.CharacterCasing = CharacterCasing.Normal;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.DefaultFont = new Font("Segoe UI", 9.25F);
            txtPassword.DefaultText = "";
            txtPassword.FillColor = Color.White;
            txtPassword.HideSelection = true;
            txtPassword.IconLeft = null;
            txtPassword.IconLeftCursor = Cursors.IBeam;
            txtPassword.IconPadding = 10;
            txtPassword.IconRight = null;
            txtPassword.IconRightCursor = Cursors.IBeam;
            txtPassword.MaxLength = 32767;
            txtPassword.Modified = false;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            stateProperties9.BorderColor = Color.DodgerBlue;
            stateProperties9.FillColor = Color.Empty;
            stateProperties9.ForeColor = Color.Empty;
            stateProperties9.PlaceholderForeColor = Color.Empty;
            txtPassword.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties10.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties10.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties10.PlaceholderForeColor = Color.DarkGray;
            txtPassword.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties11.FillColor = Color.Empty;
            stateProperties11.ForeColor = Color.Empty;
            stateProperties11.PlaceholderForeColor = Color.Empty;
            txtPassword.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = Color.Silver;
            stateProperties12.FillColor = Color.White;
            stateProperties12.ForeColor = Color.Empty;
            stateProperties12.PlaceholderForeColor = Color.Empty;
            txtPassword.OnIdleState = stateProperties12;
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderForeColor = Color.Silver;
            txtPassword.PlaceholderText = "";
            txtPassword.ReadOnly = false;
            txtPassword.ScrollBars = ScrollBars.None;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.ShortcutsEnabled = true;
            txtPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            txtPassword.TextAlign = HorizontalAlignment.Left;
            txtPassword.TextMarginBottom = 0;
            txtPassword.TextMarginLeft = 3;
            txtPassword.TextMarginTop = 1;
            txtPassword.TextPlaceholder = "";
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.WordWrap = true;
            // 
            // lblTitle
            // 
            resources.ApplyResources(lblTitle, "lblTitle");
            lblTitle.ForeColor = Color.FromArgb(32, 32, 32);
            lblTitle.Name = "lblTitle";
            // 
            // lblPassword
            // 
            resources.ApplyResources(lblPassword, "lblPassword");
            lblPassword.ForeColor = Color.DimGray;
            lblPassword.Name = "lblPassword";
            // 
            // txtUsername
            // 
            txtUsername.AcceptsReturn = false;
            txtUsername.AcceptsTab = false;
            txtUsername.AnimationSpeed = 200;
            txtUsername.AutoCompleteMode = AutoCompleteMode.None;
            txtUsername.AutoCompleteSource = AutoCompleteSource.None;
            txtUsername.AutoSizeHeight = true;
            txtUsername.BackColor = Color.Transparent;
            resources.ApplyResources(txtUsername, "txtUsername");
            txtUsername.BorderColorActive = Color.DodgerBlue;
            txtUsername.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            txtUsername.BorderColorHover = Color.FromArgb(105, 181, 255);
            txtUsername.BorderColorIdle = Color.Silver;
            txtUsername.BorderRadius = 1;
            txtUsername.BorderThickness = 1;
            txtUsername.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            txtUsername.CharacterCasing = CharacterCasing.Normal;
            txtUsername.DefaultFont = new Font("Segoe UI", 9.25F);
            txtUsername.DefaultText = "";
            txtUsername.FillColor = Color.White;
            txtUsername.HideSelection = true;
            txtUsername.IconLeft = null;
            txtUsername.IconLeftCursor = Cursors.IBeam;
            txtUsername.IconPadding = 10;
            txtUsername.IconRight = null;
            txtUsername.IconRightCursor = Cursors.IBeam;
            txtUsername.MaxLength = 32767;
            txtUsername.Modified = false;
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            stateProperties13.BorderColor = Color.DodgerBlue;
            stateProperties13.FillColor = Color.Empty;
            stateProperties13.ForeColor = Color.Empty;
            stateProperties13.PlaceholderForeColor = Color.Empty;
            txtUsername.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties14.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties14.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties14.PlaceholderForeColor = Color.DarkGray;
            txtUsername.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties15.FillColor = Color.Empty;
            stateProperties15.ForeColor = Color.Empty;
            stateProperties15.PlaceholderForeColor = Color.Empty;
            txtUsername.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = Color.Silver;
            stateProperties16.FillColor = Color.White;
            stateProperties16.ForeColor = Color.Empty;
            stateProperties16.PlaceholderForeColor = Color.Empty;
            txtUsername.OnIdleState = stateProperties16;
            txtUsername.PasswordChar = '\0';
            txtUsername.PlaceholderForeColor = Color.Silver;
            txtUsername.PlaceholderText = "";
            txtUsername.ReadOnly = false;
            txtUsername.ScrollBars = ScrollBars.None;
            txtUsername.SelectedText = "";
            txtUsername.SelectionLength = 0;
            txtUsername.SelectionStart = 0;
            txtUsername.ShortcutsEnabled = true;
            txtUsername.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            txtUsername.TextAlign = HorizontalAlignment.Left;
            txtUsername.TextMarginBottom = 0;
            txtUsername.TextMarginLeft = 3;
            txtUsername.TextMarginTop = 1;
            txtUsername.TextPlaceholder = "";
            txtUsername.UseSystemPasswordChar = false;
            txtUsername.WordWrap = true;
            // 
            // lblUsername
            // 
            resources.ApplyResources(lblUsername, "lblUsername");
            lblUsername.ForeColor = Color.DimGray;
            lblUsername.Name = "lblUsername";
            // 
            // lblError
            // 
            resources.ApplyResources(lblError, "lblError");
            lblError.ForeColor = Color.Firebrick;
            lblError.Name = "lblError";
            // 
            // panelContainer
            // 
            resources.ApplyResources(panelContainer, "panelContainer");
            panelContainer.BackColor = Color.White;
            panelContainer.Controls.Add(lblError);
            panelContainer.Name = "panelContainer";
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 249);
            Controls.Add(bunifuShadowPanel1);
            Controls.Add(panelContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            bunifuShadowPanel1.ResumeLayout(false);
            bunifuShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBox1).EndInit();
            panelContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Label lblTitle;
        private Bunifu.UI.WinForms.BunifuTextBox txtUsername;
        private Label lblUsername;
        private Label lblError;
        private Button btnLogin;
        private Label lblPassword;
        private Bunifu.UI.WinForms.BunifuTextBox txtPassword;
        private Panel panelContainer;
    }
}