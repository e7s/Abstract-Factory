using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Models
{
    abstract class AbstractFactory
    {
        public abstract AbstractWater CreateWater();
        public abstract AbstractBottle CreateBottle();
    }

    class CocaColaFactory : AbstractFactory
    {
        public override AbstractWater CreateWater()
        {
            return new CocaColaWater();
        }

        public override AbstractBottle CreateBottle()
        {
            return new CocaColaBottle();
        }
    }

    class PepsiFactory : AbstractFactory
    {
        public override AbstractWater CreateWater()
        {
            return new PepsiWater();
        }

        public override AbstractBottle CreateBottle()
        {
            return new PepsiBottle();
        }
    }

    //using interface
    interface IAbstractFactory
    {
        dynamic Make(Product product);
    }

    class ConcreteFactory1 : IAbstractFactory
    {
        dynamic product;

        public dynamic Make(Product product)
        {
            //Получение полного квалифиционного имени продукта 1
            string name = GetType().Namespace + "." + product + "1";

            //Динамическое создание продукта семейства - 1
            this.product = Activator.CreateInstance(Type.GetType(name));

            return this.product;
        }
    }

    class ConcreteFactory2 : IAbstractFactory
    {
        dynamic product;

        public dynamic Make(Product product)
        {
            //Получение полного квалифиционного имени продукта 2
            string name = GetType().Namespace + "." + product + "2";

            //Динамическое создание продукта семейства - 2
            this.product = Activator.CreateInstance(Type.GetType(name));

            return this.product;
        }
    }
}
