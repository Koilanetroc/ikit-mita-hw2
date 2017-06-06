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

        public double Experience
        {
            get
            {
                int years = DateTime.Now.Year - LicenseDate.Year;

                if(LicenseDate.Month > DateTime.Now.Month || (LicenseDate.Day > DateTime.Now.Day && LicenseDate.Month == DateTime.Now.Month))
                {
                    return years - 1;
                }
                return years;
            }
        }

        public List<Category> Category { get; set; }

        public Car Car { get; private set; }

        public void OwnCar(Car car)
        {
            if (Category.Contains(car.Category))
            {
                Car = car;
            }
            else
            {
                throw new Exception("Categories not match");
            }
        }
    }
}
