using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Synthèse_Final
{
    public class Voiture : Clients
    {
        private string modele;
        private int prix;

        public string Modele
        {
            get { return modele; }
            set { modele = value; }
        }

        public int Prix
        {
            get { return prix; }
            set { prix = value; }
        }
        public Voiture()
        {
            modele = "";
            prix = 0;
        }
        public Voiture(string p_modele, int p_prix)
            
        {
            modele = p_modele;
            prix = p_prix;          
        }

        public override string[] ToArray()
        {
            //récuperer le tableau des proprietés de la classe parent Programme
            string[] proprietes1 = base.ToArray();
            // créer un tableau pour acceuillir toutes les proprietés
            string[] proprietes = new string[proprietes1.Length + 2];
            // copier les proprietés héritées  
            proprietes1.CopyTo(proprietes, 0);
            // compléter le tableau proprietes avec les propriétés de la classe fille
            proprietes[proprietes1.Length] = modele;
            proprietes[proprietes1.Length + 1] = prix.ToString();
            return proprietes;
        }
    }
}
