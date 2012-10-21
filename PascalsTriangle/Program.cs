using System;
using PascalsTriangle.Contracts;
using PascalsTriangle.Implementations;

namespace PascalsTriangle
{
  public class Program
  {
    static int Main(string[] args)
    {
      IInputOutput io = new InputOutput();
      ITriangleCalculator triangleCalculator = new TriangleCalculator(io);

      return RunProgram(io, triangleCalculator);
    }

    public static int RunProgram(IInputOutput io, ITriangleCalculator triangleCalculator)
    {
      io.Write("Enter the number of rows to print: ");
      string input = io.ReadLine();
      int convertedNumber;
      if (!int.TryParse(input, out convertedNumber))
      {
        io.WriteLine("Sorry, '{0}' is not a valid number.", input);
        return 1;
      }

      try
      {
        triangleCalculator.PrintTriangle(convertedNumber);
      }
      catch (Exception e)
      {
        io.WriteLine("Error running program: {0}", e.Message);
        return 1;
      }

      return 0;
    }
  }
}
