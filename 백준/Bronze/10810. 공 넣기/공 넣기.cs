var value = Console.ReadLine().Split(' ');

int n = int.Parse(value[0]);

int m = int.Parse(value[1]);

int[] ints = new int[n];

for(int i = 0; i < m; i++)
{
    var line = Console.ReadLine().Split(' ');

    int a = int.Parse(line[0]);
    int b = int.Parse(line[1]);
    int c = int.Parse(line[2]);

    for (int j = a - 1; j < b; j++)
    {
        ints[j] = c;
    }

}

for (int i = 0;i < ints.Length;i++)
{
    int result = ints[i];
    if (i == ints.Length - 1)
        Console.WriteLine(result);
    else
        Console.Write(result + " ");
}