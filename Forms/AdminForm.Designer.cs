namespace Manager_de_Jeu.Forms
{
    partial class AdminForm
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
            this.dgvGames = new System.Windows.Forms.DataGridView();
            this.grpGameDetails = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblMinPlayers = new System.Windows.Forms.Label();
            this.numMinPlayers = new System.Windows.Forms.NumericUpDown();
            this.lblMaxPlayers = new System.Windows.Forms.Label();
            this.numMaxPlayers = new System.Windows.Forms.NumericUpDown();
            this.lblCards = new System.Windows.Forms.Label();
            this.numCards = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).BeginInit();
            this.grpGameDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCards)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGames
            // 
            this.dgvGames.Location = new System.Drawing.Point(20, 20);
            this.dgvGames.Name = "dgvGames";
            this.dgvGames.Size = new System.Drawing.Size(500, 250);
            this.dgvGames.ReadOnly = true;
            this.dgvGames.AllowUserToAddRows = false;
            this.dgvGames.AllowUserToDeleteRows = false;
            this.dgvGames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 23);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(130, 70);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(150, 50);
            // 
            // numMinPlayers
            // 
            this.numMinPlayers.Location = new System.Drawing.Point(410, 30);
            this.numMinPlayers.Name = "numMinPlayers";
            this.numMinPlayers.Size = new System.Drawing.Size(60, 23);
            // 
            // numMaxPlayers
            // 
            this.numMaxPlayers.Location = new System.Drawing.Point(410, 70);
            this.numMaxPlayers.Name = "numMaxPlayers";
            this.numMaxPlayers.Size = new System.Drawing.Size(60, 23);
            // 
            // numCards
            // 
            this.numCards.Location = new System.Drawing.Point(410, 110);
            this.numCards.Name = "numCards";
            this.numCards.Size = new System.Drawing.Size(60, 23);

            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 450);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(140, 450);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(260, 450);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(380, 450);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.Text = "Effacer";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(20, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.Text = "Nom :";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(20, 70);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 23);
            this.lblDescription.Text = "Description :";
            // 
            // lblMinPlayers
            // 
            this.lblMinPlayers.Location = new System.Drawing.Point(300, 30);
            this.lblMinPlayers.Name = "lblMinPlayers";
            this.lblMinPlayers.Size = new System.Drawing.Size(100, 23);
            this.lblMinPlayers.Text = "Min. joueurs :";
            // 
            // lblMaxPlayers
            // 
            this.lblMaxPlayers.Location = new System.Drawing.Point(300, 70);
            this.lblMaxPlayers.Name = "lblMaxPlayers";
            this.lblMaxPlayers.Size = new System.Drawing.Size(100, 23);
            this.lblMaxPlayers.Text = "Max. joueurs :";
            // 
            // lblCards
            // 
            this.lblCards.Location = new System.Drawing.Point(300, 110);
            this.lblCards.Name = "lblCards";
            this.lblCards.Size = new System.Drawing.Size(100, 23);
            this.lblCards.Text = "Nb de cartes :";
            // 
            // grpGameDetails
            // 
            this.grpGameDetails.Controls.Add(this.lblName);
            this.grpGameDetails.Controls.Add(this.txtName);
            this.grpGameDetails.Controls.Add(this.lblDescription);
            this.grpGameDetails.Controls.Add(this.txtDescription);
            this.grpGameDetails.Controls.Add(this.lblMinPlayers);
            this.grpGameDetails.Controls.Add(this.numMinPlayers);
            this.grpGameDetails.Controls.Add(this.lblMaxPlayers);
            this.grpGameDetails.Controls.Add(this.numMaxPlayers);
            this.grpGameDetails.Controls.Add(this.lblCards);
            this.grpGameDetails.Controls.Add(this.numCards);
            this.grpGameDetails.Location = new System.Drawing.Point(20, 280);
            this.grpGameDetails.Name = "grpGameDetails";
            this.grpGameDetails.Size = new System.Drawing.Size(500, 150);
            this.grpGameDetails.Text = "Détails du jeu";
            // 
            // AdminForm
            // 
            this.ClientSize = new System.Drawing.Size(550, 500);
            this.Controls.Add(this.dgvGames);
            this.Controls.Add(this.grpGameDetails);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Name = "AdminForm";
            this.Text = "Administration - Gestion des jeux";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).EndInit();
            this.grpGameDetails.ResumeLayout(false);
            this.grpGameDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCards)).EndInit();
            this.ResumeLayout(false);
            
        }

        #endregion

        private DataGridView dgvGames;
        private TextBox txtName;
        private TextBox txtDescription;
        private NumericUpDown numMinPlayers;
        private NumericUpDown numMaxPlayers;
        private NumericUpDown numCards;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Label lblName;
        private Label lblDescription;
        private Label lblMinPlayers;
        private Label lblMaxPlayers;
        private Label lblCards;
        private GroupBox grpGameDetails;
    }
}