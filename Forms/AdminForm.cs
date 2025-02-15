﻿using Manager_de_Jeu.Services;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Manager_de_Jeu.Forms
{
    public partial class AdminForm : Form
    {
        private readonly GameService _gameService = new GameService();

        public AdminForm()
        {
            InitializeComponent();
            ApplyRoundedCorners();
            LoadGames();
        }

        private void LoadGames()
        {
            dgvGames.DataSource = _gameService.GetAllGames();
            dgvGames.ReadOnly = true;
            dgvGames.AllowUserToAddRows = false;
            dgvGames.AllowUserToDeleteRows = false;
            dgvGames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool result = _gameService.AddGame(
                txtName.Text,
                txtDescription.Text,
                (int)numMinPlayers.Value,
                (int)numMaxPlayers.Value,
                (int)numCards.Value
            );

            if (result)
            {
                MessageBox.Show("Jeu ajouté avec succès.");
                LoadGames();
            }
            else
            {
                MessageBox.Show("Erreur lors de l'ajout du jeu.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvGames.SelectedRows.Count > 0)
            {
                int gameId = Convert.ToInt32(dgvGames.SelectedRows[0].Cells["Id"].Value);
                bool result = _gameService.UpdateGame(
                    gameId,
                    txtName.Text,
                    txtDescription.Text,
                    (int)numMinPlayers.Value,
                    (int)numMaxPlayers.Value,
                    (int)numCards.Value
                );
                if (result)
                {
                    MessageBox.Show("Jeu mis à jour.");
                    LoadGames();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la mise à jour.");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvGames.SelectedRows.Count > 0)
            {
                int gameId = Convert.ToInt32(dgvGames.SelectedRows[0].Cells["Id"].Value);
                bool result = _gameService.DeleteGame(gameId);
                if (result)
                {
                    MessageBox.Show("Jeu supprimé.");
                    LoadGames();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la suppression.");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtDescription.Clear();
            numMinPlayers.Value = numMinPlayers.Minimum;
            numMaxPlayers.Value = numMaxPlayers.Minimum;
            numCards.Value = numCards.Minimum;
        }

        // Effets de survol sur les boutons
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = ColorTranslator.FromHtml("#0096A0");
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = ColorTranslator.FromHtml("#007ACC");
        }

        // Peinture du panelHeader pour afficher un dégradé
        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(panel.ClientRectangle,
                                                                           ColorTranslator.FromHtml("#007ACC"),
                                                                           ColorTranslator.FromHtml("#005B99"),
                                                                           90F))
                {
                    e.Graphics.FillRectangle(brush, panel.ClientRectangle);
                }
            }
        }

        // Application de coins arrondis aux boutons
        private void ApplyRoundedCorners()
        {
            int radius = 10;
            btnAdd.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAdd.Width, btnAdd.Height, radius, radius));
            btnUpdate.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnUpdate.Width, btnUpdate.Height, radius, radius));
            btnDelete.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDelete.Width, btnDelete.Height, radius, radius));
            btnClear.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnClear.Width, btnClear.Height, radius, radius));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // Coordonnée X du coin supérieur gauche
            int nTopRect,      // Coordonnée Y du coin supérieur gauche
            int nRightRect,    // Coordonnée X du coin inférieur droit
            int nBottomRect,   // Coordonnée Y du coin inférieur droit
            int nWidthEllipse, // Largeur de l'ellipse
            int nHeightEllipse // Hauteur de l'ellipse
        );

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
