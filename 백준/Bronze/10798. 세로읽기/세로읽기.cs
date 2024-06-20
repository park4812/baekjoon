var dic = new Dictionary<int, string>();

int maxSize = 0;
for(int i = 0; i < 5; i++)
{
    var data = Console.ReadLine().ToList();
    
    if(maxSize < data.Count)
        maxSize = data.Count;

    for (int j = 0; j < data.Count; j++)
    {
        if(!dic.ContainsKey(j))
            dic.Add(j, data[j].ToString());
        else
            dic[j] += data[j].ToString();
    }

}

for (int i = 0;i < maxSize; i++)
{
    Console.Write(dic[i]);
}
