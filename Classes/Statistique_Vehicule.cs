using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Synthèse_Final
{
    public static class Statistique_Vehicule
    {
        private static Dictionary<int, Clients> listClients = new Dictionary<int, Clients>();

        public static Dictionary<int, Clients> ListClients
        {
            get { return listClients; }
            set { listClients = value; }
        }
        static Statistique_Vehicule()
        {
            listClients = null;
            listClients = new Dictionary<int, Clients>();
        }
        public static void AjouterClients(Clients cli)
        {
            //Vérifie si le numéro existe
            if (!listClients.ContainsKey(cli.Permis))
                ListClients.Add(cli.Permis, cli);
            else MessageBox.Show("Etudiant existe déjà.", "Message"); // Sinon afficher message 
        }
    }
}
