using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortOrLand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter height:  ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter width:   ");
            int width = Convert.ToInt32(Console.ReadLine());
            if (height > width)
                Console.WriteLine("{0}w X {1}h is Portrait", width, height);
            else
                Console.WriteLine("{0}w X {1}h is Landscape", width, height);
        }
    }
}
