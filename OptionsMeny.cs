namespace PPtimeDani
{
    internal class OptionsMeny
    {
        public OptionsMeny()
        {
            int Options = 0;

            do
            {
                WelcomeMessage();
                try
                {
                    Options = Convert.ToInt32(Console.ReadLine());
                }
                catch { break; }
                if (Options == 1) { PrintAllProducts(); }
                else if (Options == 2) { AddToCart(); }
                else if (Options == 3) { RemoveFromCart(); }
                else if (Options == 4) { PrintUserCart(); }
                else if (Options == 5) { Environment.Exit(0); }
            } while (Options != 6);



            Console.WriteLine("Thanks for visiting our shop!");
        }

        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to our Shop! ");
            Console.WriteLine("1. Show all products");
            Console.WriteLine("2. Add products to cart");
            Console.WriteLine("3. Remove product from cart");
            Console.WriteLine("4. Show all products in cart");
            Console.WriteLine("5. Exit");
        }

        public void PrintAllProducts()
        {

        }

      
     

      
    }
}
