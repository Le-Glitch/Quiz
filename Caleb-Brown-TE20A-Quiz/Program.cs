using System;

ConsoleKey menus = ConsoleKey.E;
int points = 0;
bool correct = false;

if(menus != ConsoleKey.Enter)
{
    start();
}

void start()
{
    

    

    while(menus != ConsoleKey.Enter && menus != ConsoleKey.Escape)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        
        Console.Clear();
        Console.WriteLine("Welcome to this amazing quiz");
        Console.WriteLine("You'll answer a total of 10 questions making the total amount of points acquirable 10");
        Console.WriteLine("Every question will be random from a list of questions");
        Console.WriteLine("You'll answer with either \"a\", \"b\", \"c\" or \"d\"");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("Press ENTER to start");

        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine("Press ESC to exit");
        menus = Console.ReadKey().Key;
    }

    if(menus == ConsoleKey.Enter)
    {
        Console.Clear();
        q1();
    }
}



void q1()
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;

    Console.WriteLine();
    Console.ReadLine();

    if(correct == true)
    {
        points++;
    }

    Console.WriteLine($"You now have {points} points");
}