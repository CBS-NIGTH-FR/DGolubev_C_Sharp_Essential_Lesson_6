using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    static class Sort
    {
        static public void SortMinMax(this int[] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                for (int y = 0; y < mass.Length; y++)
                {
                    if (mass[i] < mass[y])
                    {
                        int x = mass[y];
                        mass[y] = mass[i];
                        mass[i] = x;
                    }
                }
            }
        }
    }
    class MassArray
    {
        public int[] Number { get; set; }
        Random random_number;

        public int[] InitializationMass(int number)
        {
            Number = new int[number];
            return Number;
        }

        public void SortNumber(int[] mass)
        {
            mass.SortMinMax();
            foreach (var item in mass)
            {
                Console.Write(item + " ");
            }
        }

        public void AddNumber()
        {
            for (int i = 0; i < Number.Length; i++)
            {
                random_number = new Random();
                int a = random_number.Next(100);

                if (!Number.Contains(a))
                {
                    Number[i] = a;
                    Console.Write(Number[i] + " ");
                }
                else i--;
            }
        }
    }
}
