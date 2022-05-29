using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpdays5_Assigement
{
    internal class swaptwonumber
    {
        public void swap ()
            {

            Console.WriteLine("please enter a number");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine(x);
           // Console.WriteLine(y);
            Console.WriteLine(($"your first number:"+ x ));
            Console.WriteLine(($"your second number:" + y));

               
            Console.WriteLine("Before swap x= " + x + " y= " + y);
            Console.Write("After swap x= " + y + " y= " + x);

        }
            
    }
}
