using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speeding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter height and width");
            int speed = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());
            int ans = height % width;
            Console.WriteLine("{0} % {1} is {2}", height, width, ans); 
        }
    }
}
