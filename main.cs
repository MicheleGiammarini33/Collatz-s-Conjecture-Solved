// See https://aka.ms/new-console-template for more information
using System.Numerics;
Console.WriteLine("Hello, World!");


BigInteger alfa = BigInteger.Pow(2, 100000);

for (BigInteger i = alfa; false == false; i = i + 1)
{
    var response = i;
    BigInteger result = i;
    do
    {
        if (result % 2 == 0)
        {
            result = result / 2;
        }
        else
        {
            result = result * 3 + 1; 
        }

    } while (result != 4);
    Console.WriteLine($"{response}");
    Console.WriteLine($"------------------------------------");
}
