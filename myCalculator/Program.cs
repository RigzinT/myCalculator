using System;
using System.Diagnostics.CodeAnalysis;

namespace myCalculator
{
  class Program
  {
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
    }
  }
}