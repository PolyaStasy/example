void FillArray(int[] collection) // метод который ничего не возвращает void
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index ++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int i = 0;
    while(i < count)
    {
        System.Console.WriteLine(col[i]);
        i ++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int i = -1;
    while(index < count)
    {
        if(collection[index] == find)
        {
            i = index;
            break;
        }
        index ++;
    }
    return i;
}

int[] array = new int[10]; // new int[10] - Создай новый массив из 10 элементов

FillArray(array);
array[4] = 4;
PrintArray(array);

System.Console.WriteLine();

int pos = IndexOf(array, 4);
System.Console.WriteLine(pos);