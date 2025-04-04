using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontaktBok
{
    internal class Program
    {
        public KontaktList kontakter;
        public KontaktInfo kontakterInfo;
        public Program()
        {
            kontakter = new KontaktList(new List<KontaktInfo>());

        }
        private static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        public void Run()
        {
            Console.WriteLine("Kontakt Bok\n");
            Console.WriteLine("\n1. Legg til ny kontakt \n2. Se alle kontakter \n.3 Søk for kontakt \n\n0. Avslutt ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    AddNewContact();
                    break;
                case "2":
                    Console.Clear();
                    //kontakter.PrintContact();
                    break;
                case "3":
                    Console.Clear();
                    //SearchContact();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again...");
                    break;

            }

        }
        public void AddNewContact()
        {
            Console.WriteLine("Legg til ny kontakt info\n");
            Console.WriteLine("Skriv inn navn til ny kontakt\n");
    
        List<KontaktList> kontakter = new List<KontaktList>();

            string firstname = Console.ReadLine();

            KontaktInfo nyKonakt = new KontaktInfo(firstname);

            Run();
        }
    }
}