using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2027678
// Benoit Tremblay


namespace Projet_Synthèse_Final
{
    // Classe qui hérite de Clients
    public class Vehicule : Clients
    {
        // Attributs privés
        private string modele;
        private int prix;

        //Accesseurs (propriétés)
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

        // Constructeur par défault avec parmètres
        public Vehicule()
        {
            modele = "";
            prix = 0;
        }
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="p_permis"></param>
        /// <param name="p_nom"></param>
        /// <param name="p_prenom"></param>
        /// <param name="p_telephone"></param>
        /// <param name="p_date"></param>
        /// <param name="p_jour"></param>
        /// <param name="p_modele"></param>
        /// <param name="p_prix"></param>
        public Vehicule(string p_permis, string p_nom, string p_prenom, string p_telephone, DateTime p_date, int p_jour, string p_modele, int p_prix) 
            : base(p_permis,p_nom, p_prenom, p_telephone,p_date, p_jour)
        {
            modele = p_modele;
            prix = p_prix;
        }

        // Méthode surchargée
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
