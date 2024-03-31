using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Web;
using System.Security.Cryptography.Xml;

namespace Location_Voiture
{
    internal class Fonctions
    {
        private SqlConnection Con;
        private SqlCommand cmd;
        private DataTable? dt;
        private string ConStr;
        private SqlDataAdapter? sda;

        public Fonctions()
        {
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\seren\OneDrive\Documents\TP2_Location_de_voitures.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(ConStr);
            cmd = new SqlCommand { Connection = Con };
        }

        public DataTable recupDonnee(string query)
        {
            dt = new DataTable();
            using (sda = new SqlDataAdapter(query, Con))
            {
                sda.Fill(dt);
            }
            return dt;
        }

        public int EnvoyerDonnee(string query, Dictionary<string, object> parameters)
        {
            int cnt = 0;
            using (Con)
            {
                Con.Open();
                using (cmd = new SqlCommand(query, Con))
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                    }
                    cnt = cmd.ExecuteNonQuery();
                }
                Con.Close();
            }
            return cnt;
        }
    }
}
