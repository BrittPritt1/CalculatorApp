using System.Globalization;

char opr;

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

/* while (true)
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
} */

float result = 0.0f, n1, n2;

//1 read files 1.txt and 2.txt (array of numbers)
string[] lines1 = File.ReadAllLines("/Users/brittbreugelmans/Downloads/1.txt");
string[] lines2 = File.ReadAllLines("/Users/brittbreugelmans/Downloads/2.txt");

//2 apply operation on numbers of each file + store in new file result.txt
using(StreamWriter writer = new StreamWriter("/Users/brittbreugelmans/Downloads/result.txt"))
{
    for (int i = 0; i < lines1.Length; i++)
    {
        n1 = float.Parse(lines1[i]);
        Console.WriteLine($"first file: {lines1[i]}");

        n2 = float.Parse(lines2[i]);
        Console.WriteLine($"second file: {lines2[i]}");

        switch (opr)
        {
            case '+' :
                result = n1 + n2;
                Console.WriteLine(result);
                break;

            case '-' :
                result = n1 - n2;
                break;

            case '*' : 
                result = n1 * n2;
                break; 

            case '/': 
                result = n1 / n2;
                break;
        }

        writer.WriteLine(result);
    }
} 

Console.WriteLine("Results saved in file.");
