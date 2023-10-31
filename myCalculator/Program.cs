using System;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;

namespace myCalculator
{
  class Program
  {
    static double AddMethod(double fno, double sno)
    {
      double sum = fno + sno;
      return sum;
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

            //feature x
            Console.WriteLine("Feature x: Subtraction");
            Console.Write("Enter first number");
            double fno_s = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nEnter second number:");
            double sno_s = Convert.ToDouble(Console.ReadLine());
            double sub = SubtractionMethod(fno_s, sno_s);
            Console.Write("\nThe subtracted value is:" + sub);
        }
  }
}