// See https://aka.ms/new-console-template for more information
Console.WriteLine("hello world!");

int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

for (int i = 0; i < arr.Length - 1; i++)
{
    for (int j = 0; j < arr.Length - i - 1; j++)
    {
        if (arr[j] > arr[j + 1])
        {
            int temp = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = temp;
        }
    }
}

Console.WriteLine("Sorted array:");
foreach (int num in arr)
{
    Console.Write(num + " ");
}

