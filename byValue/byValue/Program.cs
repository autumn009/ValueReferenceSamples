int x = 123;
Console.WriteLine($"x={x}");
sub(x);
Console.WriteLine($"x={x}");

void sub(int y)
{
    Console.WriteLine($"y={y}");
    y++;
    Console.WriteLine($"y={y}");
}
