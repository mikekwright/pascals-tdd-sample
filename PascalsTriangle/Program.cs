using System;
using PascalsTriangle.Contracts;
using PascalsTriangle.Implementations;

namespace PascalsTriangle
{
  class Program
  {
    static int Main(string[] args)
    {
      IInputOutput io = new InputOutput();
      ITriangleCalculator triangleCalculator = new TriangleCalculator(io);

      return RunProgram(io, triangleCalculator);
    }

    public static int RunProgram(IInputOutput io, ITriangleCalculator triangleCalculator)
    {
      throw new NotImplementedException();
    }
  }
}
