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

    int a = int.Parse(line[0]) - 1;
    int b = int.Parse(line[1]) - 1;

    int temp = ints[a];

    ints[a] = ints[b];
    ints[b] = temp;

}

for (int i = 0;i < ints.Length;i++)
{
    int result = ints[i];
    if (i == ints.Length - 1)
        Console.WriteLine(result);
    else
        Console.Write(result + " ");
}