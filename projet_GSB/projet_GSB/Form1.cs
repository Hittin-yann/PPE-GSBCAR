using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Librairie MySql , ajoutee precedement dans les ref
using MySql.Data.MySqlClient;

namespace projet_GSB
{
   
    public partial class Form1 : Form
    {
        static public List<Vehicule> lesVehicules;
        public Form1()
        {
            InitializeComponent();
            Form1.lesVehicules = new List<Vehicule>();
            actualiserListe();
        }

        private void Ajouter_vehicule_Click(object sender, EventArgs e)
        {
            Ajouter_vehicule A = new Ajouter_vehicule();
            if (A.ShowDialog() == DialogResult.Yes)
            {
                //// actualiser votre listeitems
                actualiserListe();
            }
        }

        private void actualiserListe()
        {
            listBox1.Items.Clear();
            MySqlConnection connexion = new MySqlConnection("database=gsb; server=localhost; user id=root ;pwd=");

            try
            {
                connexion.Open();

                MySqlCommand command = connexion.CreateCommand();
                command.CommandText = "SELECT immatriculation, model FROM vehicule";

                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    string immatriculation = Convert.ToString(dataReader["immatriculation"]);
                    string modele = Convert.ToString(dataReader["model"]);
                    listBox1.Items.Add(immatriculation + " : " + modele);
                }
                connexion.Close();
                listBox2.Items.Clear();
            }
            catch
            {
                MessageBox.Show("Erreur de connexion a la bdd !");
            }
            lb_infoPlaqueImma.Text = "AA-OOO-AA";
            lb_infoModele.Text = "Unknow";
            lb_infoEtat.Text = "Unknow";
            lb_infoStockage.Text = "Null";
            lb_infoKilometrage.Text = "Null";
            lb_infoStatue.Text = "Unknow";
        }

        private void Retirer_vehicule_Click(object sender, EventArgs e)
        {
            Retirer_vehicule R = new Retirer_vehicule();
            if (R.ShowDialog() == DialogResult.Yes)
            {
                //// actualiser votre listeitems
                actualiserListe();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Lb_modele_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
 
          
            
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection connexion = new MySqlConnection("database=gsb; server=localhost; user id=root ;pwd=");

            try
            {
                connexion.Open();

                MySqlCommand command = connexion.CreateCommand();
                command.CommandText = "SELECT immatriculation, model, etat, stockage, kilometrage, statue FROM vehicule";

                MySqlDataReader dataReader = command.ExecuteReader();

                string[] texte = listBox1.SelectedItem.ToString().Split(' ');

                while (dataReader.Read())
                {
                    string immatriculation = Convert.ToString(dataReader["immatriculation"]);
                    if (texte[0] == immatriculation)
                    {
                        string modele = Convert.ToString(dataReader["model"]);
                        string etat = Convert.ToString(dataReader["etat"]);
                        string stockage = Convert.ToString(dataReader["stockage"]);
                        string kilometrage = Convert.ToString(dataReader["kilometrage"]);
                        string statue = Convert.ToString(dataReader["statue"]);
                        lb_infoPlaqueImma.Text = immatriculation;
                        lb_infoModele.Text = modele;
                        lb_infoEtat.Text = etat;
                        lb_infoStockage.Text = stockage;
                        lb_infoKilometrage.Text = kilometrage;
                        lb_infoStatue.Text = statue;

                        MySqlConnection connexion2 = new MySqlConnection("database=gsb; server=localhost; user id=root ;pwd=");
                        connexion2.Open();
                        MySqlCommand mycommand = connexion2.CreateCommand();
                        mycommand.CommandText = "SELECT * FROM entretien_vehicule";
                        MySqlDataReader dataReader2 = mycommand.ExecuteReader();
                        listBox2.Items.Clear();
                        while (dataReader2.Read())
                        {
                            string typeFrais = Convert.ToString(dataReader2["type_frais"]);
                            string coutFrais = Convert.ToString(dataReader2["cout_frais"]);
                            string dateEntrer = Convert.ToString(dataReader2["date_EntreEntretien"]);
                            string immatriculation2 = Convert.ToString(dataReader2["immatriculation"]);
                            string dateSortie = Convert.ToString(dataReader2["date_SortieEntretien"]);
                            if (immatriculation == immatriculation2) 
                            {
                                listBox2.Items.Add(immatriculation2 + " : " + dateEntrer + " au " + dateSortie + " - " + typeFrais + " : " + coutFrais);
                            }
                        }
                        break;
                    }
                }
                connexion.Close();
            }
            catch
            {
                MessageBox.Show("Erreur de connexion a la bdd !");
            }
        }

        private void bt_modifier_vehicule_Click(object sender, EventArgs e)
        {
            Modifier_vehicule M = new Modifier_vehicule();
            if (M.ShowDialog() == DialogResult.Yes)
            {
                //// actualiser votre listeitems
                actualiserListe();
            }
        }

        private void ajouter_intervention_Click(object sender, EventArgs e)
        {
            Ajouter_intervention I = new Ajouter_intervention();
            if (I.ShowDialog() == DialogResult.Yes)
            {
                //// actualiser votre listeitems
                actualiserListe();
            }
        }

        private void modifier_intervention_Click(object sender, EventArgs e)
        {
            Modifier_intervention IM = new Modifier_intervention();
            if (IM.ShowDialog() == DialogResult.Yes)
            {
                //// actualiser votre listeitems
                actualiserListe();
            }
        }
    }
}
