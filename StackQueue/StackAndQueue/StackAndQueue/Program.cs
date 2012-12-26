using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class Program
    {/**
* Abbreviates a string into the:
* [first letter] + [number of letters removed] + [last letter]
*
* Examples:
* internationalization => i18n
* localization => l10n
* hello => h3o
*
* @param string $str The string to abbreviate
* @return string The abbreviated string
*/
//assuming a C-style string. C# string is not the same
char[] AbbreviateString(char[] sourceString, int sourceStringLength)
{
    int charInBetween =0;
    if(sourceString == null) return null; // should throws but later on
    if(sourceStringLength < 2) return null; //
    char firstChar = sourceString[0];
    char lastChar = sourceString[sourceStringLength-1]
    for(int i =1; i < sourceStringLength -1; i++)
    {
        if(isValidChar(sourceString[i])){
           ++charInBetween;  
        }        aa
    }
    string charInBetweenString= charInBetween.ToString();
    String resultString = new String();
    resultString.append(firstChar.ToString());
    resultString.append(charInBetween);
    resultString.append(lastChar);
    return resultString.ToArray();
}

//assume ascii char
bool isValidChar(char someChar)
{
    int t = (someChar.ToLower() -(int)'a')%26);
    if(t>= 0 && t <=26)
      return true;
    else
      return false;
}


























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



        static void Main(string[] args)
        {
            StackArray _stackEmpty = new StackArray(0);
            var _item = _stackEmpty.Pop();
            _stackEmpty.Push(1);
            _item = _stackEmpty.Pop();
            //StackArray _stackNegative = new StackArray(-1);
            StackArray _stackNormal = new StackArray(1);
            var item = _stackEmpty.Pop();
            _stackEmpty.Push(1);
            _item = _stackEmpty.Pop();
            _stackEmpty.Push(2);
            _stackEmpty.Push(3);

            _item = _stackEmpty.Pop();



        }
    }
}

void print()
{
/**
* Abbreviates a string into the:
* [first letter] + [number of letters removed] + [last letter]
*
* Examples:
* internationalization => i18n
* localization => l10n
* hello => h3o
*
* @param string $str The string to abbreviate
* @return string The abbreviated string
*/
//assuming a C-style string. C# string is not the same
char[] AbbreviateString(char[] sourceString, int sourceStringLength)
{
    int charInBetween =0;
    if(sourceString == null) return null; // should throws but later on
    if(sourceStringLength < 2) return null; //
    char firstChar = sourceString[0];
    char lastChar = sourceString[sourceStringLength-1]
    for(int i =1; i < sourceStringLength -1; i++)
    {
        if(isValidChar(sourceString[i])){
           ++charInBetween;  
        }
    }
    string charInBetweenString= charInBetween.ToString();
    String resultString = new String();
    resultString.append(firstChar.ToString());
    resultString.append(charInBetween);
    resultString.append(lastChar);
    return resultString.ToArray();
}

//assume ascii char
bool isValidChar(char someChar)
{
    int t = (someChar.ToLower() -(int)'a')%26);
    if(t >= 0 && t <=26)
      return true;
    else
      return false;
}


























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
/**
* Abbreviates a string into the:
* [first letter] + [number of letters removed] + [last letter]
*
* Examples:
* internationalization => i18n
* localization => l10n
* hello => h3o
*
* @param string $str The string to abbreviate
* @return string The abbreviated string
*/
//assuming a C-style string. C# string is not the same
char[] AbbreviateString(char[] sourceString, int sourceStringLength)
{
    int charInBetween =0;
    if(sourceString == null) return null; // should throws but later on
    if(sourceStringLength < 2) return null; //
    char firstChar = sourceString[0];
    char lastChar = sourceString[sourceStringLength-1]
    for(int i =1; i < sourceStringLength -1; i++)
    {
        if(isValidChar(sourceString[i])){
           ++charInBetween;  
        }
    }
    string charInBetweenString= charInBetween.ToString();
    String resultString = new String();
    resultString.append(firstChar.ToString());
    resultString.append(charInBetween);
    resultString.append(lastChar);
    return resultString.ToArray();
}

//assume ascii char
bool isValidChar(char someChar)
{
    int t = (someChar.ToLower() -(int)'a')%26);
    if(t >= 0 && t <=26)
      return true;
    else
      return false;
}


























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
/**
* Abbreviates a string into the:
* [first letter] + [number of letters removed] + [last letter]
*
* Examples:
* internationalization => i18n
* localization => l10n
* hello => h3o
*
* @param string $str The string to abbreviate
* @return string The abbreviated string
*/
//assuming a C-style string. C# string is not the same
char[] AbbreviateString(char[] sourceString, int sourceStringLength)
{
    int charInBetween =0;
    if(sourceString == null) return null; // should throws but later on
    if(sourceStringLength < 2) return null; //
    char firstChar = sourceString[0];
    char lastChar = sourceString[sourceStringLength-1]
    for(int i =1; i < sourceStringLength -1; i++)
    {
        if(isValidChar(sourceString[i])){
           ++charInBetween;  
        }
    }
    string charInBetweenString= charInBetween.ToString();
    String resultString = new String();
    resultString.append(firstChar.ToString());
    resultString.append(charInBetween);
    resultString.append(lastChar);
    return resultString.ToArray();
}

//assume ascii char
bool isValidChar(char someChar)
{
    int t = (someChar.ToLower() -(int)'a')%26);
    if(t >= 0 && t <=26)
      return true;
    else
      return false;
}


























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

/**
* Abbreviates a string into the:
* [first letter] + [number of letters removed] + [last letter]
*
* Examples:
* internationalization => i18n
* localization => l10n
* hello => h3o
*
* @param string $str The string to abbreviate
* @return string The abbreviated string
*/
//assuming a C-style string. C# string is not the same
char[] AbbreviateString(char[] sourceString, int sourceStringLength)
{
    int charInBetween =0;
    if(sourceString == null) return null; // should throws but later on
    if(sourceStringLength < 2) return null; //
    char firstChar = sourceString[0];
    char lastChar = sourceString[sourceStringLength-1]
    for(int i =1; i < sourceStringLength -1; i++)
    {
        if(isValidChar(sourceString[i])){
           ++charInBetween;  
        }
    }
    string charInBetweenString= charInBetween.ToString();
    String resultString = new String();
    resultString.append(firstChar.ToString());
    resultString.append(charInBetween);
    resultString.append(lastChar);
    return resultString.ToArray();
}

//assume ascii char
bool isValidChar(char someChar)
{
    int t = (someChar.ToLower() -(int)'a')%26);
    if(t >= 0 && t <=26)
      return true;
    else
      return false;
}


























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
  /**
* Abbreviates a string into the:
* [first letter] + [number of letters removed] + [last letter]
*
* Examples:
* internationalization => i18n
* localization => l10n
* hello => h3o
*
* @param string $str The string to abbreviate
* @return string The abbreviated string
*/
//assuming a C-style string. C# string is not the same
char[] AbbreviateString(char[] sourceString, int sourceStringLength)
{
    int charInBetween =0;
    if(sourceString == null) return null; // should throws but later on
    if(sourceStringLength < 2) return null; //
    char firstChar = sourceString[0];
    char lastChar = sourceString[sourceStringLength-1]
    for(int i =1; i < sourceStringLength -1; i++)
    {
        if(isValidChar(sourceString[i])){
           ++charInBetween;  
        }
    }
    string charInBetweenString= charInBetween.ToString();
    String resultString = new String();
    resultString.append(firstChar.ToString());
    resultString.append(charInBetween);
    resultString.append(lastChar);
    return resultString.ToArray();
}

//assume ascii char
bool isValidChar(char someChar)
{
    int t = (someChar.ToLower() -(int)'a')%26);
    if(t >= 0 && t <=26)
      return true;
    else
      return false;
}


























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


    return (num%15 == 0);
}



}