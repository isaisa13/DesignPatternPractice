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
            Print p = new PrintBanner("Hello");
            p.printStrong();
            p.printWeak();

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public abstract class Print
        {
            public abstract void printWeak();
            public abstract void printStrong();
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

        class PrintBanner : Print
        {
            Banner _banner;

            public PrintBanner(String string_)
            {
                _banner = new Banner(string_);
            }
            public override void printWeak() {
                _banner.showWithParen();
            }
            public override void printStrong() {
                _banner.showWithAster();
            }
        }




    }
}
