using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllContactLibrary
{
    class ContactProfessionnels : Contact
    {
        private string mail;

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        private string nomEntreprise;

        public string NomEntreprise
        {
            get { return nomEntreprise; }
            set { nomEntreprise = value; } 
        }



        public ContactProfessionnels(string n, string p, int tel, TypeContact t, string m, string nme) : base(n, p, tel, t)
        {
            this.Mail = m;
            this.NomEntreprise = nme;

        }

     }
}
