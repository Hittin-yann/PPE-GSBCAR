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
    public partial class connexion : Form
    {
        public connexion()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connexion = new MySqlConnection("database=gsb; server=localhost; user id=root ;pwd=");

            try
            {
                connexion.Open();

                MySqlCommand command = connexion.CreateCommand();
                command.CommandText = "SELECT login, mot_de_passe FROM user";

                MySqlDataReader dataReader = command.ExecuteReader();

                bool vrais = true;

                while (dataReader.Read())
                {
                    string login = Convert.ToString(dataReader["login"]);
                    string mdp = Convert.ToString(dataReader["mot_de_passe"]);
                    if (login == tb_login.Text && mdp == tb_mdp.Text)
                    {
                        vrais = true;
                        Form1 f = new Form1();
                        f.Show();
                        this.Visible = false;
                        break;
                    }
                    else
                    {
                        vrais = false;
                    }
                }
                if (vrais == false)
                {
                    MessageBox.Show("Erreur d'identification !");
                }
                connexion.Close();
            }
            catch
            {
                MessageBox.Show("Erreur de connexion a la bdd !");
            }
        }
    }
}
