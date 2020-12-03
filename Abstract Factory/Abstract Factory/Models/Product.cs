using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Models
{
    enum Product
    {
        ProductA,
        ProductB
    }

    enum Factory
    {
        ConcreteFactory1,
        ConcreteFactory2
    }

    interface IAbstractProductA
    {

    }

    class ProductA1 : IAbstractProductA
    {

    }

    class ProductA2 : IAbstractProductA
    {

    }

    interface IAbstractProductB
    {
        void Interact(IAbstractProductA a);
    }

    class ProductB1 : IAbstractProductB
    {
        public void Interact(IAbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " взаимодействует с " + a.GetType().Name);
        }
    }

    class ProductB2 : IAbstractProductB
    {
        public void Interact(IAbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " взаимодействует с " + a.GetType().Name);
        }
    }
}
