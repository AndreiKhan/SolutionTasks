Console.Clear();
Console.WriteLine("Введите число: ");

string inputLineNumber = Console.ReadLine()??""; // NULL safety
int inputNumber = int.Parse(inputLineNumber);

DateTime timePoint = DateTime.Now;

int VariantChar()
{
    // int numberLength = 0;
    // char[] array = inputLineNumber.ToCharArray();
    // numberLength = array.Length;                     это тоже самое что и в return

    return inputLineNumber.ToCharArray().Length;
}

int VariantSimple()
{
    int numberLength = 0;
    int digits = 1;

    while(digits < inputNumber)
    {
        digits = digits * 10;
        numberLength++;
    }

    return numberLength;
}

int variantLog10()
{
    return (int)Math.Log10(inputNumber) + 1;  // принудительно преобразовать в int если перед math написать (int)
}

int result = 0;
timePoint = DateTime.Now;

result = VariantChar();
Console.WriteLine(result);
Console.WriteLine(DateTime.Now - timePoint);

timePoint = DateTime.Now;
result = VariantSimple();
Console.WriteLine(result);
Console.WriteLine(DateTime.Now - timePoint);

timePoint = DateTime.Now;
result = variantLog10();
Console.WriteLine(result);
Console.WriteLine(DateTime.Now - timePoint);