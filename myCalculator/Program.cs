using System;

namespace myCalculator
{
  public class Program
  {
   public static double MultiplyMethod(double fno, double sno)
    {
       double multi = fno * sno;
       return multi;
    }
    public static double AddMethod(double fno, double sno)
    {
      double sum = fno + sno;
      return sum;
    }
    public static double DivMethod(double fno, double sno)
    {
         double div = fno / sno;
         return div;
    }
    public static double SubtractionMethod(double fno, double sno)
    {
          double sub = Convert.ToInt32(fno - sno);
          double roundedSub = Math.Round(sub, 1);
          return roundedSub;
     }
     static void Main(string[] args)
    {
      //Addition method
      double fno, sno, sum;
      Console.Write("Enter first number:");
      fno = Convert.ToDouble(Console.ReadLine());

      Console.Write("\nEnter second number:");
      sno = Convert.ToDouble(Console.ReadLine());

      sum = AddMethod(fno,sno);
      Console.Write("\nThe Sum is:" + sum);

     //feature y division
     Console.WriteLine("\nDivision method");
     Console.Write("Enter first number:");
     double fno_div = Convert.ToDouble(Console.ReadLine());

     Console.Write("\nEnter second number:");
     double sno_div = Convert.ToDouble(Console.ReadLine());

     double div = DivMethod(fno_div, sno_div);
     Console.Write("\nThe Sum is:" + div);

     //feature x subtration
     Console.WriteLine("\nFeature x: Subtraction");
     Console.Write("Enter first number");
     double fno_s = Convert.ToDouble(Console.ReadLine());
     Console.Write("\nEnter second number:");
     double sno_s = Convert.ToDouble(Console.ReadLine());
     double sub = SubtractionMethod(fno_s, sno_s);
     Console.Write("\nThe subtracted value is:" + sub);
        
     ///feature z multiplication
      Console.Write("\nMultiplicatioin:");
      Console.Write("\nEnter first number:");
      double fno_m = Convert.ToDouble(Console.ReadLine());

      Console.Write("\nEnter second number:");
      double sno_m = Convert.ToDouble(Console.ReadLine());

      double multi = MultiplyMethod(fno_m, sno_m);
      Console.Write("\nThe multiplicaton value is:" + multi);

    }
  }
}