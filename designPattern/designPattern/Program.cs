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
            IPrint p = new PrintBanner("Hello");
            p.printStrong();
            p.printWeak();

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }


        interface IPrint
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

            public void showWithParen()
            {
                Console.WriteLine("(" + _string + ")");
            }

            public void showWithAster()
            {
                Console.WriteLine("*" + _string + "*");
            }

            string _string;
        }

        class PrintBanner : Banner,IPrint
        {
            public PrintBanner(String string_):base(string_)
            {
            }
            public void printWeak() {
                showWithParen();
            }
            public void printStrong() {
                showWithAster();
            }
        }




    }
}
