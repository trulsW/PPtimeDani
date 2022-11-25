namespace PPtimeDani
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Product> ShoppingCart { get; set; }

        public User(string username, string password, List<Product> shoppingCart)
        {
            Username = username;
            Password = password;
            ShoppingCart = new List<Product>();
        }

        public void AddToCart(Product product) => ShoppingCart.Add(product);

        public void RemoveFromCart(Product product) => ShoppingCart.Remove(product);


        public void PrintUserCart()
        {
            foreach (var product in ShoppingCart)
            {
                product.PrintAllProductInfo();
            }
        }
    }
}
