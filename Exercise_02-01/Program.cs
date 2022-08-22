Console.WriteLine($"Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"Введите {size} чисел через Энтер");
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Введите искомое число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindNumber(array, number));

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
    }
}
PrintArray(array);

bool FindNumber(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
        return true;
        }
    }
    return false;
}

