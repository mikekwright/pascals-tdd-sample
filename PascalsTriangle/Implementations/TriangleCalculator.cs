using System;
using System.Text;
using PascalsTriangle.Contracts;

namespace PascalsTriangle.Implementations
{
  public class TriangleCalculator : ITriangleCalculator
  {
    private readonly IInputOutput _io;

    public TriangleCalculator(IInputOutput io)
    {
      _io = io;
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
      if (rows < 0)
      {
        throw new ArgumentOutOfRangeException();
      }

      for (int r = 0; r <= rows; ++r)
      {
        StringBuilder line = new StringBuilder();
        for (int c = 0; c <= r; ++c)
        {
          int value = GetValueAt(r, c);
          line.AppendFormat("{0} ", value);
        }
        _io.WriteLine(line.ToString().Trim());
      }
    }
  }
}