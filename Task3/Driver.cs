using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Driver : EventArgs
    {
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
        public const int MaxSpeed = 60;

        public Driver(int speed)
        {
            CurrentSpeed = speed;
        }

    }
}
