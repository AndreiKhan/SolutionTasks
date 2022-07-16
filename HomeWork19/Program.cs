//-------------------------Задача 19-------------------------
//---------Является ли пятизначное число палиндромом---------
//-----------------------------------------------------------

// void fiveDigitNumbers(int number)
// {
//     if(number >= 10000 && number <= 100000)
//     {
//         int d1 = number / 10000;
//         int d2 = (number / 1000) % 10;
//         int d4 = (number / 10) % 10;
//         int d5 = number % 10;

//         palindrome(d1, d2, d4, d5);
//     }
//     else
//     {
//         Console.WriteLine("Это не пятизначное число");
//     }
// }

// void palindrome(int n1, int n2, int n4, int n5)
// {
//     if (n1 == n5 && n2 == n4)
//     {
//         Console.WriteLine("Это палиндром");
//     }
//     else
//     {
//         Console.WriteLine("Это не палиндром");
//     }
// }

// try                                                                         //Первый вариант
// {
//     Console.WriteLine("Введите пятизначное число: ");
//     int inputNumber = int.Parse(Console.ReadLine());

//     fiveDigitNumbers(inputNumber);
// }
// catch(Exception)
// {
//     Console.WriteLine("Это не число");
// }

//-------------------------------------------------------------------------------------------------------------------------------

//Создаем словарь в котором  будут палиндромы
Dictionary<int, string> palindromes = new Dictionary<int, string>();
int key = 1;

//Заполняем наш словарь палиндромами
for(int i = 1; i <= 9; i++)
{
    for(int s = 0; s <= 9; s++)
    {
        key = int.Parse(i.ToString() + s.ToString() + s.ToString() + i.ToString());
        palindromes[key] = key.ToString();
    }

}

//Создаем метод который проверит является ли введенное число палиндромом
void palindromeDefinition(string fiveNumbers, int digits)
{
    if(palindromes.ContainsValue(fiveNumbers))
    {
        Console.WriteLine(digits + " - Это палиндром");
    }
    else
    {
        Console.WriteLine(digits + " - Это не палиндром");
    }
}

try                                                                         //Второй вариант
{
    Console.Write("Введите пятизначное число: ");
    
    string fiveDigits = Console.ReadLine();

    char[] charNumber = fiveDigits.ToCharArray();
    int inputNumber = int.Parse(fiveDigits);

    //Проверяем введенное число
    if(charNumber.Length == 5)
    {
        //Создаем переменную которая будет содержать в себе две первых и две послледние цифры  введенного числа
        string num = charNumber[0].ToString() + charNumber[1].ToString() + charNumber[3].ToString() + charNumber[4].ToString();

        //Передаем  методу введенное число и ключ
        palindromeDefinition(num, inputNumber);
    }
    else
    {
        Console.WriteLine("Это не пятизначное число");
    }
}
catch(Exception)
{
    Console.WriteLine("Это не число");
}

//-------------------------------------------------------------------------------------------------------------------------------