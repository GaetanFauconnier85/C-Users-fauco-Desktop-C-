using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBraux
{
    public class FichierConfigBdd
    {
        string ligne;
        List<string> contenuLigne = new List<string>();
        public string retourneInfo(string NameSpace, int numeroLigne)
        {
            System.IO.StreamReader stream = new System.IO.StreamReader(NameSpace + ".txt");
            for (int i = 0; (ligne = stream.ReadLine()) != null; i++)
            {
                contenuLigne.Add(ligne);
            }
            stream.Close();
            return contenuLigne[numeroLigne];
        }
    }
}
