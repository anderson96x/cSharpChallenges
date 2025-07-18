int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
string found = "";

foreach (int number in numbers)
{
    total += number;

    if (number == 142)
    {
       found = "Set contains 42";
    }
}

System.Console.WriteLine(found);
Console.WriteLine($"Total: {total}");
