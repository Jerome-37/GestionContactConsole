using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllContactLibrary
{
    class ContactPrives : Contact 
    {
        private string dateNaissance;

        public string DateNaissance
        {
            get { return dateNaissance; }
            set { dateNaissance = value; }
        }

        private byte age;

        public byte Age
        {
            get { return age; }
            set { age = value; } 
        }

        public ContactPrives(string n, string p, int tel, TypeContact t, string d, byte a) : base(n, p, tel, t)
        {
            this.DateNaissance = d;
            this.Age = a;
        }

    }
}
