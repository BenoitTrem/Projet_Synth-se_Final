using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2027678
// Benoit Tremblay

namespace Projet_Synthèse_Final
{
    // Attributs privés
    public class Clients
    {
        private string permis;
        private string nom;
        private string prenom;
        private string telephone;
        private DateTime date;
        private int jour;

        // Accesseurs (propriétés)
        public string Permis
        {
            get { return permis; }
            set { permis = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }       
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public int Jour
        {
            get { return jour; }
            set { jour = value; }
        }

        // Constructeurs par défaut avec paramètre
        public Clients()
        {
            permis = "";
            nom = "";
            prenom = "";
            telephone = "";
            date = default(DateTime);
            jour = 0;
        }

        /// <summary>
        /// Constructeurs
        /// </summary>
        /// <param name="p_permis"></param>
        /// <param name="p_nom"></param>
        /// <param name="p_prenom"></param>
        /// <param name="p_telephone"></param>
        /// <param name="p_date"></param>
        /// <param name="p_jour"></param>
        public Clients(string p_permis, string p_nom, string p_prenom, string p_telephone,
            DateTime p_date, int p_jour)
        {

            this.nom = p_nom;
            this.prenom = p_prenom;
            this.telephone = p_telephone;
            this.permis = p_permis;
            this.date = p_date;
            this.jour = p_jour;
        }

        // méthode qui un tableau contenant les différentes valeurs des attributs
        public virtual string[] ToArray()
        {
            string[] proprietes = new string[5];
            proprietes[0] = permis;
            proprietes[1] = nom;
            proprietes[2] = prenom;
            proprietes[3] = date.ToString();
            proprietes[4] = jour.ToString();
            return proprietes;
        }

    }
}
    

