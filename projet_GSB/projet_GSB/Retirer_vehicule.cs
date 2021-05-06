using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_GSB
{
    public partial class Retirer_vehicule : Form
    {
        public Retirer_vehicule()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //supprimer une voiture
            MySqlConnection connexion = new MySqlConnection("database=gsb; server=localhost; user id=root ;pwd=");

            try
            {
                connexion.Open();

                MySqlCommand command = connexion.CreateCommand();

                command.CommandText = "SELECT immatriculation FROM vehicule";

                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    string immatriculation = Convert.ToString(dataReader["immatriculation"]);
                    if (tb_immatriculation.Text == immatriculation)
                    {
                        MySqlConnection connexion2 = new MySqlConnection("database=gsb; server=localhost; user id=root ;pwd=");
                        connexion2.Open();
                        string myInsertQuery = "DELETE FROM vehicule WHERE immatriculation = \"" + immatriculation + "\"";
                        MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                        myCommand.Connection = connexion2;
                        // Exécution de la requête
                        myCommand.ExecuteNonQuery();
                        connexion2.Close();

                        this.Close();
                        break;
                    }
                }
                connexion.Close();
            }
            catch //(Exception ex)
            {
                MessageBox.Show("Erreur de connexion a la bdd !");
            }
            this.Close();
        }

        private void Retirer_vehicule_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }
    }
}
