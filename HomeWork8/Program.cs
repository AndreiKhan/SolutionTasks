﻿//-------------------------Задача 8-------------------------
//-----------Показывает все четные числа от 1 до N----------
//----------------------------------------------------------
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    //Проверяем подходит ли заданное число для нашей программы
    if (inputNumber >= 2)
    {
        string outputLine = "2";

        //-------------------------------------------------------------------------------------------------------------------------------

        int count = 4;
        while(count <= inputNumber)
        {                                                                           //Первый вариант через while
            outputLine = outputLine + ", " + count;
            count += 2;
        }

        //-------------------------------------------------------------------------------------------------------------------------------

        // for (int i = 4; i <= inputNumber; i += 2)
        // {
        //     outputLine = outputLine + ", " + i;                                  //Второй вариант через for
        // }

        //-------------------------------------------------------------------------------------------------------------------------------

        Console.WriteLine(outputLine);

    }

    else
    {
        //Если число не в заданных рамках, то выведем сообщение
        Console.WriteLine("Эта программа определяет только четные числа от 1 до заданного числа");
    }
}