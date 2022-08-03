Console.Clear();
Console.WriteLine("Введите число: ");

string? inputLineNumber = Console.ReadLine();
int inputNumber = int.Parse(inputLineNumber);

Console.WriteLine(sumNums(inputNumber));
Console.WriteLine(mulRec(inputNumber));

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