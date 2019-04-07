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
            Driver driver = new Driver(72);


            driver.WritingTicket += inspector.OnMakeTicket;

            driver.MakeTicket(driver);

        }
    }
}
