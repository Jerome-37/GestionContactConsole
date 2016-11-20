using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllContactLibrary
{
    public enum TypeContact : short { Prives, Professionnels };

    public class Contact : Personne
    {
        
        private TypeContact typeContact;

        public TypeContact TypeContact 
        {
            get { return typeContact; }
            set { typeContact = value; }
        }


        public Contact(string n, string p, int tel,TypeContact t) : base(n, p, tel)
        {
          this.TypeContact = t;

        }
        
    }
}