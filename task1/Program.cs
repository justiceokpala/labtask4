using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
      int value1;
	  int value2 ;
      int value3;
      int Minimum;

    
    Console.Write("please enter first number: ");
     value1 = Convert.ToInt32(Console.ReadLine());

     Console.Write("please enter first number: ");
     value2 = Convert.ToInt32(Console.ReadLine());

     Console.Write("please enter first number: ");
     value3 = Convert.ToInt32(Console.ReadLine());

	 Minimum =Math.Min(value1, Math.Min(value2, value3));
	Console.WriteLine($"The minimum of the three numbers is {Minimum}");
 
   }

}   
            

        }
    

