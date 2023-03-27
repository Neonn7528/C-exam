void FillArray(int[] collection) //void - метод не возрашает
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);

        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //(-1)Будет указываться если элемент не найден.
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            //Добавить break; если закончить на первой найденой цифре.
        }
        index++;
    }
    return position;
}

int [] array = new int [10]; //по умолчанию 10 элементов (заполненный нулями).

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);