namespace Manager_de_Jeu.Forms
{
    partial class AdminForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.NumericUpDown numMinPlayers;
        private System.Windows.Forms.NumericUpDown numMaxPlayers;
        private System.Windows.Forms.NumericUpDown numCards;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblMinPlayers;
        private System.Windows.Forms.Label lblMaxPlayers;
        private System.Windows.Forms.Label lblCards;
        private System.Windows.Forms.GroupBox grpGameDetails;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            grpGameDetails = new GroupBox();
            txtDescription = new Bunifu.UI.WinForms.BunifuTextBox();
            txtName = new Bunifu.UI.WinForms.BunifuTextBox();
            lblName = new Label();
            lblDescription = new Label();
            lblMinPlayers = new Label();
            numMinPlayers = new NumericUpDown();
            lblMaxPlayers = new Label();
            numMaxPlayers = new NumericUpDown();
            lblCards = new Label();
            numCards = new NumericUpDown();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            panelHeader = new Panel();
            lblTitle = new Label();
            bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            dgvGames = new Bunifu.UI.WinForms.BunifuDataGridView();
            grpGameDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMinPlayers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMaxPlayers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCards).BeginInit();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGames).BeginInit();
            SuspendLayout();
            // 
            // grpGameDetails
            // 
            grpGameDetails.Controls.Add(txtDescription);
            grpGameDetails.Controls.Add(txtName);
            grpGameDetails.Controls.Add(lblName);
            grpGameDetails.Controls.Add(lblDescription);
            grpGameDetails.Controls.Add(lblMinPlayers);
            grpGameDetails.Controls.Add(numMinPlayers);
            grpGameDetails.Controls.Add(lblMaxPlayers);
            grpGameDetails.Controls.Add(numMaxPlayers);
            grpGameDetails.Controls.Add(lblCards);
            grpGameDetails.Controls.Add(numCards);
            grpGameDetails.Font = new Font("Segoe UI", 10F);
            grpGameDetails.ForeColor = Color.FromArgb(64, 64, 64);
            grpGameDetails.Location = new Point(194, 455);
            grpGameDetails.Name = "grpGameDetails";
            grpGameDetails.Size = new Size(700, 194);
            grpGameDetails.TabIndex = 0;
            grpGameDetails.TabStop = false;
            grpGameDetails.Text = "DÉTAILS DU JEU";
            // 
            // txtDescription
            // 
            txtDescription.AcceptsReturn = false;
            txtDescription.AcceptsTab = false;
            txtDescription.AnimationSpeed = 200;
            txtDescription.AutoCompleteMode = AutoCompleteMode.None;
            txtDescription.AutoCompleteSource = AutoCompleteSource.None;
            txtDescription.AutoSizeHeight = true;
            txtDescription.BackColor = Color.Transparent;
            txtDescription.BackgroundImage = (Image)resources.GetObject("txtDescription.BackgroundImage");
            txtDescription.BorderColorActive = Color.DodgerBlue;
            txtDescription.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            txtDescription.BorderColorHover = Color.FromArgb(105, 181, 255);
            txtDescription.BorderColorIdle = Color.Silver;
            txtDescription.BorderRadius = 1;
            txtDescription.BorderThickness = 1;
            txtDescription.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            txtDescription.CharacterCasing = CharacterCasing.Normal;
            txtDescription.DefaultFont = new Font("Segoe UI", 9.25F);
            txtDescription.DefaultText = "";
            txtDescription.FillColor = Color.White;
            txtDescription.HideSelection = true;
            txtDescription.IconLeft = null;
            txtDescription.IconLeftCursor = Cursors.IBeam;
            txtDescription.IconPadding = 10;
            txtDescription.IconRight = null;
            txtDescription.IconRightCursor = Cursors.IBeam;
            txtDescription.Location = new Point(20, 116);
            txtDescription.MaxLength = 32767;
            txtDescription.MinimumSize = new Size(1, 1);
            txtDescription.Modified = false;
            txtDescription.Multiline = false;
            txtDescription.Name = "txtDescription";
            stateProperties9.BorderColor = Color.DodgerBlue;
            stateProperties9.FillColor = Color.Empty;
            stateProperties9.ForeColor = Color.Empty;
            stateProperties9.PlaceholderForeColor = Color.Empty;
            txtDescription.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties10.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties10.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties10.PlaceholderForeColor = Color.DarkGray;
            txtDescription.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties11.FillColor = Color.Empty;
            stateProperties11.ForeColor = Color.Empty;
            stateProperties11.PlaceholderForeColor = Color.Empty;
            txtDescription.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = Color.Silver;
            stateProperties12.FillColor = Color.White;
            stateProperties12.ForeColor = Color.Empty;
            stateProperties12.PlaceholderForeColor = Color.Empty;
            txtDescription.OnIdleState = stateProperties12;
            txtDescription.Padding = new Padding(3);
            txtDescription.PasswordChar = '\0';
            txtDescription.PlaceholderForeColor = Color.Silver;
            txtDescription.PlaceholderText = "";
            txtDescription.ReadOnly = false;
            txtDescription.ScrollBars = ScrollBars.None;
            txtDescription.SelectedText = "";
            txtDescription.SelectionLength = 0;
            txtDescription.SelectionStart = 0;
            txtDescription.ShortcutsEnabled = true;
            txtDescription.Size = new Size(260, 62);
            txtDescription.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            txtDescription.TabIndex = 2;
            txtDescription.TextAlign = HorizontalAlignment.Left;
            txtDescription.TextMarginBottom = 0;
            txtDescription.TextMarginLeft = 3;
            txtDescription.TextMarginTop = 1;
            txtDescription.TextPlaceholder = "";
            txtDescription.UseSystemPasswordChar = false;
            txtDescription.WordWrap = true;
            // 
            // txtName
            // 
            txtName.AcceptsReturn = false;
            txtName.AcceptsTab = false;
            txtName.AnimationSpeed = 200;
            txtName.AutoCompleteMode = AutoCompleteMode.None;
            txtName.AutoCompleteSource = AutoCompleteSource.None;
            txtName.AutoSizeHeight = true;
            txtName.BackColor = Color.Transparent;
            txtName.BackgroundImage = (Image)resources.GetObject("txtName.BackgroundImage");
            txtName.BorderColorActive = Color.DodgerBlue;
            txtName.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            txtName.BorderColorHover = Color.FromArgb(105, 181, 255);
            txtName.BorderColorIdle = Color.Silver;
            txtName.BorderRadius = 1;
            txtName.BorderThickness = 1;
            txtName.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            txtName.CharacterCasing = CharacterCasing.Normal;
            txtName.DefaultFont = new Font("Segoe UI", 9.25F);
            txtName.DefaultText = "";
            txtName.FillColor = Color.White;
            txtName.HideSelection = true;
            txtName.IconLeft = null;
            txtName.IconLeftCursor = Cursors.IBeam;
            txtName.IconPadding = 10;
            txtName.IconRight = null;
            txtName.IconRightCursor = Cursors.IBeam;
            txtName.Location = new Point(20, 55);
            txtName.MaxLength = 32767;
            txtName.MinimumSize = new Size(1, 1);
            txtName.Modified = false;
            txtName.Multiline = false;
            txtName.Name = "txtName";
            stateProperties13.BorderColor = Color.DodgerBlue;
            stateProperties13.FillColor = Color.Empty;
            stateProperties13.ForeColor = Color.Empty;
            stateProperties13.PlaceholderForeColor = Color.Empty;
            txtName.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties14.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties14.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties14.PlaceholderForeColor = Color.DarkGray;
            txtName.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties15.FillColor = Color.Empty;
            stateProperties15.ForeColor = Color.Empty;
            stateProperties15.PlaceholderForeColor = Color.Empty;
            txtName.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = Color.Silver;
            stateProperties16.FillColor = Color.White;
            stateProperties16.ForeColor = Color.Empty;
            stateProperties16.PlaceholderForeColor = Color.Empty;
            txtName.OnIdleState = stateProperties16;
            txtName.Padding = new Padding(3);
            txtName.PasswordChar = '\0';
            txtName.PlaceholderForeColor = Color.Silver;
            txtName.PlaceholderText = "";
            txtName.ReadOnly = false;
            txtName.ScrollBars = ScrollBars.None;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.ShortcutsEnabled = true;
            txtName.Size = new Size(260, 39);
            txtName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            txtName.TabIndex = 1;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TextMarginBottom = 0;
            txtName.TextMarginLeft = 3;
            txtName.TextMarginTop = 1;
            txtName.TextPlaceholder = "";
            txtName.UseSystemPasswordChar = false;
            txtName.WordWrap = true;
            // 
            // lblName
            // 
            lblName.Location = new Point(20, 30);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Nom :";
            // 
            // lblDescription
            // 
            lblDescription.Location = new Point(20, 90);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(100, 23);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Description :";
            // 
            // lblMinPlayers
            // 
            lblMinPlayers.Location = new Point(350, 30);
            lblMinPlayers.Name = "lblMinPlayers";
            lblMinPlayers.Size = new Size(100, 23);
            lblMinPlayers.TabIndex = 0;
            lblMinPlayers.Text = "Min Joueurs :";
            // 
            // numMinPlayers
            // 
            numMinPlayers.Location = new Point(350, 55);
            numMinPlayers.Name = "numMinPlayers";
            numMinPlayers.Size = new Size(100, 25);
            numMinPlayers.TabIndex = 0;
            // 
            // lblMaxPlayers
            // 
            lblMaxPlayers.Location = new Point(350, 90);
            lblMaxPlayers.Name = "lblMaxPlayers";
            lblMaxPlayers.Size = new Size(100, 23);
            lblMaxPlayers.TabIndex = 0;
            lblMaxPlayers.Text = "Max Joueurs :";
            // 
            // numMaxPlayers
            // 
            numMaxPlayers.Location = new Point(350, 115);
            numMaxPlayers.Name = "numMaxPlayers";
            numMaxPlayers.Size = new Size(100, 25);
            numMaxPlayers.TabIndex = 0;
            // 
            // lblCards
            // 
            lblCards.Location = new Point(500, 30);
            lblCards.Name = "lblCards";
            lblCards.Size = new Size(100, 23);
            lblCards.TabIndex = 0;
            lblCards.Text = "Cartes :";
            // 
            // numCards
            // 
            numCards.Location = new Point(500, 55);
            numCards.Name = "numCards";
            numCards.Size = new Size(100, 25);
            numCards.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 122, 204);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(1035, 104);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 40);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Ajouter";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            btnAdd.MouseEnter += Button_MouseEnter;
            btnAdd.MouseLeave += Button_MouseLeave;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 122, 204);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(1035, 186);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 40);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Modifier";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            btnUpdate.MouseEnter += Button_MouseEnter;
            btnUpdate.MouseLeave += Button_MouseLeave;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(0, 122, 204);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1035, 274);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 40);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Supprimer";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseEnter += Button_MouseEnter;
            btnDelete.MouseLeave += Button_MouseLeave;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(0, 122, 204);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(933, 538);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 40);
            btnClear.TabIndex = 6;
            btnClear.Text = "Effacer";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            btnClear.MouseEnter += Button_MouseEnter;
            btnClear.MouseLeave += Button_MouseLeave;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1180, 60);
            panelHeader.TabIndex = 0;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1180, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "GESTION DES JEUX";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bunifuShadowPanel1
            // 
            bunifuShadowPanel1.BackColor = Color.Transparent;
            bunifuShadowPanel1.BorderColor = Color.WhiteSmoke;
            bunifuShadowPanel1.BorderRadius = 1;
            bunifuShadowPanel1.BorderThickness = 1;
            bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            bunifuShadowPanel1.Location = new Point(180, 66);
            bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            bunifuShadowPanel1.PanelColor = Color.WhiteSmoke;
            bunifuShadowPanel1.PanelColor2 = Color.WhiteSmoke;
            bunifuShadowPanel1.ShadowColor = Color.DarkGray;
            bunifuShadowPanel1.ShadowDept = 2;
            bunifuShadowPanel1.ShadowDepth = 5;
            bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            bunifuShadowPanel1.ShadowTopLeftVisible = false;
            bunifuShadowPanel1.Size = new Size(839, 383);
            bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            bunifuShadowPanel1.TabIndex = 7;
            // 
            // dgvGames
            // 
            dgvGames.AllowCustomTheming = false;
            dgvGames.AllowUserToAddRows = false;
            dgvGames.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dgvGames.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvGames.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGames.BorderStyle = BorderStyle.None;
            dgvGames.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGames.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvGames.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvGames.ColumnHeadersHeight = 40;
            dgvGames.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(248, 251, 255);
            dgvGames.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dgvGames.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            dgvGames.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dgvGames.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            dgvGames.CurrentTheme.BackColor = Color.White;
            dgvGames.CurrentTheme.GridColor = Color.FromArgb(221, 238, 255);
            dgvGames.CurrentTheme.HeaderStyle.BackColor = Color.DodgerBlue;
            dgvGames.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dgvGames.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            dgvGames.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dgvGames.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            dgvGames.CurrentTheme.Name = null;
            dgvGames.CurrentTheme.RowsStyle.BackColor = Color.White;
            dgvGames.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dgvGames.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            dgvGames.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dgvGames.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvGames.DefaultCellStyle = dataGridViewCellStyle6;
            dgvGames.EnableHeadersVisualStyles = false;
            dgvGames.GridColor = Color.FromArgb(221, 238, 255);
            dgvGames.HeaderBackColor = Color.DodgerBlue;
            dgvGames.HeaderBgColor = Color.Empty;
            dgvGames.HeaderForeColor = Color.White;
            dgvGames.Location = new Point(180, 66);
            dgvGames.Name = "dgvGames";
            dgvGames.ReadOnly = true;
            dgvGames.RowHeadersVisible = false;
            dgvGames.RowTemplate.Height = 40;
            dgvGames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGames.Size = new Size(833, 377);
            dgvGames.TabIndex = 0;
            dgvGames.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // AdminForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1180, 699);
            Controls.Add(grpGameDetails);
            Controls.Add(dgvGames);
            Controls.Add(bunifuShadowPanel1);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(panelHeader);
            Controls.Add(btnClear);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administration - Gestion des jeux";
            grpGameDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numMinPlayers).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMaxPlayers).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCards).EndInit();
            panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGames).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvGames;
        private Bunifu.UI.WinForms.BunifuTextBox txtName;
        private Bunifu.UI.WinForms.BunifuTextBox txtDescription;
    }
}
