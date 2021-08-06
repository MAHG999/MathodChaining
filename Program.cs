using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodChaining
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 4, 1, 4, 22, 12, 6, 2 };

            var number2 = numbers.Where(d => d > 2).OrderBy(d => d).Take(5).ToList();

            number2.ForEach((n) => Console.WriteLine(n));

            Beer beer = new Beer();
            beer.Setname("Haineken").SetBrand("Arab");

            var S = new StringBuilder("");
            S.Append("Hola").Append(" ").Append("Mundo").Replace("Mundo", "Todos");
            Console.WriteLine(S);
            
        }

        public class Beer
        {
            private string _name { get; set; }
            private string _brand{ get; set; }

            public Beer Setname(string name)
            {
                _name = name;
                return this;
            }

            public Beer SetBrand(string brand)
            {
                _brand = brand;
                return this;
            }
        }
    }
}
