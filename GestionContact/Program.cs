using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionContact
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "****************************************" + Environment.NewLine + 
                "* - 1 : Premier menu                   *" + Environment.NewLine +
                "* - 2 : deuxieme menu                  *" + Environment.NewLine +
                "* - 3 : troisieme menu                 *" + Environment.NewLine + 
                "* - 4 : quatrieme menu                 *" + Environment.NewLine +
                "* - 5 : cinquieme menu                 *" + Environment.NewLine +
                "****************************************"); 

            string saisie = Console.ReadLine();
            switch (saisie) 
            {
                case "1":
                    Console.WriteLine("cas 1");
                    break;

                case "2":
                    Console.WriteLine("cas 2");
                    break;

                case "3":
                    Console.WriteLine("cas 3");
                    break;
                case "4":
                    Console.WriteLine("cas 4");
                    break;
                case "5":
                    Console.WriteLine("cas 5");
                    break;
                default:
                    Console.WriteLine("cas defaut");
                    break;
            }




            Console.ReadLine();

        }
    }
}
