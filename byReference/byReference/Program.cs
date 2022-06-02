int x = 123;
Console.WriteLine($"x={x}");
sub(ref x);
Console.WriteLine($"x={x}");

void sub(ref int y)
{
    Console.WriteLine($"y={y}");
    y++;
    Console.WriteLine($"y={y}");
}
