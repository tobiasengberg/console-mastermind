namespace console_mastermind;
using static System.Console;

public class DisplayHelpers
{
    public static void DisplayChoices(int[][] choices, int activeRow)
    {
        for (int i = 0; i < activeRow; i++)
        {
            foreach (int number in choices[i])
            {
                SetColor(number);
                if(number == 0) Write(" ");
                else Write('\u2b24'); 
                Write("  ");
            }
            WriteLine();
        }
    }

    private static void SetColor(int choice)
    {
        switch (choice)
        {
            case 1:
                ForegroundColor = ConsoleColor.Red;
                break;
            case 2:
                ForegroundColor = ConsoleColor.Blue;
                break;
            case 3:
                ForegroundColor = ConsoleColor.Green;
                break;
            case 4:
                ForegroundColor = ConsoleColor.Yellow;
                break;
            case 5:
                ForegroundColor = ConsoleColor.Magenta;
                break;
            case 6:
                ForegroundColor = ConsoleColor.Cyan;
                break;
            default:
                break;
        }
    }
}