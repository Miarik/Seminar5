int[] array = new int[123];

int[] FillArray (int[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(0,200);
    }
    return arr;
} 

void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
    }
    Console.WriteLine();
}
int[] arr = FillArray(array);
PrintArray(arr);

int FindElementQuantitity(int[] arr)
{
    int count = 0;
    for (int i = 10; i < 99; i++)
    {
        count ++;
    }
    return count;
}

Console.WriteLine(FindElementQuantitity(arr));