class MainClass 
{
    private static void Banana()
    {
        Console.Clear();
        Product product = new Product();
        product.description = "Banana";
        product.price = 1.99F;
        product.quantity = 0;
        Console.WriteLine("The {0} costs ${1} and {2}.", product.description, product.price, product.inStock());
        Console.ReadLine();
    }

    private static void Apple()
    {
        Console.Clear();
        Product product = new Product("Apple", 2.99F, 2);
        Console.WriteLine("The {0} costs ${1} and {2}.", product.description, product.price, product.inStock());
        Console.ReadLine();
    }

    private static bool MainMenu()
    {
        Console.Clear();
        Console.WriteLine("Welcome!");
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Banana");
        Console.WriteLine("2. Apple");
        Console.WriteLine("3. Exit");
        Console.Write("\r\nOption: ");

        switch (Console.ReadLine())
        {
            case "1":
                Banana();
                return true;
            case "2":
                Apple();
                return true;
            case "3":
                return false;    
            default:
                return true;
        }
    }

    public static void Main(string[] args)
    {
        while (MainMenu());
    }
}

