using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Synthèse_Final
{
    public class Camion : Clients
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

        public Camion()
        {
            modele = "";
            prix = 0;
        }
        public Camion(int p_permis, string p_nom, string p_prenom, string p_telephone, DateTime p_date, int p_jour, string p_modele, int p_prix) 
            : base(p_permis,p_nom, p_prenom, p_telephone,p_date, p_jour)
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
