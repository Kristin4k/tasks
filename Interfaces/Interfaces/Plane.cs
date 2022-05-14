using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Plane : IDivable
    {
        public string Name;
        public double Capacity;
        public double Velocity;
        public double Heigh;

        double velocity;
         double IDivable.Velocity
        {
            get { return velocity; }

            set
            {
                if (value < 0)
                    throw new ArgumentException();
                else
                    velocity = value;
            }
        }

        public void Drive(double delta)
        {
            if (-delta < Velocity)
                Velocity = 0;
            else
                Velocity += delta;
        }

        public void Start()
        {
            Console.WriteLine("Самолёт: проверка приборов");
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
