string? inputLineOne = Console.ReadLine();
string? inputLineTwo = Console.ReadLine();

if(inputLineOne != null && inputLineTwo != null);
{
    int NumberOne = int.Parse(inputLineOne);
    int NumberTwo = int.Parse(inputLineTwo);

    //if(NumberOne == NumberTwo * NumberTwo)
    //{
    //    Console.WriteLine("Yes");
    //}
    //else
    //{
    //    Console.WriteLine("No");
    //}

    if(NumberOne == Math.Sqrt(NumberTwo))
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}