using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Location_Voiture
{
    public partial class Location : Form
    {
        Fonctions Con;
        public Voitures()
        {
            InitializeComponent();
            Con = new Fonctions();
            AfficherVoiture();
        }

        private void AfficherVoiture()
        {
            string requete = "select * from Voiture";
            Voitures_list.DataSource = Con.recupDonnee(requete);
        }

        private int GetSelectedVehicleId()
        {
            if (Voitures_list.SelectedRows.Count > 0)
            {
                int rowIndex = Voitures_list.SelectedRows[0].Index;
                return Convert.ToInt32(Voitures_list.Rows[rowIndex].Cells["voitureIdColumn"].Value);
            }
            return -1;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var parameters = new Dictionary<string, object>
    {
        { "@dateDebutPrevue", guna2DateTimePicker1.Value },
        { "@dateFinPrevue", guna2DateTimePicker2.Value },
        { "@odometreDebut", textBox4.Text },
        { "@essenceDebut", textBox1.Text },
    };
            string req = "INSERT INTO Location (dateDebutPrevue, dateFinPrevue, odometreDebut, essenceDebut) VALUES (@dateDebutPrevue, @dateFinPrevue, @odometreDebut, @essenceDebut)";
            Con.EnvoyerDonnee(req, parameters);
            MessageBox.Show("Location enregistrée avec succès.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedId = GetSelectedId();
            if (selectedId != -1)
            {
                var parameters = new Dictionary<string, object>
        {
            { "@locationId", selectedId },
            // Add other parameters as needed
        };
                string req = "UPDATE Location SET /* Columns to update */ WHERE locationId = @locationId";
                Con.EnvoyerDonnee(req, parameters);
                MessageBox.Show("Location modifiée avec succès.");
            }
            else
            {
                MessageBox.Show("Please select a location to modify.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedId = GetSelectedId();
            if (selectedId != -1)
            {
                var parameters = new Dictionary<string, object>
        {
            { "@locationId", selectedId }
        };
                string req = "DELETE FROM Location WHERE locationId = @locationId";
                Con.EnvoyerDonnee(req, parameters);
                MessageBox.Show("Location supprimée avec succès.");
            }
            else
            {
                MessageBox.Show("Please select a location to delete.");
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
