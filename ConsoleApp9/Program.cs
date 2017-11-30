using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[3];
            names[0] = "Dambar";
            names[1] = "Mike";
            names[2] = "Alec";

            string[] majors = new string[3];
            names[0] = "Computer Science";
            names[1] = "Programming";
            names[2] = "Networking";
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i] + ": " + majors[i]);
            }
            
        }
    }
}
