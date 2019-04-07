using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Inspector
    {
        public delegate void InspectorEventHandler(object sender, Driver args);
        public event InspectorEventHandler WritingTicket;


        public void MakeTicket(Driver driver)
        {
            Console.WriteLine("Your current speed is " + driver.CurrentSpeed);

            if(driver.CurrentSpeed > 60)
                OnTicketWriting(driver);
            else
                Console.WriteLine("Нет штрафа. Едь дальше :)");
            

        }

        protected virtual void OnTicketWriting(Driver driver)
        {
            InspectorEventHandler ticketEvent = WritingTicket;

            ticketEvent?.Invoke(this, driver);
        }

    }
}
