namespace console_mastermind;
using static System.Console;

public class UserActionHelpers
{
    public static void HandleChoice(int[][] numbers, int position, int turn)
    {
        ConsoleKeyInfo input = ReadKey();
        Write(input.Key);
        switch (input.Key)
        {
            case ConsoleKey.LeftArrow:
                if (position > 0) position--;
                break;
            case ConsoleKey.RightArrow:
                if (position < 3) position++;
                break;
            case ConsoleKey.UpArrow:
                if (numbers[turn - 1][position] == 6) numbers[turn - 1][position] = 1;
                else numbers[turn - 1][position]++;
                break;
            case ConsoleKey.DownArrow:
                if (numbers[turn - 1][position] == 0 || numbers[turn - 1][position] == 1)
                    numbers[turn - 1][position] = 6;
                else numbers[turn - 1][position]--;
                break;
            case ConsoleKey.Enter:
                if (numbers[turn - 1].Contains(0)) break;
                turn++;
                position = 0;
                break;
        }
    }
}