using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Car lada = new Car("Lada", "D")
            {
                Color = Color.DarkMagenta
            };
            Console.Write("A Owner of the car: ");
            Console.WriteLine(lada.CarPassport.Owner?.Name ??"A owner is not exist.");

            Driver driver1 = new Driver(new DateTime(2007, 5, 27), "Voldemar")
            {
                Category = new List<string> { "B", "C" }
            };

            try
            {
                lada.ChangeOwner(driver1, "o777oo");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            driver1.Category.Add("D");

            lada.ChangeOwner(driver1,"o777oo");
            Console.Write("Number of the car: ");
            Console.WriteLine(driver1.Car.CarNumber);
            Console.Write("The Owner of the car is: ");
            Console.WriteLine(lada.CarPassport.Owner.Name);

            Console.ReadLine();
           
        }
    }
}
