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
            AbstractDisplay d1 = new CharDisplay('H');
            AbstractDisplay d2 = new StringDisplay("Hello, world.");
            AbstractDisplay d3 = new StringDisplay("こんにちは");

            d1.display();
            d2.display();
            d3.display();

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public abstract class AbstractDisplay
        {
            public abstract void open();
            public abstract void print();
            public abstract void close();
            public void display()
            {
                open();
                for(int i = 0; i < 5; i++)
                {
                    print();
                }
                close();
            }
        }


        public class CharDisplay : AbstractDisplay
        {
            char _ch;
            public CharDisplay(char ch_)
            {
                _ch = ch_;
            }

            public override void open()
            {
                Console.Write("<<");
            }
            
            public override void print()
            {
                Console.Write(_ch);
            }

            public override void close()
            {
                Console.WriteLine(">>");
            }
        }

        public class StringDisplay : AbstractDisplay
        {
            string _string;
            int    _width;


            public StringDisplay(string string_)
            {
                _string = string_;
                _width = _string.Length;
            }

            public override void open()
            {
                printLint();
            }

            public override void print()
            {
                Console.WriteLine("|"+_string+"|");
            }

            public override void close()
            {
                printLint();
            }

            void printLint()
            {
                Console.Write("+");
                for(int i=0; i < _width; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine("+");
            }
        }



    }
}
