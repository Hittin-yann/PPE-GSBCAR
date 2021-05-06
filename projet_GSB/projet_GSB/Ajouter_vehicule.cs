using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_GSB
{
    public partial class Ajouter_vehicule : Form
    {
        
        public Ajouter_vehicule()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // bouton Annuler
            this.Close();
        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Tb_type_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //bouton ajouter
            MySqlConnection connexion = new MySqlConnection("database=gsb; server=localhost; user id=root ;pwd=");

            try
            {
                connexion.Open();

                MySqlCommand command = connexion.CreateCommand();

                command.CommandText = "SELECT immatriculation FROM vehicule";

                MySqlDataReader dataReader = command.ExecuteReader();

                bool vrais = true;

                while (dataReader.Read())
                {
                    string immatriculation = Convert.ToString(dataReader["immatriculation"]);
                    if (tb_immatriculation.Text != immatriculation && tb_immatriculation.Text != "")
                    {
                        vrais = true;
                    }
                    else
                    {
                        MessageBox.Show("Immatricule deja existant ou NULL !");
                        vrais = false;
                        break;
                    }
                }
                if (vrais == true && tb_immatriculation.Text != "")
                {
                    MySqlConnection connexion2 = new MySqlConnection("database=gsb; server=localhost; user id=root ;pwd=");
                    connexion2.Open();
                    string myInsertQuery = "INSERT INTO vehicule (immatriculation, model, type, etat, stockage, kilometrage, statue, autonomie_en_km, prix, payement, dateAchat) VALUES (\"" + tb_immatriculation.Text + "\", \"" + tb_modele.Text + "\", \"" + tb_type.Text + "\", \"" + tb_etatVehicule.Text + "\", " + tb_stockageVehicule.Text + ", " + tb_kilometrage.Text + ", \"" + tb_statueVehicule.Text + "\", " + tb_kilometrageAutonomie.Text + ", " + tb_prix.Text + ", \"" + tb_payement.Text + "\", \"" + tb_dateAchat.Text + "\")";
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                    myCommand.Connection = connexion2;
                    // Exécution de la requête
                    myCommand.ExecuteNonQuery();
                    connexion2.Close();

                    this.Close();
                }
                connexion.Close();

            }
            catch //(Exception ex)
            {
                MessageBox.Show("Erreur de connexion a la bdd !");
            }
        }

        private void Ajouter_vehicule_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }
    }
}
