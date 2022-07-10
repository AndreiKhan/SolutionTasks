//------------------Задача 4--------------------
//-------Определение большего числа из трех-----
//----------------------------------------------
//Вводим три числа
string? inputLineOne = Console.ReadLine();
string? inputLineTwo = Console.ReadLine();
string? inputLineThree = Console.ReadLine();

//Проверяем ввели ли мы числа
if (inputLineOne != null && inputLineTwo != null && inputLineThree != null)
{
    //Превраращаем их в целочисленные
    int outputLineOne = int.Parse(inputLineOne);
    int outputLineTwo = int.Parse(inputLineTwo);
    int outputLineThree = int.Parse(inputLineThree);

    //-------------------------------------------------------------------------------------------------------------------------------

    //Ищем большее число из трех
    //Определяем, первое число больше второго?
    // if (outputLineOne > outputLineTwo)
    // {
    //     //Определяем, первое число больше третьего?
    //     if(outputLineOne > outputLineThree)
    //     {
    //         Console.WriteLine("Max = " + outputLineOne);
    //     }
    //     else
    //     {
    //         Console.WriteLine("Max = " + outputLineThree);                                           //Первый вариант через if
    //     }
    // }
    // else
    // {
    //     //Определяем, второе число больше третьего?
    //     if(outputLineTwo > outputLineThree)
    //     {
    //         Console.WriteLine("Max = " + outputLineTwo);
    //     }
    //     else
    //     {
    //         Console.WriteLine("Max = " + outputLineThree);
    //     }
    // }

    //-------------------------------------------------------------------------------------------------------------------------------

    // int maxNumber = Math.Max(outputLineOne, Math.Max(outputLineTwo, outputLineThree));               //Второй вариант через Мath.Max
    // Console.WriteLine("Max = " + maxNumber);

    //-------------------------------------------------------------------------------------------------------------------------------

    Console.WriteLine("Max = " + Math.Max(outputLineOne, Math.Max(outputLineTwo, outputLineThree)));    //Третий вариант черз Math.Max без создания переменной

    //-------------------------------------------------------------------------------------------------------------------------------
}