﻿//--------------------------------Задача 13----------------------------
//----Принимает заданное число и выводит третью цифру если она есть----
//---------------------------------------------------------------------

//-------------------------------------------------------------------------------------------------------------------------------

// Console.Write("Введите число: ");                                                               //Первый вариант

// //Создаем метод нахождения третьей цифры из заданного числа
// void thirdNumber(string inp)
// {
//     //переводим полученный string в char
//     char[] charNumber = inp.ToCharArray();

//     //Проверяем есть ли в заданном числе третья цифра
//     if (charNumber.Length >= 3)
//     {
//         Console.WriteLine("Третья цифра из заданного числа: " + charNumber[2]);
//     }
//     else
//     {
//         Console.WriteLine("В этом числе нет третьей цифры");
//     }
// }

// try
// {
//     string inputNumber = Console.ReadLine();

//     //Переводим полученную строку в int, чтобы выявить ошибку, если были введены цифры то все пройдет нормально
//     int number = int.Parse(inputNumber);

//     //Проверяем отрицательное ли число
//     if (number < 0)
//     {   
//         //Если отрицательно то получаем его модуль
//         number = Math.Abs(number);
//         string absNumber = number.ToString();

//         //Передаем методу модуль числа
//         thirdNumber(absNumber);
//     }
//     else
//     {
//         thirdNumber(inputNumber);
//     }
// }
// catch(Exception)
// {
//     //Используем TryCatch для того чтобы выдавал нужное сообщение а не ошибку
//     Console.WriteLine("Это не число или оно слишком большое или слишком маленькое, попробуйте еще раз");
// }

//-------------------------------------------------------------------------------------------------------------------------------

//Создаем метод нахождения третьей цифры из заданного числа
void secondNumber(int num)
{
    //Проверяем есть ли в заданном числе третья цифра
    if (num > 99)
    {
        //если число содержит больше трех цифр то мы его "уменьшаем"
        while (num > 999)
        {
            num /= 10;
        }

        //Получаем третью цифру от числа
        num %= 10;

        Console.WriteLine("Третья цифра заданного числа: " + num);
    }
    else
    {
        Console.WriteLine("В этом числе нет третьей цифры");
    }
}
try                                                                                         //Второй вариант
{
    Console.Write("Введите число: ");

    int number = int.Parse(Console.ReadLine());

    //Передаем методу модуль числа
    secondNumber(Math.Abs(number));
}
catch(Exception)
{
    //Используем TryCatch для того чтобы выдавал нужное сообщение а не ошибку
    Console.WriteLine("Это не число или оно слишком большое или слишком маленькое, попробуйте еще раз");
}

//-------------------------------------------------------------------------------------------------------------------------------