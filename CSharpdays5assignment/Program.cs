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
           

            EvenOddNumber number = new EvenOddNumber();
            number.Number();

            Leepyear year = new Leepyear();
            year.year();

            Largethreenumber largethreenumber = new Largethreenumber();
            largethreenumber.large();

            Factornumber factornumber = new Factornumber();
            factornumber.factor();

            Harmonicnumber harmonicnumber = new Harmonicnumber();
            harmonicnumber.harnonic();




            swaptwonumber swaptwonumber = new swaptwonumber();
            swaptwonumber.swap();

            

            QuotientandRemainder quotientandRemainder = new QuotientandRemainder();
            quotientandRemainder.divide();


            

            VowelorConsonant vowelorConsonant = new VowelorConsonant();
            vowelorConsonant.vowel();


           

            
            Console.ReadLine();
        }
    }
}
