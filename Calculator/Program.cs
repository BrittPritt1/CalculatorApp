Console.WriteLine("A math operation: ");
char opr = Console.ReadLine()[0];

Console.WriteLine("First number: ");
float first = float.Parse(Console.ReadLine());

Console.WriteLine("Second number: ");
float second = float.Parse(Console.ReadLine());

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
