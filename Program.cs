using System;

class MainClass 
{
    private static void Task1()
    {
        Console.Clear();
        Console.WriteLine("Running Task 1.");
        Console.ReadLine();
    }

    private static void Task2()
    {
        Console.Clear();
        Console.WriteLine("Running Task 2.");
        Console.ReadLine();
    }

    private static bool MainMenu()
    {
        Console.Clear();
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Run Task 1.");
        Console.WriteLine("2. Run Task 2.");
        Console.WriteLine("3. Exit");
        Console.Write("\r\nOption: ");

        switch (Console.ReadLine())     
        {
            case "1":
                Task1();
                return true;
            case "2":
                Task2();
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

