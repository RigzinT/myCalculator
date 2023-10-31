using System;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;

namespace myCalculator
{
  class Program
  {
        static double MultiplyMethod(double fno, double sno)
        {
            double multi = fno * sno;
            return multi;
        }
        static double AddMethod(double fno, double sno)
    {
      double sum = fno + sno;
      return sum;
    }
    static double DivMethod(double fno, double sno)
    {
         double div = fno / sno;
         return div;
    }

    static double SubtractionMethod(double fno, double sno)
    {
          double sub = fno - sno;
          return sub;
     }
    static void Main(string[] args)
    {
            double fno, sno, sum;
      Console.Write("Enter first number:");
      fno = Convert.ToDouble(Console.ReadLine());

      Console.Write("\nEnter second number:");
      sno = Convert.ToDouble(Console.ReadLine());

      sum = AddMethod(fno,sno);
      Console.Write("\nThe Sum is:" + sum);

     //feature y
     Console.WriteLine("Division method");
     Console.Write("Enter first number:");
     double fno_div = Convert.ToDouble(Console.ReadLine());

     Console.Write("\nEnter second number:");
     double sno_div = Convert.ToDouble(Console.ReadLine());

     double div = AddMethod(fno_div, sno_div);
     Console.Write("\nThe Sum is:" + div);

     //feature x
     Console.WriteLine("Feature x: Subtraction");
     Console.Write("Enter first number");
     double fno_s = Convert.ToDouble(Console.ReadLine());
     Console.Write("\nEnter second number:");
     double sno_s = Convert.ToDouble(Console.ReadLine());
     double sub = SubtractionMethod(fno_s, sno_s);
     Console.Write("\nThe subtracted value is:" + sub);
        
     ///feature z
      Console.Write("Multiplicatioin:");
      Console.Write("Enter first number:");
      double fno_m = Convert.ToDouble(Console.ReadLine());

      Console.Write("\nEnter second number:");
      double sno_m = Convert.ToDouble(Console.ReadLine());

      double multi = MultiplyMethod(fno_m, sno_m);
      Console.Write("\nThe multiplicaton value is:" + multi);

    }

  }
}