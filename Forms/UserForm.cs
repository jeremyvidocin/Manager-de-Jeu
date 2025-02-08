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
    public partial class UserForm : Form
    {
        private readonly SearchService _searchService = new SearchService();
        public UserForm()
        {
            InitializeComponent();
            // Optionnel : initialiser le ComboBox avec les champs autorisés pour le tri
            cboSort.Items.AddRange(new string[] { "Name", "DateAdded", "MinPlayers" });
            cboSort.SelectedIndex = 0;
            LoadGames();
        }

        private void LoadGames()
        {
            dgvGames.DataSource = _searchService.SortGames(cboSort.SelectedItem.ToString());
            lblTotalGames.Text = $"Total de jeux : {((DataTable)dgvGames.DataSource).Rows.Count}";
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvGames.DataSource = _searchService.SearchGamesByName(txtSearch.Text);
            lblTotalGames.Text = $"Total de jeux : {((DataTable)dgvGames.DataSource).Rows.Count}";
        }

        private void cboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvGames.DataSource = _searchService.SortGames(cboSort.SelectedItem.ToString());
        }
    }
}
