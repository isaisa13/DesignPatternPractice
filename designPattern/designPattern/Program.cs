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
            Factory factory = new IDCardFactory();
            Product card1 = factory.create("ひろし");
            Product card2 = factory.create("ミッキー");
            Product card3 = factory.create("太郎");
            card1.use();
            card2.use();
            card3.use();
            
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public abstract class Product
        {
            public abstract void use();
        }

        public abstract class Factory
        {
            public Product create(string owner_)
            {
                Product p = createProduct(owner_);
                registerProduct(p);
                return p;
            }
            protected abstract Product createProduct(string owner_);
            protected abstract void registerProduct(Product product_);
        }

        public class IDCard : Product
        {
            string _owner;
            public IDCard(string owner_)
            {
                Console.WriteLine(owner_+"のカードを作ります。");
                _owner = owner_;
            }

            public override void use()
            {
                Console.WriteLine(_owner + "のカードを使います。");
            }

            public string getOwner()
            {
                return _owner;
            }
        }

        public class IDCardFactory : Factory
        {
            protected override Product createProduct(string owner_)
            {
                return new IDCard(owner_);
            }
            protected override void registerProduct(Product product_)
            {
            }
        }

    }
}
