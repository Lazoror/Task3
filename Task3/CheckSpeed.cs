using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class CheckSpeed
    {
        public void OnMakeTicket(object sender, Driver driver)
        {
            int speedDifference = driver.CurrentSpeed - Driver.MaxSpeed;

            if (speedDifference > 20)
                Console.WriteLine("Штраф 500 грн.");
            else if (speedDifference > 10)
                Console.WriteLine("Штраф 200 грн.");
            else if (speedDifference > 0)
                Console.WriteLine("Штраф 100 грн.");

        }

    }
}
