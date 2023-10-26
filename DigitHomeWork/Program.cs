string str = Console.ReadLine();
string result = String.Empty;
foreach (char item in str)
{
    if(Char.IsDigit(item))
    {
        if (!result.Contains(item))
        {
            result = result + item;
        }
    }
}
if (result == String.Empty)
{
    result = "NO";
}
Console.WriteLine(result);