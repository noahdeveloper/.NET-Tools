using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Car", 30000, "Each");
            var phone = new Phone("Phone", 90, "Each");
            var milk = new Milk("Milk", 4.99, "ml");
            
            var genericList = new GenericItemList();

            genericList.Add<Car>(car);
            genericList.Add<Phone>(phone);
            genericList.Add<Milk>(milk);

            Console.WriteLine(genericList.ListToString());
            Console.ReadLine();
        }
    }
}
