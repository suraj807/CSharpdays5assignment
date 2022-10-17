using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpdays5_Assigement
{
    internal class QuotientandRemainder
    {
        public void divide()
        {
            Console.WriteLine("please enter dividend");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());
           

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
           
        }
    }
}
