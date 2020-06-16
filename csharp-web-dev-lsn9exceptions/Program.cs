using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentOutOfRangeException("Cant divide by 0");
            }

            return x / y;
        }




        private static int CheckFileExtension(string fileName)
        {
            if (fileName == "" || fileName == null)
            {
                throw new ArgumentNullException("There is nothing here");
            }
            else
            {

                if (fileName.Contains(".cs"))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
        }



        static void Main(string[] args)
        {

            //Test out your Divide() function here!
            try
            {

                Console.WriteLine(Divide(10, 2));
                Console.WriteLine(Divide(50, 0));
                //Console.WriteLine(Divide(25, 5));                   
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);


            }

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");


            foreach (KeyValuePair<string, string> kvp in students)
            {

                try
                {

                    Console.WriteLine("key: {0}, Value: {1}", kvp.Key, CheckFileExtension(kvp.Value));

                }             

                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e.Message);
                }

                            //Console.WriteLine(CheckFileExtension("Program.cs"));
                            //Console.WriteLine(CheckFileExtension(""));
                            //Console.WriteLine(CheckFileExtension("MyCode.cs"));
                            //Console.WriteLine(CheckFileExtension("CoolProgram.cs"));

            }
        }
    }
}
    


