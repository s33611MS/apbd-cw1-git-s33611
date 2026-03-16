Console.WriteLine("Hello, World!");

void fun(int[] arr)
{
    foreach (var v in arr)
    {
        Console.WriteLine(v);
    }
}

int[] arr = new [] { 1, 2, 3, 4, 5 };
fun(arr);