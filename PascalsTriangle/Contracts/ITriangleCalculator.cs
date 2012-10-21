namespace PascalsTriangle.Contracts
{
  public interface ITriangleCalculator
  {
    int GetValueAt(int row, int column);
    void PrintTriangle(int rows);
  }
}