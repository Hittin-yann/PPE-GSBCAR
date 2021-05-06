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
    public partial class Modifier_intervention : Form
    {
        public Modifier_intervention()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_valider_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            MySqlConnection connexion = new MySqlConnection("database=gsb; server=localhost; user id=root ;pwd=");

            try
            {
                connexion.Open();
                MySqlCommand command = connexion.CreateCommand();
                command.CommandText = "SELECT * FROM entretien_vehicule";
                MySqlDataReader dataReader = command.ExecuteReader();
                listBox1.Items.Clear();
                while (dataReader.Read())
                {
                    string typeFrais = Convert.ToString(dataReader["type_frais"]);
                    string coutFrais = Convert.ToString(dataReader["cout_frais"]);
                    string dateEntrer = Convert.ToString(dataReader["date_EntreEntretien"]);
                    string immatriculation = Convert.ToString(dataReader["immatriculation"]);
                    string dateSortie = Convert.ToString(dataReader["date_SortieEntretien"]);
                    string id = Convert.ToString(dataReader["id"]);
                    if (tb_validation.Text == immatriculation)
                    {
                        listBox1.Items.Add(id + " " + immatriculation + " : " + dateEntrer + " au " + dateSortie + " - " + typeFrais + " : " + coutFrais);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erreur de connexion a la bdd !");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection connexion = new MySqlConnection("database=gsb; server=localhost; user id=root ;pwd=");

            try
            {
                connexion.Open();

                MySqlCommand command = connexion.CreateCommand();
                command.CommandText = "SELECT * FROM entretien_vehicule";

                MySqlDataReader dataReader = command.ExecuteReader();

                string[] texte = listBox1.SelectedItem.ToString().Split(' ');

                while (dataReader.Read())
                {
                    string typeFrais = Convert.ToString(dataReader["type_frais"]);
                    string coutFrais = Convert.ToString(dataReader["cout_frais"]);
                    string dateEntrer = Convert.ToString(dataReader["date_EntreEntretien"]);
                    string immatriculation = Convert.ToString(dataReader["immatriculation"]);
                    string dateSortie = Convert.ToString(dataReader["date_SortieEntretien"]);
                    string id = Convert.ToString(dataReader["id"]);
                    if (texte[0] == id && texte[1] == immatriculation)
                    {
                        tb_immatriculation.Text = immatriculation;
                        tb_dateEntrer.Text = dateEntrer;
                        tb_dateSortie.Text = dateSortie;
                        tb_typeFrais.Text = typeFrais;
                        tb_coutFrais.Text = coutFrais;
                        tb_id.Text = id;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erreur de connexion a la bdd !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connexion = new MySqlConnection("database=gsb; server=localhost; user id=root ;pwd=");

            try
            {
                connexion.Open();

                MySqlCommand command = connexion.CreateCommand();

                command.CommandText = "SELECT * FROM entretien_vehicule";

                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    string typeFrais = Convert.ToString(dataReader["type_frais"]);
                    string coutFrais = Convert.ToString(dataReader["cout_frais"]);
                    string dateEntrer = Convert.ToString(dataReader["date_EntreEntretien"]);
                    string immatriculation = Convert.ToString(dataReader["immatriculation"]);
                    string dateSortie = Convert.ToString(dataReader["date_SortieEntretien"]);
                    string id = Convert.ToString(dataReader["id"]);
                    if (tb_id.Text == id)
                    {
                        MySqlConnection connexion2 = new MySqlConnection("database=gsb; server=localhost; user id=root ;pwd=");
                        connexion2.Open();
                        string myInsertQuery = "UPDATE entretien_vehicule SET type_frais = \"" + tb_typeFrais.Text + "\",cout_frais = " + tb_coutFrais.Text + ",date_EntreEntretien = \"" + tb_dateEntrer.Text + "\",immatriculation = \"" + tb_immatriculation.Text + "\",date_SortieEntretien = \"" + tb_dateSortie.Text + "\" WHERE id = " + id;
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

        private void Modifier_intervention_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }
    }
}
