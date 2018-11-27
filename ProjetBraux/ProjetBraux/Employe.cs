using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjetBraux
{
    public class Employe
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Mdp { get; set; }

        // Constructeur
        public Employe()
        {
        }
    }
}
