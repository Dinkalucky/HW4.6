using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._2
{
    public class Fahrenheit : Degrees
    {
        public override void DegreesConverter(int degrees)
        {
            Console.WriteLine($"{degrees} Celsius degrees = {degrees + 32} Fahrenheit degrees");
        }
    }
}
