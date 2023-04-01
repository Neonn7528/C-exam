//FOR
/*string Metod4(int cout, string text)
{
    string result = string.Empty;
    for( int i = 0; i < cout; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Metod4(10, "r");
Console.WriteLine(res);*/

//WHILE
string Metod4(int cout, string text)
{
    int i = 0;
    string result = string.Empty;
    while (i < cout)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Metod4(10, "r");
Console.WriteLine(res);