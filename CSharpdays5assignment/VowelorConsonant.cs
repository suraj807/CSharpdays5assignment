using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpdays5_Assigement
{
    internal class VowelorConsonant
    {
        public void vowel()
        {

            Console.Write("Input an Alphabet ( a-z) : ");
            char ch;
          //  int i ; //=ch;
            ch = Convert.ToChar(Console.ReadLine());

           // //if (i >= 0 && i <= 2)
            //{
            //    Console.WriteLine("you enter a number value && please enter a to z only");
            //}
            //else
           // {
                switch (ch)
                {
                    case 'a':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'i':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'o':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'u':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'e':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    default:
                        Console.WriteLine("The Alphabet is not a vowel");
                        break;
                }
         }
    }
}
