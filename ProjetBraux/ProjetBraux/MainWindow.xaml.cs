using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjetBraux
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<User> users = new List<User>();
            users.Add(new User() {Avion = "John Doe", Capacite = "12", Type = "long" });
            users.Add(new User() {Avion = "John Doe2", Capacite = "12", Type = "long" });
            users.Add(new User() {Avion = "John Doe3", Capacite = "12", Type = "long" });

            dataGridVol.ItemsSource = users;

            FichierConfigBdd fcp = new FichierConfigBdd();

                string nom = fcp.retourneInfo("Test", 0);

            MessageBox.Show(nom);

            ConnectionBdd c = new ConnectionBdd();

            emploi.ItemsSource = c.VoirEmploye();

        }

        public class User
        {
            public string Avion { get; set; }
            public string Capacite { get; set; }
            public string Type { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ConnectionBdd emp = new ConnectionBdd();
            emp.VoirEmploye();

            /*Login log = new Login();
            log.Show();
            Close();*/
        }
    }
}
