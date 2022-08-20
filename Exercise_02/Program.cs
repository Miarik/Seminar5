int[] array = {6,7,19,345,3};

bool FindNumber (int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) {
            return true;
        }
    }
    return false;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

bool result = FindNumber(array, number);
Console.WriteLine(result);