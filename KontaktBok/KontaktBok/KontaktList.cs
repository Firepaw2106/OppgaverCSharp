using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontaktBok
{
    internal class KontaktList
    {
        public List<KontaktInfo> Kontakter {  get; set; }

        public KontaktList(List<KontaktInfo> kontakter)
        {
            this.Kontakter = kontakter;
        }

        public void PrintContact()
        {
            Console.Clear();
            Console.WriteLine("Mine Kontakter");
            for (int i = 1; i < Kontakter.Count + 1; i++)
            {
                Console.CursorLeft = 30;
                Console.WriteLine($"Navn     : {Kontakter[i - 1].FirstName}");
                //Console.CursorLeft = 30;
                //Console.WriteLine($"Etternavn: {Kontakter[i - 1].LastName}");
                //Console.CursorLeft = 30;
                //Console.WriteLine($"Tlf      : {Kontakter[i - 1].TlfNumber}");
            }
            Console.SetCursorPosition( 0, Console.WindowHeight -5);
        }
    
    }
}
