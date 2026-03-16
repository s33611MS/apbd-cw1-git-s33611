Console.WriteLine("Hello, World!");

void Fun(int[] arr)
{
    foreach (var v in arr)
    {
        Console.WriteLine(v);
    }
}

int[] arr = new [] { 1, 2, 3, 4, 5 };
Fun(arr);

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