using CSharpdays5_Assigement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay5Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n problem 1 for even or odd \n problem 2 for leapyear \n problem 3 for large3number \n problem 4 for factornumber");
            Console.WriteLine(" problem 5 for hormonic num \n problem 6 for swap2number \n problem 7 for qutant& remainder");
            Console.WriteLine(" problem 8 for vowelor constant");
            Console.WriteLine("Enter your choice : ");
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    EvenOddNumber number = new EvenOddNumber();
                    number.Number();
                    break;

                   
                case 2:
                    Leepyear year = new Leepyear();
                    year.year();
                    break;

                  case 3:
                    Largethreenumber largethreenumber = new Largethreenumber();
                    largethreenumber.large();
                    break;

                case 4:
                    Factornumber factornumber = new Factornumber();
                    factornumber.factor();
                    break;

                case 5:
                    Harmonicnumber harmonicnumber = new Harmonicnumber();
                    harmonicnumber.harnonic();
                    break;
                case 6:
                    swaptwonumber swaptwonumber = new swaptwonumber();
                    swaptwonumber.swap();
                    break;
                case 7:
                    QuotientandRemainder quotientandRemainder = new QuotientandRemainder();
                    quotientandRemainder.divide();
                    break;
                case 8:
                    VowelorConsonant vowelorConsonant = new VowelorConsonant();
                    vowelorConsonant.vowel();
                    break;
                    default:
                    Console.WriteLine("please enter valid number ");
                    break;

            Console.ReadLine();

        }
        }
    }
}
