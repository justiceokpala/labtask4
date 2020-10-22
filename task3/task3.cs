using System;
public class RecExercise15
{
 
 public static void Main()
	{
    int bNum,pwr;
    int result;
    Console.Write("\n\n Recursion : Calculate power of any number :\n");
	Console.Write("------------------------------------------------\n");	
     
    Console.Write(" Input the base  value : ");
    bNum = Convert.ToInt32(Console.ReadLine());
     
    Console.Write(" Input the exponent : ");
    pwr = Convert.ToInt32(Console.ReadLine());
     
    result=CalcuOfPower(bNum,pwr);//called the function CalcuOfPower
     
    Console.Write($" The value of {bNum} to the power of {pwr} is : {result} \n\n");
	}

public static int CalcuOfPower( int x,int y)
 {
  if (y == 0)
   return 1;
  else
   return x * CalcuOfPower( x, y - 1 );
 }
}