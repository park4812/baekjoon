List<int> ints = new List<int>();
for (int i = 1; i <= 30; i++)
{
    ints.Add(i);
}

for (int i = 0; i < 28; i++)
{
    var a = int.Parse( Console.ReadLine());

    ints.Remove(a);
}

Console.WriteLine(ints[0]);
Console.WriteLine(ints[1]);
