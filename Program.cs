using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Working_with_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will write same line");
            Console.WriteLine("This will \n wrap to next line");
            Console.WriteLine("This will \" print out the quotation mark. ");

            string firstname = "Bonolo";
            string lastname = "Galane";
            //concatination
            Console.WriteLine(firstname + "  " + lastname);

            //functions with string
            Console.WriteLine(lastname.Length);

            //methods on strings
            Console.WriteLine(firstname.ToUpper());

            //methods with a parameter eg the contains(), its case sensitive
            Console.WriteLine(lastname.Contains("gal"));

            //access characters using index
            Console.WriteLine(firstname[0]);

            //indexof will tell you if the value is there and at what position
            Console.WriteLine("index of a is : ");
            Console.WriteLine(lastname.IndexOf('a')); //can use double quotes too
            //substring, to grab from an index onwards
            Console.WriteLine(firstname.Substring(1));
            //you can also give index and length ie how many chars you wanna grab
            Console.WriteLine(firstname.Substring(1,2));
            Console.Read();
          
        }
    }
}
