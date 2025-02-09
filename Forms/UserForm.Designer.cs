namespace Manager_de_Jeu.Forms
{
    partial class UserForm
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.cboSort = new System.Windows.Forms.ComboBox();
            this.lblTotalGames = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGames
            // 
            this.dgvGames.Location = new System.Drawing.Point(20, 20);
            this.dgvGames.Name = "dgvGames";
            this.dgvGames.Size = new System.Drawing.Size(500, 300);
            this.dgvGames.ReadOnly = true;
            this.dgvGames.AllowUserToAddRows = false;
            this.dgvGames.AllowUserToDeleteRows = false;
            this.dgvGames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(540, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 23);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cboSort
            // 
            this.cboSort.Location = new System.Drawing.Point(540, 105);
            this.cboSort.Name = "cboSort";
            this.cboSort.Size = new System.Drawing.Size(150, 23);
            this.cboSort.SelectedIndexChanged += new System.EventHandler(this.cboSort_SelectedIndexChanged);
            // Supposons que la colonne "Id" ne soit pas pertinente pour l'utilisateur final
            if (dgvGames.Columns.Contains("Id"))
            {
                dgvGames.Columns["Id"].Visible = false;
            }

            // 
            // lblTotalGames
            // 
            this.lblTotalGames.Location = new System.Drawing.Point(540, 150);
            this.lblTotalGames.Name = "lblTotalGames";
            this.lblTotalGames.Size = new System.Drawing.Size(150, 23);
            this.lblTotalGames.Text = "Total de jeux : 0";
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(540, 20);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(100, 23);
            this.lblSearch.Text = "Rechercher :";
            // 
            // lblSort
            // 
            this.lblSort.Location = new System.Drawing.Point(540, 80);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(100, 23);
            this.lblSort.Text = "Trier par :";
            // 
            // UserForm
            // 
            this.ClientSize = new System.Drawing.Size(720, 350);
            this.Controls.Add(this.dgvGames);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.cboSort);
            this.Controls.Add(this.lblTotalGames);
            this.Name = "UserForm";
            this.Text = "Bibliothèque de Jeux";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private DataGridView dgvGames;
        private TextBox txtSearch;
        private ComboBox cboSort;
        private Label lblTotalGames;
        private Label lblSearch;
        private Label lblSort;
    }
}