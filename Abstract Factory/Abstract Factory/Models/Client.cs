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

    class ClientDynamic
    {
        dynamic factory;
        dynamic ProductA;
        dynamic ProductB;

        public ClientDynamic(Factory factory)
        {
            //Получение полного квалификационного имени фабрики в строковом представлении
            string name = GetType().Namespace + "." + factory;

            //Динамическое созодание соответствующей фабрики
            this.factory = Activator.CreateInstance(Type.GetType(name));

            //Порождение продуктов
            ProductA = this.factory.Make(Product.ProductA);
            ProductB = this.factory.Make(Product.ProductB);
        }

        public void Run()
        {
            ProductB.Interact(ProductA);
        }
    }
}
