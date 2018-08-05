using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }


        interface Print
        {
            void printWeak();
            void printStrong();
        }

        class Banner
        {
            public Banner(string string_)
            {
                _string = string_;
            }




            string _string;
        }



    }
}
