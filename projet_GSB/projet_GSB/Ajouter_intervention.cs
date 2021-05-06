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
    public partial class Ajouter_intervention : Form
    {
        public Ajouter_intervention()
        {
            InitializeComponent();
        }

        private void bt_ajoute_intervention_Click(object sender, EventArgs e)
        {
            MySqlConnection connexion = new MySqlConnection("database=gsb; server=localhost; user id=root ;pwd=");

            try
            {
                connexion.Open();

                MySqlCommand command = connexion.CreateCommand();

                command.CommandText = "SELECT immatriculation FROM vehicule";

                MySqlDataReader dataReader = command.ExecuteReader();

                bool message = false;

                while (dataReader.Read())
                {
                    string immatriculation = Convert.ToString(dataReader["immatriculation"]);
                    if (tb_immaInter.Text == immatriculation)
                    {
                        message = false;
                        MySqlConnection connexion2 = new MySqlConnection("database=gsb; server=localhost; user id=root ;pwd=");
                        connexion2.Open();
                        string myInsertQuery = "INSERT INTO entretien_vehicule (type_frais, cout_frais, date_EntreEntretien, immatriculation, date_SortieEntretien) VALUES (\"" + tbTypeFrais.Text + "\", " + tbCoutFrais.Text + ", \"" + tbDateEntrer.Text + "\", \"" + tb_immaInter.Text + "\", \"" + tbDateSortie.Text + "\")";
                        MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                        myCommand.Connection = connexion2;
                        // Exécution de la requête
                        myCommand.ExecuteNonQuery();
                        connexion2.Close();

                        this.Close();
                        break;
                    }
                    else
                    {
                        message = true;
                    }
                }
                if (message == true)
                {
                    MessageBox.Show("Immatricule inconnue !");
                }
                connexion.Close();

            }
            catch //(Exception ex)
            {
                MessageBox.Show("Erreur de connexion a la bdd !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ajouter_intervention_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }
    }
}
