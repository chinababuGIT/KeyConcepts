using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class QueueArray
    {
        


--------------------------
/**
* FizzBuzz
*
* for 1 to 100,
* print "FizzBuzz" if the number is divisible by 3 and 5
* otherwise print "Fizz" if the number is divisible by 3
* otherwise print "Buzz" if the number is divisible by 5
* else print the number itself
*
* @return void
*/
void printFizzBuzz()
{
    for(int i =1; i<=100;i++)
    {
        if(isDivisibleBy3(i))
        {
            System.Console.WriteLine("Fizz");  
        }
        else
        if(isDivisibleBy5(i))
        {
            System.Console.WriteLine("Buzz");    
        } 
        else
        {
            System.Console.WriteLine(i);
        }
        
    };
}

bool isDivisibleBy3(int num)
{
    return (num%3 == 0);    
}

bool isDivisibleBy5(int num)
{
    return (num%5 ==0);
}

bool isDivisibleBy15(int num)
{   
    return (num%15 == 0);
}
    }
}
