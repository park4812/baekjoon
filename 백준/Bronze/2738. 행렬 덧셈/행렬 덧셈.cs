var data = Console.ReadLine().Split(' ');

int n = int.Parse(data[0]);
int m = int.Parse(data[1]);

Dictionary<string, int> sumDic = new Dictionary<string, int>();

for (int i =0; i< n * 2; i++)
{
    var values = Console.ReadLine().Split(' ');

    for(int j = 0; j < m; j++)
    {
        string name = (i % n) + "-" + j;
        int value = int.Parse(values[j]);
        if (!sumDic.ContainsKey(name))
            sumDic.Add(name, value);
        else
            sumDic[name] += value;
    }
}


for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        string name = (i % n) + "-" + j;

        if (j == m - 1)
            Console.WriteLine(sumDic[name]);
        else
            Console.Write(sumDic[name] + " ");
    }
}