using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Car
    {
        public string Model { get; }
        public Car(string model, DriverCategory category)
        {
            Model = model;
            CarPassport = new CarPassport(this);
            Category = category;
            Color = Color.Blue;
        }

        public Color Color { get; set; }

        public string CarNumber { get; private set; }
        public DriverCategory Category { get; }
        public CarPassport CarPassport { get; }

        public void ChangeOwner(Driver driver,string carNumber)
        {
            driver.OwnCar(this);
            CarPassport.Owner = driver;
            CarNumber = carNumber;
        }
    }
}
