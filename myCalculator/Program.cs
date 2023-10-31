using System;
using System.Diagnostics.CodeAnalysis;

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

    static void Main(string[] args)
    {
            double fno, sno, sum;
      Console.Write("Enter first number:");
      fno = Convert.ToDouble(Console.ReadLine());

      Console.Write("\nEnter second number:");
      sno = Convert.ToDouble(Console.ReadLine());

      sum = AddMethod(fno,sno);
      Console.Write("\nThe Sum is:" + sum);

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