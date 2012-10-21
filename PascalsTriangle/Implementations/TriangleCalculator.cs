using System;
using PascalsTriangle.Contracts;

namespace PascalsTriangle.Implementations
{
  public class TriangleCalculator : ITriangleCalculator
  {
    public TriangleCalculator(IInputOutput io)
    {
    }

    public int GetValueAt(int row, int column)
    {
      if (((row < 0) || (column < 0)) || (column > row))
      {
        throw new ArgumentOutOfRangeException();
      }

      if ((column == 0) || (row == column))
      {
        return 1;
      }

      return GetValueAt(row - 1, column) + GetValueAt(row - 1, column - 1);
    }

    public void PrintTriangle(int rows)
    {
      throw new System.NotImplementedException();
    }
  }
}