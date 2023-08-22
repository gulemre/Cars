using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    
    public abstract class Car:CarFactory

    {
        public string ModalName { get; set; }
        public string Region { get; set; }

        List<Car>cars = new List<Car>();

    }
}
