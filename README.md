# Collatz-s-Conjecture-Solved

Collatz's conjecture is a problem in mathematics that asks whether a particular algorithm will always eventually reach the number 1, regardless of the starting integer. The algorithm in question is simple: if the current number is even, divide it by 2, and if it is odd, multiply it by 3 and add 1. This process is repeated over and over again until the number reaches 1.

While the conjecture has been tested for many integers and has yet to be disproved, no one has been able to prove that it is true for all integers. However, it is possible to write a program that can test the conjecture for very large integers. In this case we are going to write a program in C# that can solve the Collatz Conjecture for large integers.

C# provides a built-in class called "System.Numerics.BigInteger" for working with large integers. The class provides a variety of methods for performing mathematical operations on large integers, such as addition, subtraction, multiplication, and division. It also provides methods for comparing and manipulating large integers.

Here is an example of a program written in C# using the "System.Numerics.BigInteger" class to solve Collatz Conjecture for large integers:


using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer: ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        int steps = 0;
        while (n != 1)
        {
            if (BigInteger.Remainder(n, 2) == 0)
            {
                n /= 2;
            }
            else
            {
                n = n * 3 + 1;
            }
            steps++;
        }

        Console.WriteLine("Reached 1 in {0} steps.", steps);
    }
}
This program prompts the user for an integer, stores it in a BigInteger type variable, and then uses a while loop to repeatedly apply the Collatz algorithm until the number reaches 1. The BigInteger.Remainder method is used to check if the number is even, and the assignment operator is used to perform the appropriate operations for the Collatz algorithm. The program prints out the number of steps taken to reach 1.

It should be noted that, as previously mentioned, the conjecture is not proved for all integers, but this program can be used to test the conjecture for large integers.

In this example we are using the BigInteger.Parse method to convert the input from the console to a BigInteger. The BigInteger.Remainder method is used to check if the number is even, and the assignment operator is used to perform the appropriate operations for the Collatz algorithm. The program prints out the number of steps taken to reach 1.

It's important to notice that the execution time of this program increases with the size of the input number, but it will give correct results for any input size. Also, it should be noted that this program is not an efficient solution to the Collatz Conjecture problem as it's not able to prove the conjecture but just test it.

In conclusion, Collatz's conjecture is a problem in mathematics that remains unproven, and it's possible to write a program in C# using the "System.Numerics.BigInteger" class to test the conjecture for large integers. This program is not an efficient solution but it will give correct results for any input size.


Collatz's conjecture, also known as the 3x + 1 problem, is a problem in mathematics that asks whether a particular algorithm will always eventually reach the number 1, regardless of the starting integer. The algorithm in question is simple: if the current number is even, divide it by 2, and if it is odd, multiply it by 3 and add 1. This process is repeated over and over again until the number reaches 1.

While the conjecture has been tested for many integers and has yet to be disproved, no one has been able to prove that it is true for all integers. The Collatz Conjecture has been a subject of ongoing research for decades, and it's still an unsolved problem. However, it is possible to write a program that can test the conjecture for very large integers.

In this case, we will be using C# as the programming language and the "System.Numerics.BigInteger" class to solve the Collatz Conjecture for large integers. C# provides a built-in class called "System.Numerics.BigInteger" for working with large integers. The class provides a variety of methods for performing mathematical operations on large integers, such as addition, subtraction, multiplication, and division. It also provides methods for comparing and manipulating large integers.

The program starts by prompting the user for an integer, using the Console.WriteLine and Console.ReadLine methods. The input from the console is then converted to a BigInteger using the BigInteger.Parse method. This allows us to work with large integers that may have an arbitrarily large number of digits.

The program then uses a while loop to repeatedly apply the Collatz algorithm until the number reaches 1. The BigInteger.Remainder method is used to check if the number is even, and the assignment operator is used to perform the appropriate operations for the Collatz algorithm. The program keeps track of the number of steps taken to reach 1 using a variable called "steps".

Once the number reaches 1, the program prints out the number of steps taken to reach 1 using the Console.WriteLine method.

It should be noted that, as previously mentioned, the conjecture is not proved for all integers, but this program can be used to test the conjecture for large integers. However, this program is not an efficient solution to the Collatz Conjecture problem as its execution time increases with the size of the input number, making it impractical to test the conjecture for extremely large integers. Additionally, it should be noted that this program is not able to prove the conjecture, but it can only test it.

In conclusion, Collatz's conjecture is a problem in mathematics that remains unproven, and it's possible to write a program in C# using the "System.Numerics.BigInteger" class to test the conjecture for large integers. This program is not an efficient solution and it can't prove the conjecture but it will give correct results for any input size. Despite the progress made in understanding the conjecture and the large number of integers that have been tested, the Collatz Conjecture remains one of the most mysterious unsolved problems in mathematics.
