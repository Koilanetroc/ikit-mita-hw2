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
            Car lada = new Car("Lada", Category.D)
            {
                Color = Color.DarkMagenta
            };
            Console.Write("A Owner of the car: ");

            try
            {
                Console.WriteLine(lada.CarPassport.Owner.Name);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("A owner is not exist.");
            }

            Driver driver1 = new Driver(new DateTime(2017, 6, 07), "Voldemar")
            {
                Category = new List<Category> { Category.B, Category.C }
            };

            try
            {
                lada.ChangeOwner(driver1, "o777oo");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            driver1.Category.Add(Category.D);

            try
            {
                lada.ChangeOwner(driver1, "o777oo");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.Write("Number of the car: ");
            Console.WriteLine(driver1.Car.CarNumber);
            Console.Write("The Owner of the car is: ");
            try
            {
                Console.WriteLine(lada.CarPassport.Owner.Name);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("A owner is not exist.");
            }
            Console.ReadLine();
        }
    }
}
