using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjetBraux
{
    public class ConnectionBdd
    {
        FichierConfigBdd fichier = new FichierConfigBdd();

        string chaineConnectionBdd;

        public MySqlConnection connection;

        // Constructeur
        public ConnectionBdd()
        {
            this.InitConnexion();
        }

        // Méthode pour initialiser la connexion
        public void InitConnexion()
        {
            // Création de la chaîne de connexion
            string connectionString = "SERVER=127.0.0.1; DATABASE=csharp; UID=root; PASSWORD=";
            this.connection = new MySqlConnection(connectionString);
        }
        
        public List<User> VoirEmploye()
        {

            try
            {

                List<User> users = new List<User>();
                

                

                connection.Open();
                MessageBox.Show("Connecté");

                string sqlselect = "SELECT * FROM `Employe`;";
                MySqlCommand cmd = new MySqlCommand(sqlselect, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    users.Add(new User() { Id =Convert.ToInt16(rdr[0]), Nom =Convert.ToString(rdr[1]), Mdp =Convert.ToString(rdr[2]) });
                }

                

                rdr.Close();

                return users;
            }
            catch
            {
                return null;                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le contact à été ajouté correctement.
            }
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Mdp { get; set; }
    }
}
