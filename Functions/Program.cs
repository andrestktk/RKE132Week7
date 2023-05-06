
Console.WriteLine("Are you coming or leaving? (in/out)");
string userChoice = Console.ReadLine();

if (userChoice == "in" )
{
    PrintHello();
}
else
{
    PrintGoodBye();
}


//PrintHello();  // go on function
//PrintGoodBye();
static void PrintHello() // function / method
{
    Console.WriteLine("Hello, world!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later, alicator!");
}
