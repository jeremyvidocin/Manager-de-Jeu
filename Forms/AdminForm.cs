using Manager_de_Jeu.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_de_Jeu.Forms
{
    public partial class AdminForm : Form
    {
        private readonly GameService _gameService = new GameService();
        public AdminForm()
        {
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
