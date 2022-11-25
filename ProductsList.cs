namespace PPtimeDani
{
    internal class ProductsList
    {
        private List<Product> products = new();
        public ProductsList()
        {
            //Lage produkter til hard kode.
            products.Add(new Product("Nike", 420, "Very confortable shoes", "Made for running, made of the finest running material in the entire land."));
            //products.Add(new Product("Hoodie", 310, "");
            

            
        }

      
        public void PrintAll()
        {
            foreach (var Product in products)
            {
                Product.PrintAllProductInfo();
            }
        }
        
    }
}
