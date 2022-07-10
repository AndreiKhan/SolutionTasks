//------------------Задача 2--------------------
//-------Определение большего числа из двух-----
//----------------------------------------------
//Вводим два числа
string? inputLineOne = Console.ReadLine();
string? inputLineTwo = Console.ReadLine();

//Проверяем ввели ли мы числа
if (inputLineOne != null && inputLineTwo != null)
{
    //Превраращаем их в целочисленные
    int outputLineOne = int.Parse(inputLineOne);
    int outputLineTwo = int.Parse(inputLineTwo);

    //-------------------------------------------------------------------------------------------------------------------------------

    // //Ищем большее число из двух
    // if (outputLineOne > outputLineTwo)
    // {
    //     Console.WriteLine("Max = " + outputLineOne);
    // }
    // else                                                                         //Первый вариант решения через if
    // {
    //     Console.WriteLine("Max = " + outputLineTwo);
    // }

    //-------------------------------------------------------------------------------------------------------------------------------

    // int maxNumber = Math.Max(outputLineOne, outputLineTwo);
    // Console.WriteLine("Max = " + Math.Max(outputLineOne, outputLineTwo));        //Второй вариант решения через Math.Max

    //-------------------------------------------------------------------------------------------------------------------------------

    Console.WriteLine("Max = " + Math.Max(outputLineOne, outputLineTwo));           //Третий вариант черз Math.Max без создания переменной

    //-------------------------------------------------------------------------------------------------------------------------------
}