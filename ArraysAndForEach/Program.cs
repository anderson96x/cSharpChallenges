int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int binCount = 1;

foreach (int items in inventory)
{
    sum += items;
    System.Console.WriteLine($"Bin {binCount} = {items} items (Running total: {sum})");
    binCount++;
}
System.Console.WriteLine($"We have {sum} items in inventory.");