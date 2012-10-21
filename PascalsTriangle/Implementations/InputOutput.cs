using System;
using PascalsTriangle.Contracts;

namespace PascalsTriangle.Implementations
{
  public class InputOutput : IInputOutput
  {
    public void Write(string message, params object[] args)
    {
      Console.Write(message, args);
    }

    public void WriteLine(string message, params object[] args)
    {
      Console.WriteLine(message, args);
    }

    public string ReadLine()
    {
      return Console.ReadLine();
    }
  }
}