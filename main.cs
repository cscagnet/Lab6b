using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {

//Loop 10 times:
//Get numbers as input
//If number is odd, store in an array called OddNum.
//If number is even, store in an array called EvenNum.
//Display OddNum array in descending order
//Display EvenNum array in ascending order
//Find sum of OddNum array and display sum.
//Find sum of EvenNum array and display sum.//

int[] number = new int[10];

for(int counter=0; counter <=9; counter++)
{
  Console.WriteLine("Enter number");
  number [counter] = Convert.ToInt32(Console.ReadLine());
}
foreach (int item in number)
{ 
if (item % 2 == 0)  
  {  
  Console.WriteLine (item + "is Even Number");
  }  
else  
  {  
  Console.WriteLine(item + " is Odd number"); 
  }
}
Array.Sort(number);
for(int counter=0; counter <=9; counter++)
  {
    Console.WriteLine(number[counter]);
  }
Array.Reverse(number);
for(int counter=0; counter <=9; counter++)
  {
    Console.WriteLine(number[counter]);
  }
int sum = number.Sum();
  Console.WriteLine("Sum = " + sum);
  }
}