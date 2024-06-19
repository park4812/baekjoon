int num = int.Parse(Console.ReadLine());

for(int i =0;i<num;i++)
{
    var data = Console.ReadLine().ToList();

    Console.WriteLine(data[0].ToString() + data[data.Count-1].ToString());
}
