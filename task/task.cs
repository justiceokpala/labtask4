using System;

namespace task
{

    class Task 
  { 
  
        // Function to return the hypotenuse  
         // of the right angled triangle 
       public double findHypotenuse(double side1, 
                                 double side2) 
      { 
        double h = Math.Sqrt((side1 * side1) +  
                             (side2 * side2)); 
        return h; 
      } 
  
}

}