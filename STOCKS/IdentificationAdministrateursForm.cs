using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;

namespace STOCKS
{
    public partial class IdentificationAdministrateursForm : Form
    {
        public IdentificationAdministrateursForm()
        {
            InitializeComponent();
        }

        private void IdentificationAdministrateursForm_Load(object sender, EventArgs e)
        {
            textBox_IDA.Text = "Identifiant";
            textBox_mdpA.Text = "Mot de passe";

        }

        private void validerA_Click(object sender, EventArgs e)
        {

            string connectionString = "server=localhost;database=stocks;Uid=root;password=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); // La connexion à la base de données a réussi.

                    string username = textBox_IDA.Text; // Récupérer la valeur du champ de texte pour l'identifiant
                    string password = textBox_mdpA.Text; // Récupérer la valeur du champ de texte pour le mot de passe

                    // Construire la requête SQL pour vérifier les informations d'identification de l'utilisateur
                    string query = "SELECT COUNT(*) FROM administrateurs WHERE IdentidiantA = @username AND MdpA = @password";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Ajouter les paramètres pour les valeurs récupérées des champs de texte
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count > 0)
                        {
                            // Les informations d'identification sont valides.
                            // On peut permettre à l'administarteur d'accéder à la gestion

                            GestionStocksForm gestionStocksForm = new GestionStocksForm();
                            gestionStocksForm.Show();

                        }
                        else
                        {
                            // Les informations d'identification sont invalides.
                            // Afficher un message d'erreur à l'administrateur
                            MessageBox.Show("Votre identifiant ou mot de passe est incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    // Une erreur s'est produite lors de la connexion à la base de données.
                    // Gérez l'exception appropriée ici.
                    Console.WriteLine("Erreur de connexion à la base de données: " + ex.Message);
                }
            }


        }

    //    class Connection
    //    {
    //        public static MySqlConnection connection = new MySqlConnection();

    //        static string server = ";";
    //        static string database = "stocks;";
    //        static string Uid = "root;";
    //        static string password = ";";

    //        public static MySqlConnection DataSource()
    //        {
    //            connection = new MySqlConnection($"server={server} database={database} Uid={Uid} password={password}");
    //            return connection;
    //        }

    //        public void ConnOpen()
    //        {
    //            DataSource();
    //            connection.Open();
    //        }

    //        public void ConnClose()
    //        {
    //            DataSource();
    //            connection.Close();
    //        }
    //    }
    }
}



