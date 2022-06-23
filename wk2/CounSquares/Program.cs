
using System;

class Program{

    public static int countSquares(int a, int b)
    {
        int count= (int)(Math.Sqrt(b)) - (int)(Math.Sqrt(a));  
        if(a == (int)(Math.Sqrt(a))*(int)(Math.Sqrt(a)))  
           count += 1; 
        return count;

    }
     public static void Main(string[] args)
    {
        Console.WriteLine("Enter a lower bound");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the upperbound");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The number of square intergers between " + a +"and "+ b + " is "+ countSquares(a, b));
    }

}
