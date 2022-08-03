Console.Clear();
Console.WriteLine("Введите число: ");

string? inputLineNumber = Console.ReadLine();
int inputNumber = int.Parse(inputLineNumber);

int t;

t = Environment.TickCount;
Console.WriteLine(sumNums(inputNumber));
Console.WriteLine("Simple time: {0} ms", Environment.TickCount - t);

t = Environment.TickCount;
Console.WriteLine(mulRec(inputNumber));
Console.WriteLine("Simple time: {0} ms", Environment.TickCount - t);

int sumNums(int num)
{
    int sum = 1;
    for(int i = 1; i <= inputNumber; i++)
    {
        sum *= i;
    }
    return sum;
}

int mulRec(int num)
{
    if (num == 1)
    {
        return 1;
    }
    else
    {
        return num * mulRec(num - 1);
    }
}