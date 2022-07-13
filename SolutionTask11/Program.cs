//вариант 1
int number = new Random().Next(100, 1000);

Console.WriteLine(number);

int numberSecondDigit = number / 100;
int numberThirdDigit = number % 10;

Console.WriteLine("number " + numberSecondDigit + numberThirdDigit);

//вариант 2
void  middleDigitCutter()
{
    int number2 = new Random().Next(100, 1000);

    Console.WriteLine(number2);

    string stringNum = number2.ToString();

    Console.Write("number " + stringNum[0]);
    Console.WriteLine(stringNum[2]);
}

void middleDigitCutter2()
{
    int number2 = new Random().Next(100, 1000);

    Console.WriteLine(number2);

    int num1 = number2 / 100;
    int num2 = number2 % 10;

    Console.Write(num1 * 10 + num2);
}

middleDigitCutter();
middleDigitCutter2();