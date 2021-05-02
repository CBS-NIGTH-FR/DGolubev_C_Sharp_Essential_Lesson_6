using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MassArray mass = new MassArray();
            int[] number = mass.InitializationMass(20);
            mass.AddNumber();
            Console.WriteLine();
            mass.SortNumber(number);
            Console.ReadKey();
        }
    }
}
