var s = "Hello!";
Console.WriteLine($"s={s}");
sub(s);
Console.WriteLine($"s={s}");

void sub(string t)
{
    Console.WriteLine($"t={t}");
    t = "Done!";
    Console.WriteLine($"t={t}");
}
