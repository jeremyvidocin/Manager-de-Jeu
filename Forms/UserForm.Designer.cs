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
            txtSearch = new TextBox();
            cboSort = new ComboBox();
            lblTotalGames = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGames).BeginInit();
            SuspendLayout();
            // 
            // dgvGames
            // 
            dgvGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGames.Location = new Point(12, 12);
            dgvGames.Name = "dgvGames";
            dgvGames.Size = new Size(437, 348);
            dgvGames.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(487, 30);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cboSort
            // 
            cboSort.FormattingEnabled = true;
            cboSort.Location = new Point(487, 93);
            cboSort.Name = "cboSort";
            cboSort.Size = new Size(121, 23);
            cboSort.TabIndex = 2;
            cboSort.SelectedIndexChanged += cboSort_SelectedIndexChanged;
            // 
            // lblTotalGames
            // 
            lblTotalGames.AutoSize = true;
            lblTotalGames.Location = new Point(501, 195);
            lblTotalGames.Name = "lblTotalGames";
            lblTotalGames.Size = new Size(38, 15);
            lblTotalGames.TabIndex = 3;
            lblTotalGames.Text = "label1";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotalGames);
            Controls.Add(cboSort);
            Controls.Add(txtSearch);
            Controls.Add(dgvGames);
            Name = "UserForm";
            Text = "UserForm";
            Load += UserForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGames).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvGames;
        private TextBox txtSearch;
        private ComboBox cboSort;
        private Label lblTotalGames;
    }
}