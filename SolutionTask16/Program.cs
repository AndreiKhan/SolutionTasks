//вариант 1
string? inputOne = Console.ReadLine();
string? inputTwo = Console.ReadLine();

if ((inputOne != null) && (inputTwo != null))
{
    int inputNumberFirst = int.Parse(inputOne);
    int inputNumberSecond = int.Parse(inputTwo);

    int a = inputNumberFirst * inputNumberFirst;
    int b = inputNumberSecond * inputNumberSecond;

    if ((a == inputNumberSecond) || (b == inputNumberFirst))
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");
    }
}