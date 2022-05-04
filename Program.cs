class MainClass 
{
    private static bool MainMenu()
    {
        Console.Clear();
        Console.WriteLine("Welcome!");
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Register product");
        Console.WriteLine("2. Sell product");
        Console.WriteLine("3. Exit");
        Console.Write("\r\nOption: ");

        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine("Product registered");
                Console.ReadKey();
                return true;
            case "2":
                Console.WriteLine("Product sold");
                Console.ReadKey();
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