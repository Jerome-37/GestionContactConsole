using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllContactLibrary
{
    public abstract class Personne
    {
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; } 
        }

        private int telephone;

        public int Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }


        public Personne(string n, string p, int tel)
        {
            this.Nom = n;
            this.Prenom = p;
            this.Telephone = tel;
        }








    }
}
