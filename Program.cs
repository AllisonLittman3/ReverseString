using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Starts with string "LaunchCode"
            string myString = "LaunchCode";

            //Converts string into a character array
            char[] myArray = myString.ToCharArray();
            
            //Reverses the character array
            Array.Reverse(myArray);
            
            //Converts character array back into a string, replaces old string value
            myString = new string(myArray);

            //Writes the reversed string
            Console.WriteLine(myString);
            Console.ReadLine();

        }
    }
}
