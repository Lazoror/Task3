using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Inspector inspector = new Inspector();
            CheckSpeed check = new CheckSpeed();
            Driver driver = new Driver(81);
            Driver driver2 = new Driver(65);
            Driver driver3 = new Driver(74);
            Driver driver4 = new Driver(60);
            

            inspector.WritingTicket += check.OnMakeTicket;

            inspector.MakeTicket(driver);
            inspector.MakeTicket(driver2);
            inspector.MakeTicket(driver3);
            inspector.MakeTicket(driver4);

        }
    }
}
