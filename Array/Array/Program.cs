int[] array = new int[100];

array[87] = 123;
sub(87);

void sub(int index)
{
    Console.WriteLine($"array[{index}]={array[index]}");
}


