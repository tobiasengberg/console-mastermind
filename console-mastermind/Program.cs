using console_mastermind;
using console_mastermind.Subdirectory;
using static System.Console;
using static console_mastermind.DisplayHelpers;

Account newAccount = new Account("Fred");
Person person = newAccount.AccountHolder;
newAccount.AccountHolder = new Person("Roland");
newAccount.ReturnHolder();
Registration reg = new Registration();


int turn = 1;
int position = 0;

int[] secret = [4, 1, 4, 2];

int[][] numbers = [
    [0, 0, 0, 0], 
    [0, 0, 0, 0],
    [0, 0, 0, 0],
    [0, 0, 0, 0],
    [0, 0, 0, 0],
    [0, 0, 0, 0],
    [0, 0, 0, 0],
    [0, 0, 0, 0],
    [0, 0, 0, 0],
    [0, 0, 0, 0],
    [0, 0, 0, 0],
    [0, 0, 0, 0]
];

while (turn < 13)
{
    Clear();
    DisplayChoices(numbers, turn);
    ConsoleKeyInfo input = ReadKey();
    Write(input.Key);
    switch (input.Key)
    
    
    {
        case ConsoleKey.LeftArrow:
            if(position > 0) position--;
            break;
        case ConsoleKey.RightArrow:
            if(position < 3) position++;
            break;
        case ConsoleKey.UpArrow:
            if (numbers[turn - 1][position] == 6) numbers[turn - 1][position] = 1;
            else numbers[turn - 1][position]++;
            break;
        case ConsoleKey.DownArrow:
            if (numbers[turn - 1][position] == 0 || numbers[turn - 1][position] == 1) numbers[turn - 1][position] = 6;
            else numbers[turn - 1][position]--;
            break;
        case ConsoleKey.Enter:
            if (numbers[turn - 1].Contains(0)) break;
            turn++;
            position = 0;
            break;
    }
}



