//prompting the user to input their dice sides
Console.WriteLine("Please enter how many sides are on the dice you are rolling.");
int dicesides = 0;





while (dicesides <= 0)
{
    while (int.TryParse(Console.ReadLine(), out dicesides) == false && dicesides > 0)
    {
        Console.WriteLine("That's is not a valid input, please enter the number of sides on your dice.");
    }

}





int r1 = 0;
int r2 = 0;
//Console.WriteLine("Rolling...");
bool goagain = true;
string answer = "";


do
{
    if (dicesides == 6)
    {
        r1 = Diceroll(dicesides);
        r2 = Diceroll(dicesides);
        Console.WriteLine($"You got {r1} and {r2}.");
        //together that makes {d6combo(r1, r2)}
        string check = "";
        check = D6Combo(r1, r2);
        if (check != "nothing")
        {
            Console.WriteLine($"You got {D6Combo(r1, r2)}!");
        }
        check = D6Combo2(r1, r2);
        if (check != "nothing")
        {
            Console.WriteLine($"You got {D6Combo2(r1, r2)}!");
        }
    }
    else if (dicesides == 20)
    {
        r1 = D20(dicesides);
        Console.WriteLine($"You got {r1} thats a {D20Combo(r1)}");
    }
    else
    {
        r1 = Diceroll(dicesides);
        r2 = Diceroll(dicesides);
        Console.WriteLine($"You got {r1} and {r2}.");
    }
    Console.WriteLine("goagain?");
    answer = Console.ReadLine();
    if (answer == "y")
    {
        goagain = true;
    }
    else
    {
        goagain = false;
    }
} while (goagain == true);



















static int Diceroll(int dicesides)
{
    Random roll = new Random();
    return roll.Next(1, dicesides + 1);
}
static string D6Combo(int r1, int r2)
{
    if (r1 == 1 && r2 == 1)
    {
        return "snake eyes";
    }
    else if ((r1 == 1 && r2 == 2) || (r2 == 1 && r1 == 2))
    {
        return "ace deuce";
    }
    else if (r1 == 6 && r2 == 6)
    {
        return "box cars";
    }
    else
    {
        return "nothing";
    }
}
static string D6Combo2(int r1, int r2)
{
    if ((r1 + r2 == 7) || (r1 + r2 == 11))
    {
        return "a win";
    }
    else if ((r1 + r2 == 2) || (r1 + r2 == 3) || (r1 + r2 == 12))
    {
        return "craps";
    }
    else
    {
        return "nothing";
    }
}

static int D20(int dicesides)
{
    Random roll = new Random();
    return roll.Next(1, dicesides + 1);
}

static string D20Combo(int r1)
{
    if (r1 == 20)
    {
        return "Nat 20!";
    }
    else if (r1 >10 && r1 <20)
    {
        return "good roll!";
    }
    else if (r1 <=10 && r1 > 1)
    {
        return "bad roll!";
    }
    else
    {
        return "critical failure!";
    }
}