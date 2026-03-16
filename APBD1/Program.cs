Console.WriteLine("Hello, World!");
int[] arr = new [] { 1, 2, 3, 4, 5 };

int ArraySumming(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }

    return sum;
}

Console.WriteLine("Sum equals " + ArraySumming(arr));

int CalculateAverage(int[] values)
{
    return  values.Sum() / values.Length;
}

int CalculateMax(int[] values)
{
    return values.Max();
}

int  CalculateMin(int[] values)
{
    return values.Min();
}