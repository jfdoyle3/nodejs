using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:        ");
 			Int32 numberOne=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number:  ");
 			Int32 numberTwo=Convert.ToInt32(Console.ReadLine());
        
 		    if (numberOne > numberTwo)
 		      Console.WriteLine("{0} is greater than {1}", numberOne, numberTwo);
 		    else
 		      Console.WriteLine("{0} is greater than {1}", numberTwo, numberOne);
            
        }
    }
}
