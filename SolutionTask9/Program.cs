//метод решения задачи вариант 1
void variant1(System.Random numberSintezator)
{
    int number = numberSintezator.Next(10, 100);

    Console.WriteLine(number);

    int firstNumber = number / 10;
    int secondNumber = number % 10;

    if(firstNumber > secondNumber)
    {
        Console.WriteLine(firstNumber);
    }
    else
    {
        Console.WriteLine(secondNumber);
    }
}

//метод решения задачи вариант 2
void variant2()
{
    int number2 = new Random().Next(10, 100);

    Console.WriteLine(number2);

    string stringNum = number2.ToString();

    if (stringNum[0] > stringNum[1])
    {
        Console.WriteLine(stringNum[0]);
    }
    else
    {
        Console.WriteLine(stringNum[1]);
    }
}

//метод решения задачи вариант 3
void variant3(System.Random numberSintezator)
{
char[] digits = numberSintezator.Next(10, 100).ToString().ToCharArray();

Console.WriteLine(digits);

int firstNumber = ((int)digits[0])-48;
int secondNumber = ((int)digits[1])-48;

int resultNumber = firstNumber > secondNumber ? resultNumber = firstNumber : resultNumber = secondNumber;

Console.WriteLine(resultNumber);
}

System.Random numberSintezator =  new Random();

variant1 (numberSintezator);

variant2 ();

variant3 (numberSintezator);
