int[] array = {1, 12, 34, 4, 24, 56, 73, 1, 89, 51};

int n = array.Length;
int find = 1;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        System.Console.WriteLine(index);
        break; // чтобы не выводить номера всех соотвествующих чисел
    }
    index ++;
}