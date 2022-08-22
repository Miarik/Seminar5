int[] array1 = {1,2,3,4,5};
int[] array2 = {6,7,3,6};

int GetArrayMultiplication (int[] arr1, int[] arr2)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        for (int j = -1; j < arr2.Length; j++)
        {
           int mult = arr1[i+1] * arr2[arr2.Length-i-1];
           return mult;
        }
    }
}

Console.WriteLine(GetArrayMultiplication(array1, array2));