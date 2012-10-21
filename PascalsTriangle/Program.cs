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
      string input = io.ReadLine();
      int convertedNumber;
      if (!int.TryParse(input, out convertedNumber))
      {
        return 1;
      }

      try
      {
        triangleCalculator.PrintTriangle(convertedNumber);
      }
      catch (Exception)
      {
        return 1;
      }

      return 0;
    }
  }
}
