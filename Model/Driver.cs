using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Driver
    {
        public Driver(DateTime dateTime, string name)
        {
            LicenseDate = dateTime;
            Name = name;
        }

        public DateTime LicenseDate { get; }
        public string Name { get; }

        public int Experience
        {
            get
            {
                return DateTime.Now.Year-LicenseDate.Year ;
            }
        }

        public List<string> Category { get; set; }

        public Car Car { get; private set; }

        public void OwnCar(Car car)
        {
            if (car!= null && Category.Contains(car.Category))
            {
                Car = car;
            }
            else if(!Category.Contains(car.Category))
            {
                throw new Exception("Categories not match");
            }
        }
    }
}
