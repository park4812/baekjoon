int[,] array = new int[100, 100];
int result = 0;

int cnt = int.Parse(Console.ReadLine());

for (int i = 0; i < cnt ; i++)
{
    var data = Console.ReadLine().Split(' ');

    int x = int.Parse(data[0]) - 1;
    int y = int.Parse(data[1]) - 1;

    for(int j = x; j < x + 10; j++)
    {
        for(int k = y; k < y + 10; k++)
        {
            array[j, k] = 1;
        }
    }
}


for (int i = 0; i < 100; i++)
{
    for (int j = 0; j < 100; j++)
    {
        if (array[i, j] == 1)
            result++;
    }
}

Console.WriteLine(result);