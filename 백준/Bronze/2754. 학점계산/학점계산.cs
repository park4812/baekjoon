string rank = Console.ReadLine();
double sum = 0;

foreach(char item in rank)
{
    switch (item)
    {
        case 'A':
            sum += 4;
            break;
        case 'B':
            sum += 3;
            break;
        case 'C':
            sum += 2;
            break;
        case 'D':
            sum += 1;
            break;
        case 'F':
            sum += 0;
            break;
        case '+':
            sum += 0.3;
            break;
        case '-':
            sum -= 0.3;
            break;
    }

}

Console.WriteLine(string.Format("{0:N1}",sum));