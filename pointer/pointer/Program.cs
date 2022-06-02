unsafe
{
    int a = 123;
    Console.WriteLine($"a={a}");
    sub(&a);
    Console.WriteLine($"a={a}");
}

unsafe void sub(int * p)
{
    Console.WriteLine($"*p={*p}, p={(nint)p}");
    (*p)++;
    Console.WriteLine($"*p={*p}, p={(nint)p}");
}
