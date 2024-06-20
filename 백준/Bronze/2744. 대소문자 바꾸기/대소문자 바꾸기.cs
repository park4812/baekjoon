string oldString = Console.ReadLine();
string newString = "";

foreach(char ch in oldString)
{
    newString += char.IsUpper(ch) ? char.ToLower(ch).ToString() : char.ToUpper(ch).ToString();
}

Console.WriteLine(newString);