char opr = '0';
float first = 0f;
float second = 0f;

while (true)
{
   try
    {
        Console.WriteLine("A math operation: ");
        opr = Console.ReadLine()[0];
        break;
    } 
    catch
    {
        Console.WriteLine("Enter a proper math operation symbol");
    } 
}

while (true)
{
    try
    {
        Console.WriteLine("First number: ");
        first = float.Parse(Console.ReadLine());
        break;
    } 
    catch
    {
        Console.WriteLine("Enter a proper number or decimal");
    }    
}

while (true)
{
    try
    {
        Console.WriteLine("Second number: ");
        second = float.Parse(Console.ReadLine());
        break;
    } 
    catch
    {
        Console.WriteLine("Enter a proper number or decimal");
    }    
}


float result = 0;

switch (opr)
{
    case '+' :
        result = first + second;
        break;

    case '-' :
        result = first - second;
        break;

    case '*' : 
        result = first * second;
        break; 

    case '/': 
        result = first / second;
        break;
}

Console.WriteLine($"The result of '{first} {opr} {second}' is: {result}");
