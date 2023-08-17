
{
    Console.WriteLine("emter first num");
    int n1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("enter second num");
    int n2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("1. addition");
    Console.WriteLine("2. subtraction");
    Console.WriteLine("3. multiplication");
    Console.WriteLine("4. division");
    Console.WriteLine("select any num for operation");
    int option = Convert.ToInt32(Console.ReadLine());
    if (option == 1)
    {
        int Sum = n1 + n2;
        Console.WriteLine($"sum of num is {Sum}");
    }
    else if (option == 2)
    {
        int sub = 0;
        if(n1>n2)
        sub = n1 - n2;
        else sub = n2 - n1;
        Console.WriteLine($"sub is {sub}");
    }
    else if (option == 3)
    {
        int mul = n1 * n2;
        Console.WriteLine($"mul is {mul}");
    }
    else if (option == 4)
    {
        int div = n1 / n2;
        Console.WriteLine($"div is {div}");
    }
    else
    {
        Console.WriteLine($"invalid option");
    }
}
