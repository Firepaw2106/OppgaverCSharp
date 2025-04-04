using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontaktBok
{
    public class KontaktInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TlfNumber { get; set; }

        public KontaktInfo(string firstname)
        {
            FirstName = firstname;
           
        }
        public KontaktInfo(string firstname, string lastname, int tlfnumber)
        {
            FirstName = firstname;
            LastName = lastname;
            TlfNumber = tlfnumber;
        }
    }
}
