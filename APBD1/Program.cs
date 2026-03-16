Console.WriteLine("Hello, World!");
int[] arr = new [] { 1, 2, 3, 4, 5 };

int ArrSum(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }

    return sum;
}

Console.WriteLine("Sum equals " + ArrSum(arr));

int CalculateAverage(int[] values)
{
    return  values.Sum() / values.Length;
}