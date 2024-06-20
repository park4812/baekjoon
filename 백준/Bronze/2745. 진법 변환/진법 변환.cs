int result = 0;

var data = Console.ReadLine().Split(' ');

var n = data[0].ToList();

int b = int.Parse(data[1]);

int v = 0;

for(int i = n.Count - 1; i >= 0; i--)
{
    int num = 0;
    if (char.IsDigit(n[i]))
    {
        num = n[i] - '0';  // '0'~'9'의 경우
    }
    else
    {
        num = n[i] - 'A' + 10;  // 'A'~'Z'의 경우
    }

    result += num * (int)Math.Pow(b,v++);

}

Console.WriteLine(result);

