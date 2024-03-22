using System;
using System.Collections.Generic;

namespace OOP
{
    class Program {
        static void Main(string[] args) {
            // CarSalesman steveTheSalesman = new CarSalesman("Steve", "Rogers");
            // Console.WriteLine(steveTheSalesman.FullName);
            // steveTheSalesman.Sell();

            // RetailSalesPerson erikTheSalesman = new RetailSalesPerson("Erik", "Erikson");
            // Console.WriteLine(erikTheSalesman.FullName);
            // erikTheSalesman.Sell();
            // erikTheSalesman.SellVirtual();
            // erikTheSalesman.Develop();

            // WebDeveloper mike = new WebDeveloper("Angular6");
            // mike.Code();
            // mike.Code("C#");
            // mike.Code("C#", "HTML");
            // mike.Code(null, "HTML");

            // Dynamic Polymorphism using Abstract classes unifies related objects.
            List<Salesman> salesmen = new List<Salesman>() { new CarSalesman("James", "Weaver"), new CarSalesman("Sue", "McGregor"), new RetailSalesPerson("Delores", "Kirby"), new OnlineMarketer("Steve", "Rogers")};

            foreach (var item in salesmen) {
                ShowMeHowToSell(item);
            }

            // Dynamic Polymorphism using Interfaces can unify unrelated group of objects.
            List<SelfDeveloping> selfDeveloping = new List<SelfDeveloping>() { new RetailSalesPerson("Delores", "Kirby"), new WebDeveloper("C#")};

            foreach (var item in selfDeveloping) {
                ShowMeHowYouSelfDevelop(item);
            }

        }

        static void ShowMeHowToSell(Salesman salesman) {
          salesman.Sell();
        }

        static void ShowMeHowYouSelfDevelop(SelfDeveloping selfDeveloping) {
          selfDeveloping.Develop();
        }
    }
    
}