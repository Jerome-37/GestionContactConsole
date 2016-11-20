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
                "********************************************************" + Environment.NewLine +
                "*          Application de gestion de Contacts          *" + Environment.NewLine +
                "*                    --------------                    *" + Environment.NewLine +
                "*           selectionner une tache de 1 à 4            *" + Environment.NewLine +
                "********************************************************" + Environment.NewLine +
                "* - 1 : Lister l'ensemble des Contacts                 *" + Environment.NewLine +
                "* - 2 : Ajouter / Supprimer / Modifier un contact      *" + Environment.NewLine +
                "* - 3 : Rechercher un Contact                          *" + Environment.NewLine + 
                "* - 4 : Trier les Conctacts                            *" + Environment.NewLine +
                "********************************************************"); 

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

                default:
                    Console.WriteLine("cas defaut");
                    break;
            }




            Console.ReadLine();

        }
    }
}
