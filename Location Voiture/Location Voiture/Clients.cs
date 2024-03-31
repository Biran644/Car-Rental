using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Location_Voiture
{
    public partial class Clients : Form
    {
        Fonctions Con = new Fonctions();

        public Clients()
        {
            InitializeComponent();
            LoadClientsData();
        }

        private void LoadClientsData()
        {
            var query = "SELECT * FROM Client";
            var dataTable = Con.recupDonnee(query);
            guna2DataGridView1.DataSource = dataTable;
        }

        private int GetSelectedClientId()
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells["clientIdColumn"].Value);
            }
            return -1;
        }

        private void enregistrerButton_Click(object sender, EventArgs e)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@nom", textBox1.Text },
                { "@prenom", textBox6.Text },
                { "@numeroPermis", textBox4.Text },
                { "@numeroTelephone", textBox2.Text }
            };

            string query = "INSERT INTO Client (nom, prenom, dateNaissance, numeroPermis, numeroTelephone) VALUES (@nom, @prenom, @dateNaissance, @numeroPermis, @numeroTelephone)";
            Con.ExecuteSql(query, parameters); 
            LoadClientsData();
        }

        private void modifierButton_Click(object sender, EventArgs e)
        {
            int clientId = GetSelectedClientId();
            if (clientId == -1) return;

            var parameters = new Dictionary<string, object>
            {
                { "@clientId", clientId },
                
            };

            string query = "UPDATE Client SET nom = @nom, prenom = @prenom, dateNaissance = @dateNaissance, numeroPermis = @numeroPermis, numeroTelephone = @numeroTelephone WHERE clientId = @clientId";
            Con.ExecuteSql(query, parameters);
            LoadClientsData();
        }

        private void supprimerButton_Click(object sender, EventArgs e)
        {
            int clientId = GetSelectedClientId();
            if (clientId == -1) return;

            var parameters = new Dictionary<string, object> { { "@clientId", clientId } };
            string query = "DELETE FROM Client WHERE clientId = @clientId";
            Con.ExecuteSql(query, parameters);
            LoadClientsData();
        }
    }
}
