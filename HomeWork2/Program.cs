//Вводим два числа
string? inputLineOne = Console.ReadLine();
string? inputLineTwo = Console.ReadLine();

//Проверяем ввели мы числа
if (inputLineOne != null && inputLineTwo != null)
{
    //Превраращаем их в целочисленные
    int outputLineOne = int.Parse(inputLineOne);
    int outputLineTwo = int.Parse(inputLineTwo);

    //Ищем боольше число из двух
    if (outputLineOne > outputLineTwo)
    {
        Console.WriteLine("Max = " + outputLineOne);
    }
    else
    {
        Console.WriteLine("Max = " + outputLineTwo);
    }
}