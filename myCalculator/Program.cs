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
    static double DivMethod(double fno, double sno)
    {
         double div = fno / sno;
         return div;
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


     Console.WriteLine("Division method");
     Console.Write("Enter first number:");
     double fno_div = Convert.ToDouble(Console.ReadLine());

     Console.Write("\nEnter second number:");
     double sno_div = Convert.ToDouble(Console.ReadLine());

     double div = AddMethod(fno_div, sno_div);
     Console.Write("\nThe Sum is:" + div);
    }
  }
}