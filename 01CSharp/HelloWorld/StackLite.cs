namespace StackLite;

public class StackLiteMenu
{
    public void MainMenu()
    {
        Console.WriteLine("Welcome to StackLite!");
        Console.WriteLine("What brings you here today?");

        string input = Console.ReadLine() ?? "default value";

       // string? n = null;
        //string input = n ?? "Other value";

        Console.WriteLine("You wrote: " + input);
    }
}