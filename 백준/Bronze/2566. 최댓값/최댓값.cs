int max = -1;
int x = -1;
int y = -1;
for(int i = 1; i < 10; i++)
{
    var data = Console.ReadLine().Split(' ');

    for (int j = 1; j < 10; j++)
    {
        var num = int.Parse(data[j-1]);

        if (num > max)
        {
            max = num;
            x = i;
            y = j;
        }

    }
}

Console.WriteLine(max);
Console.WriteLine(x + " " + y);