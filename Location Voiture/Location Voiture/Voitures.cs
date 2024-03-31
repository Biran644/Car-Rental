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
    public partial class Voitures : Form
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
            String requete = "select * from Voiture";
            Voitures_list.DataSource = Con.recupDonnee(requete);

        }

        private int GetSelectedVehicleId()
        {
            if (Voitures_list.SelectedRows.Count > 0)
            {
                int rowIndex = Voitures_list.SelectedRows[0].Index;
                if (Voitures_list.Rows[rowIndex].Cells["voitureIdColumn"].Value != null) // Replace "voitureIdColumn" with the actual name of the ID column
                {
                    return Convert.ToInt32(Voitures_list.Rows[rowIndex].Cells["voitureIdColumn"].Value);
                }
            }
            return -1; 
        }



        private void enregistrer_bt_Click(object sender, EventArgs e)
        {
            if (numeroDeSerie_tb.Text == "" || marque_cb.SelectedIndex == -1 || modele_tb.Text == "" || couleur_cb.SelectedIndex == -1 || dateAchat_dtp.Value == null || descriptionFr_cb.SelectedIndex == -1)
            {
                MessageBox.Show("Information Incomplete!!!");
            }
            else
            {
                try
                {
                    var parameters = new Dictionary<string, object>
                    {
                        { "@numeroSerie", numeroDeSerie_tb.Text },
                        { "@marque", marque_cb.SelectedItem.ToString() },
                        { "@modele", modele_tb.Text },
                        { "@couleur", couleur_cb.SelectedItem.ToString() },
                        { "@dateAchat", dateAchat_dtp.Value },
                        { "@dateRevision", dateRevision_dtp.Checked ? (object)dateRevision_dtp.Value : DBNull.Value },
                        { "@descriptionFr", descriptionFr_cb.SelectedItem.ToString() }
                    };

                    string req = "insert into Voiture (numeroSerie, marque, modele, couleur, dateAchat, dateRevision, descriptionFr) values(@numeroSerie, @marque, @modele, @couleur, @dateAchat, @dateRevision, @descriptionFr)";

                    Con.EnvoyerDonnee(req, parameters);
                    AfficherVoiture();
                    MessageBox.Show("Vehicule Enregistré avec success !!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void modifier_bt_Click(object sender, EventArgs e)
        {
            int selectedVehicleId = GetSelectedVehicleId();
            if (selectedVehicleId != -1)
            {
                var parameters = new Dictionary<string, object>
        {

            { "@voitureId", selectedVehicleId },
            };

                string req = "UPDATE Voiture SET numeroSerie = @numeroSerie, marque = @marque, modele = @modele, couleur = @couleur, dateAchat = @dateAchat, dateRevision = @dateRevision, descriptionFr = @descriptionFr WHERE voitureId = @voitureId";

                try
                {
                    Con.EnvoyerDonnee(req, parameters);
                    AfficherVoiture();
                    MessageBox.Show("Vehicle updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a vehicle to modify.");
            }
        }


        private void supprimer_bt_Click(object sender, EventArgs e)
        {
            int selectedVehicleId = GetSelectedVehicleId();
            if (selectedVehicleId != -1)
            {
                var parameters = new Dictionary<string, object>
        {
            { "@voitureId", selectedVehicleId }
        };

                string req = "DELETE FROM Voiture WHERE voitureId = @voitureId";

                try
                {
                    Con.EnvoyerDonnee(req, parameters);
                    AfficherVoiture();
                    MessageBox.Show("Vehicle deleted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a vehicle to delete.");
            }
        }
    }  

    }
