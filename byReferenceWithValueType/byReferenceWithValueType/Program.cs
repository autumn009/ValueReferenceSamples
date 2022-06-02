DateTime d = new DateTime(2023, 1, 1);
Console.WriteLine($"d={d.ToShortDateString()}");
sub(ref d);
Console.WriteLine($"d={d.ToShortDateString()}");

void sub(ref DateTime t)
{
    Console.WriteLine($"t={t.ToShortDateString()}");
    t = t.AddDays(1);
    Console.WriteLine($"t={t.ToShortDateString()}");
}

