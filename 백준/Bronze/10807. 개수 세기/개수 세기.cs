var cnt = int.Parse(Console.ReadLine().ToString());


var values = Console.ReadLine().Split(' ');

var searchValue = Console.ReadLine();

int searchCount = 0;

foreach(var value in values)
{
    if(searchValue == value)
        searchCount++;
}

Console.WriteLine(searchCount);