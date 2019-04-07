using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Driver : EventArgs
    {
        public delegate void InspectorEventHandler(object sender, Driver args);
        public event InspectorEventHandler WritingTicket;
        public const int MaxSpeed = 60;
        private int _currentSpeed;

        public int CurrentSpeed
        {
            get
            {
                return _currentSpeed;
            }
            set
            {
                if (value >= 0 && value <= 250)
                    _currentSpeed = value;
            }
        }

        public Driver(int speed)
        {
            CurrentSpeed = speed;
        }


        public void MakeTicket(Driver driver)
        {
            Console.WriteLine("Current speed is " + driver.CurrentSpeed);

            OnTicketWriting(driver);
        }

        protected virtual void OnTicketWriting(Driver driver)
        {
            InspectorEventHandler ticketEvent = WritingTicket;

            ticketEvent?.Invoke(this, driver);
        }

    }
}
