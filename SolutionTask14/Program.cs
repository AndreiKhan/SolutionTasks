//вариант 1
string reminderSearcher(string str)
{
    if (str != null)
    {
        string answer = "";
        int num = int.Parse(str);
        if ((num % 7 == 0) && (num % 23 == 0))
        {
            answer = "кратно 7 и 23";
        }
        else
        {
            answer = "не кратно 7 и 23";
        }
        return answer;
    }
        return "";
}

string? inputOne = Console.ReadLine();

Console.WriteLine(reminderSearcher(inputOne));