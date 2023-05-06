
// see võttis pikalt aega minul ning kasutasin vigade leidmiseks ka abimeest.

Console.WriteLine("Enter temputure: ");
int tempNum = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter F for fahrenheit or C for celsius: ");
char argumente = char.Parse(Console.ReadLine());
argumente = char.ToUpper(argumente);



if(argumente == 'F')
{
    PrintConverToCelsius(argumente, tempNum);
}
else if(argumente == 'C')
{
    PrintConvertToFahrenheit(argumente, tempNum);
}
else
{
    Console.WriteLine("Invalid input");
}

static void PrintConverToCelsius (char argumente, int tempNum)
{
    if (argumente == 'F')
    {
        double c = tempNum * 9 / 5 + 32;
        Console.WriteLine($"Your temputer is in Celsius: {c}");
            }
}
static void PrintConvertToFahrenheit (char argumente, int tempNum)
{
    if (argumente == 'C')
    {
        double f = (tempNum - 32) * 5 / 9;
        Console.WriteLine($"Your temputer is in fahrenheit: {f}");
    }
}
