/*void Metod1()
{
Console.WriteLine("Автор Я");
}
Metod1();*/


/*void Metod2(string mnb)
{
    Console.WriteLine(mnb);
}
Metod2(mnb:"Текст сообщения");

void Metod21(string mnb, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(mnb);
        i++;
    }
}
Metod21(mnb: "Текст", count: 4);*/


/*int Metod3()
{
    return DateTime.Now.Year;
}
int year = Metod3();
Console.WriteLine(year);*/


string Metod4(int cout, string text)
{
    int i = 0;
    string result = string.Empty;
    while (i < cout)
    {
        result = result + text;
    }
    return result;
}
string res = Metod4(10, "r");
Console.WriteLine(res);

