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
            dgvGames = new DataGridView();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblSort = new Label();
            cboSort = new ComboBox();
            lblTotalGames = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGames).BeginInit();
            SuspendLayout();
            // 
            // dgvGames
            // 
            dgvGames.AllowUserToAddRows = false;
            dgvGames.AllowUserToDeleteRows = false;
            dgvGames.Location = new Point(20, 20);
            dgvGames.Name = "dgvGames";
            dgvGames.ReadOnly = true;
            dgvGames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGames.Size = new Size(500, 300);
            dgvGames.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.Location = new Point(540, 20);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(100, 23);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Rechercher :";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(540, 45);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(150, 23);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSort
            // 
            lblSort.Location = new Point(540, 80);
            lblSort.Name = "lblSort";
            lblSort.Size = new Size(100, 23);
            lblSort.TabIndex = 3;
            lblSort.Text = "Trier par :";
            // 
            // cboSort
            // 
            cboSort.Location = new Point(540, 105);
            cboSort.Name = "cboSort";
            cboSort.Size = new Size(150, 23);
            cboSort.TabIndex = 4;
            cboSort.SelectedIndexChanged += cboSort_SelectedIndexChanged;
            // 
            // lblTotalGames
            // 
            lblTotalGames.Location = new Point(540, 150);
            lblTotalGames.Name = "lblTotalGames";
            lblTotalGames.Size = new Size(150, 23);
            lblTotalGames.TabIndex = 5;
            lblTotalGames.Text = "Total de jeux : 0";
            // 
            // UserForm
            // 
            ClientSize = new Size(720, 350);
            Controls.Add(dgvGames);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSort);
            Controls.Add(cboSort);
            Controls.Add(lblTotalGames);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bibliothèque de Jeux";
            ((System.ComponentModel.ISupportInitialize)dgvGames).EndInit();
            ResumeLayout(false);
            PerformLayout();
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