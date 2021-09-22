using System;

class Program {
 public static void Main(string[] commandLineArguments)
    {
       while (true)
       {
         Console.Write("first operand: ");
        float firstFloat = float.Parse(Console.ReadLine());
        Console.Write("second operand: ");
        float secondFloat = float.Parse(Console.ReadLine());
        Console.Write("wich operation you choose: ");
        string operation = Console.ReadLine().ToLower();

      if ( operation == "add")
      { 
        Console.WriteLine(firstFloat + " + " + secondFloat + " = " + (Add (firstFloat, secondFloat)));
      }

      else if (operation == "substract")
      {
        Console.WriteLine(firstFloat + " - " + secondFloat + " = " + (Substract (firstFloat, secondFloat)));
      }

       else if (operation == "multiply")
      {
        Console.WriteLine(firstFloat + " * " + secondFloat + " = " + (Multiply(firstFloat, secondFloat)));
      }

       else if (operation == "divide")
      {
        Console.WriteLine(firstFloat + " / " + secondFloat + " = " + (Divide (firstFloat, secondFloat)));
      }

       else if (operation == "modulo")
      {
        Console.WriteLine(firstFloat + " - " + " ( " + firstFloat + " / " + secondFloat + " ) " + " * " + secondFloat + " = " + (Modulo (firstFloat, secondFloat)));
      }

       }
        
    }

    public static float Add (float num1, float num2)
    {
      return num1 + num2;
    }

    public static float Substract (float num1, float num2)
    {
      return num1 - num2;
    }

     public static float Multiply (float num1, float num2)
    {
      return num1 * num2;
    }

     public static float Divide (float num1, float num2)
    {
      return num1 / num2;
    }
     public static float Modulo (float num1, float num2)
    {
      return num1 % num2;
    }
}
