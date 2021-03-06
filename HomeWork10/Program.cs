//-------------------------Задача 10------------------------
//-----Принимает трехзначное число и выводит вторую цифру---
//----------------------------------------------------------

//-------------------------------------------------------------------------------------------------------------------------------

// Console.Write("Введите трехзначное число: ");                                               //Первый вариант

// //Создаем метод нахождения второй цифры из трехзначного числа
// void secondNumber(int num)
// {
//     //Проверяем трехзначное ли это число
//     if ((999 >= num) && (num >= 100))
//     {
//         num = (num % 100) / 10;
//         Console.WriteLine("Вторая цифра из трехзачного числа: " + num);
//     }
//     else
//     {
//         Console.WriteLine("Это не трехзначное число");
//     }
// }
// try
// {
//     int number = int.Parse(Console.ReadLine());

//     //Передаем методу модуль числа методу
//     secondNumber(Math.Abs(number));
// }
// catch(Exception)
// {
//     //Используем TryCatch для того чтобы выдавал нужное сообщение а не ошибку
//     Console.WriteLine("Это не трехзначное число");
// }

//-------------------------------------------------------------------------------------------------------------------------------

Console.Write("Введите трехзачное число: ");                                                    //Второй вариант

//Создаем метод нахождения второй цифры из трехзначного числа
void secondNumber(string inp)
{
    //переводим полученный string в char
    char[] charNumber = inp.ToCharArray();

    //Проверяем треххзначное ли это число
    if (charNumber.Length == 3)
    {
        Console.WriteLine("Вторая цифра из трехзачного числа: " + charNumber[1]);
    }
    else
    {
        Console.WriteLine("Это не трехзначное число");
    }
}

try
{
    string inputNumber = Console.ReadLine();

    //Переводим полученную строку в int, чтобы выявить ошибку, если были введены цифры то все пройдет нормально
    int number = int.Parse(inputNumber);

    //Проверяем отрицательное ли число
    if (number < 0)
    {   
        //Если отрицательно то получаем его модуль
        number = Math.Abs(number);
        string absNumber = number.ToString();

        //Передаем методу модуль числа
        secondNumber(absNumber);
    }
    else
    {
        secondNumber(inputNumber);
    }
}
catch(Exception)
{
    //Используем TryCatch для того чтобы выдавал нужное сообщение а не ошибку
    Console.WriteLine("Это не трехзначное число");
}

//-------------------------------------------------------------------------------------------------------------------------------
