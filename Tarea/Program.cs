using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the Base of the triangle?");
            string Tbase = Console.ReadLine();
            double baseT = Convert.ToDouble(Tbase);

            Console.WriteLine("What is the Height of the triangle?");
            string Theight = Console.ReadLine();
            double heightT = Convert.ToDouble(Theight);

            double formulaT = .5;

            Console.WriteLine(heightT * baseT * formulaT);
            Console.ReadLine();


        }
    }
}
