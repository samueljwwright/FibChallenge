// See https://aka.ms/new-console-template for more information
using System.Diagnostics;


//fib sequence
// a + b = c , b + c = d 

//last nums
long a = 0, b = 1; //Changed from int to long 

//a 
//b = n; 
//a 

//keeps track of func calls -> without stack overflow with no counter
int counter = 0;

FibSequene(0);
void FibSequene(long n)
{
    if (counter < 101) // n  < 1000 (use to stop mem leaks endless recursion)
    {
        a = b;
        b = n;
        n = a + b;
        counter++;
        Console.WriteLine(n);

        FibSequene(n);
    }

}