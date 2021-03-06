﻿using Abstract_Factory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = null;

            client = new Client(new CocaColaFactory());
            client.Run();

            client = new Client(new PepsiFactory());
            client.Run();

            ClientDynamic clientDynamic;
            clientDynamic = new ClientDynamic(Factory.ConcreteFactory1);
            clientDynamic.Run();

            clientDynamic = new ClientDynamic(Factory.ConcreteFactory2);
            clientDynamic.Run();

            Console.ReadLine();
        }
    }
}
