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
            Car lada = new Car("Ara", 'C')
            {
                Color = Color.DarkMagenta
            };
            Console.WriteLine(lada.Model);

            Driver driver1 = new Driver(new DateTime(2007, 5, 27), "Voldemar")
            {
                Category = new List<string> { "B", "C" }
            };

            lada.ChangeOwner(driver1,"o777oo");
            driver1.Category.Add("D");

            lada.ChangeOwner(driver1,"o777oo");

            Console.WriteLine(driver1.Car.CarNumber);
            Console.WriteLine(lada.Model);
            Console.ReadLine();
        }
    }
}
