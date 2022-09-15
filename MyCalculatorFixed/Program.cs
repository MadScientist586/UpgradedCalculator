while (true)
{

    Console.WriteLine("Please enter a number: ");
    var a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter a second number: ");
    var b = Convert.ToInt32(Console.ReadLine());
    var addition = a += b;
    var subtraction = a -= b;
    var multiplication = a *= b;
    var division = a /= b;
    var modulus = a %= b;
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine($"The sum is {addition}");
    Console.WriteLine($"The difference is {subtraction}");
    Console.WriteLine($"The product is {multiplication}");
    Console.WriteLine($"The quotient is {division}");
    Console.WriteLine($"The remainder is {modulus}");

    Console.WriteLine("Would you like to use the calculator again?");
    Console.WriteLine("1 = Yes 2 = No");
    var userAnswer = Convert.ToInt32(Console.ReadLine());
    if (userAnswer == 1)
    {
        Console.WriteLine("Ok lets start over.");

    }
    else if (userAnswer == 2)
    {
        Console.WriteLine("Ok, goodbye!");
        break;

    }
    else
    {
        Console.WriteLine("That's not an option. Goodbye.");
        break;
    }

}


