var value = Console.ReadLine().Split(' ');

int n = int.Parse(value[0]);

int m = int.Parse(value[1]);

int[] ints = new int[n];

for(int i =0; i < ints.Length; i++)
{
    ints[i] = i + 1;
}

for(int i = 0; i < m; i++)
{
    var line = Console.ReadLine().Split(' ');

    int a = int.Parse(line[0]);
    int b = int.Parse(line[1]);

    int cnt = 1;

    int sum = (b - a + 1) / 2;

    for(int j = a - 1; j < a - 1 + sum; j++)
    {
        int temp = ints[j];

        ints[j] = ints[b - cnt];

        ints[b - cnt++] = temp;
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