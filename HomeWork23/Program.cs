//------------------Задача 23--------------------
//----------Вывод кубов чисел от 1 до N----------
//-----------------------------------------------

// string? inputLineN = Console.ReadLine();

// if (inputLineN != null)
// {
//     int numberN = int.Parse(inputLineN);

//     string lineN = "";
//     string lineNNN = string.Empty;                                  //Первый вариант, это просто немного измененный вариант с семинара
//     int s = 1;

//     while(s <= numberN)
//     {
//         lineN = lineN + s +  " ";
//         lineNNN  = lineNNN + Math.Pow(s, 3).ToString() + " ";
//         s++;
//     }

//     Console.WriteLine(lineN);
//     Console.WriteLine(lineNNN);
// }

//-------------------------------------------------------------------------------------------------------------------------------

// string? inputLineN = Console.ReadLine();

// if (inputLineN != null)
// {
//     int numberN = int.Parse(inputLineN);

//     //проверяем введенное число
//     if(numberN > 0)
//     {

//         string lineN = "";
//         string lineNNN = string.Empty + "";                                                      //Второй вариант, с выводом таблицы по горизонтали
//         int s = 1;
//         string border = "";

//         while(s <= numberN)
//         {
//             border = border + "-------\t";
//             lineN = lineN + s + "\t|";
//             lineNNN  = lineNNN + Math.Pow(s, 3).ToString() + "\t|";
//             s++;
//         }

//         Console.WriteLine(border);
//         Console.WriteLine("|" + lineN);
//         Console.WriteLine(border);
//         Console.WriteLine("|" + lineNNN);
//         Console.WriteLine(border);
//     }
//     else
//     {
//         Console.WriteLine("Число должно быть равно 1 или больше");
//     }
// }

//-------------------------------------------------------------------------------------------------------------------------------

string? inputLineN = Console.ReadLine();

if (inputLineN != null)
{
    int numberN = int.Parse(inputLineN);

    //проверяем введенное число
    if(numberN > 0)
    {
        string lineN = "";
        string lineNNN = string.Empty;                                                      //Третий вариант, с выводом таблицы по вертикали
        int s = 1;
        string border = "";

        // \t создает новый столбец в терминале, и после \t символы будут находиться в новом столбце
        while(s <= numberN)
        {
            Console.WriteLine("-------\t---------\t");

            lineN = s + "";
            Console.Write("|" + lineN + "\t");

            lineNNN  = Math.Pow(s, 3).ToString();
            Console.WriteLine("|" + lineNNN + "\t|");

            s++;
        }
        
        Console.WriteLine("-------\t---------\t");
    }
    else
    {
        Console.WriteLine("Число должно быть равно 1 или больше");
    }
}

//-------------------------------------------------------------------------------------------------------------------------------