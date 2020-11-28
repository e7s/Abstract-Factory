using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Models
{
    class Client
    {
        private AbstractWater water;
        private AbstractBottle bottle;

        public Client(AbstractFactory factory)
        {
            //Абстрагирование процессов инстанцирования
            water = factory.CreateWater();
            bottle = factory.CreateBottle();
        }

        public void Run()
        {
            //Абстагирование вариантов использования
            bottle.Interact(water);
        }
    }
}
