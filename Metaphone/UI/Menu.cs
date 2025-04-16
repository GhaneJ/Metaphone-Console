namespace Metaphone.Menu;

public class Menu
{
    public static void HUD_Directives()
    {
        Console.SetCursorPosition(36, 2);
        Console.WriteLine("┌──────────────────────────┐");
        Console.SetCursorPosition(36, 3);
        Console.WriteLine("│Welcome to Metaphone v.1.1│");
        Console.SetCursorPosition(36, 4);
        Console.WriteLine("│                          │");
        Console.SetCursorPosition(36, 5);
        Console.WriteLine("│ Quit the app   (ctrl-c)  │");
        Console.SetCursorPosition(36, 6);
        Console.WriteLine("└──────────────────────────┘");
    }
}
