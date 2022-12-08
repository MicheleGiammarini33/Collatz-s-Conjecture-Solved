// See https://aka.ms/new-console-template for more information
using System.Numerics;
Console.WriteLine("Hello, World!");


BigInteger alfa = BigInteger.Pow(2, 10);

for (BigInteger i = alfa; false == false; i = i + 1)
{
    BigInteger p =0;
    BigInteger d = 0;
    var response = i;
    BigInteger result = i;
    do
    {
        if (result % 2 == 0)
        {
            p = p+1;
            result = result / 2;
        }
        else
        {
            d = d+1;
            if (d == 239020)
            {
                char c = '0'; ;
            }
            result = result * 3 + 1;
            if(result == 16){
                char c = '0'; ;
            }
        }
       
    } while (result != 4);
    Console.WriteLine(p);
    Console.WriteLine(d);
    Console.WriteLine($"{response}");
    Console.WriteLine($"------------------------------------");
}
