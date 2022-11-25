namespace PPtimeDani
{


    internal class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }



        public Product(string name, int price, string title, string description)
        {
            Name = name;
            Price = price;
            Title = title;
            Description = description;
            
        }

        public void PrintAllProductInfo()
        {
            Console.WriteLine($"Name: {Name} \nPrice: {Price} \nDescription: {Description} \nTitle: {Title} ");


        }
    }
}