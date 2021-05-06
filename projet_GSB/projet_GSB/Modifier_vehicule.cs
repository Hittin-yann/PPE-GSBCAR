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
    public partial class Modifier_vehicule : Form
    {
        public static int index;
        public Modifier_vehicule()
        {
            InitializeComponent();
        }

        private void bt_affichage_modifVehicule_Click(object sender, EventArgs e)
        {
            bool message = true;
            MySqlConnection connexion = new MySqlConnection("database=gsb; server=localhost; user id=root ;pwd=");

            try
            {
                connexion.Open();

                MySqlCommand command = connexion.CreateCommand();

                command.CommandText = "SELECT * FROM vehicule";

                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    string statue = Convert.ToString(dataReader["statue"]);
                    string dateAchat = Convert.ToString(dataReader["DateAchat"]);
                    string payement = Convert.ToString(dataReader["payement"]);
                    string prix = Convert.ToString(dataReader["prix"]);
                    string kilometrage = Convert.ToString(dataReader["kilometrage"]);
                    string immatriculation = Convert.ToString(dataReader["immatriculation"]);
                    string modele = Convert.ToString(dataReader["model"]);
                    string type = Convert.ToString(dataReader["type"]);
                    string stockage = Convert.ToString(dataReader["stockage"]);
                    string etat = Convert.ToString(dataReader["etat"]);
                    string kiloAutonomie = Convert.ToString(dataReader["autonomie_en_km"]);
                    if (tbModifImma.Text == immatriculation)
                    {
                        message = true;
                        tb_modifStatue.Text = statue;
                        tb_modifDate.Text = dateAchat;
                        tb_modifPayement.Text = payement;
                        tb_modifPrix.Text = prix;
                        tb_modifKilometrage.Text = kilometrage;
                        tb_modifImma.Text = immatriculation;
                        tb_modifModele.Text = modele;
                        tb_modifType.Text = type;
                        tb_modifStockage.Text = stockage;
                        tb_modifEtat.Text = etat;
                        tb_modifKiloAutonomie.Text = kiloAutonomie;
                        panel1.Visible = true;
                        break;
                    }
                    else
                    {
                        message = false;
                    }
                }
                connexion.Close();
            }
            catch //(Exception ex)
            {
                MessageBox.Show("Erreur de connexion a la bdd !");
            }
            if (message == false)
            {
                MessageBox.Show("Aucun Immatricule trouvé !");
            }
        }

        private void bt_modifVehicule_Click(object sender, EventArgs e)
        {
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
                    if (tbModifImma.Text == immatriculation)
                    {
                        MySqlConnection connexion2 = new MySqlConnection("database=gsb; server=localhost; user id=root ;pwd=");
                        connexion2.Open();
                        string myInsertQuery = "UPDATE vehicule SET immatriculation = \"" + tb_modifImma.Text + "\",model = \"" + tb_modifModele.Text + "\",type = \"" + tb_modifType.Text + "\",etat = \"" + tb_modifEtat.Text + "\",stockage = " + tb_modifStockage.Text + ",kilometrage = " + tb_modifKilometrage.Text + ",statue = \"" + tb_modifStatue.Text + "\",autonomie_en_km = " + tb_modifKiloAutonomie.Text + ",prix = " + tb_modifPrix.Text + ",payement = \"" + tb_modifPayement.Text + "\",dateAchat = \"" + tb_modifDate.Text + "\" WHERE immatriculation = \"" + immatriculation + "\"";
                        MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                        myCommand.Connection = connexion2;
                        // Exécution de la requête
                        myCommand.ExecuteNonQuery();
                        connexion2.Close();
                    }
                }
            }
            catch //(Exception ex)
            {
                MessageBox.Show("Erreur de connexion a la bdd !");
            }
            connexion.Close();
            this.Close();
        }

        private void Modifier_vehicule_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void bt_modifRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
