var s = "Hello!";
Console.WriteLine($"s={s}");
sub(ref s);
Console.WriteLine($"s={s}");

void sub(ref string t)
{
    Console.WriteLine($"t={t}");
    t = "Done!";
    Console.WriteLine($"t={t}");
}
