public static class Statistics
{
    public static int BreathingCount = 0;
    public static int ReflectionCount = 0;
    public static int ListingCount = 0;

    public static void DisplayStats()
    {
        Console.Clear();
        Console.WriteLine("Session Statistics\n");
        Console.WriteLine($"Breathing completed: {BreathingCount}");
        Console.WriteLine($"Reflection completed: {ReflectionCount}");
        Console.WriteLine($"Listing completed: {ListingCount}");
        Console.WriteLine("\nPress Enter to return to menu...");
        Console.ReadLine();
    }
}