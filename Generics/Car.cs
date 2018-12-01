using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Car
    {
        public string Name { get; set; }
        public double CostAsNew { get; set; }
        public string UnitOfMeasure { get; set; }

        public Car(string name, double cost, string UofM)
        {
            Name = name;
            CostAsNew = cost;
            UnitOfMeasure = UofM;
        }
    }
}
