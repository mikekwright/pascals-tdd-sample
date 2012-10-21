namespace PascalsTriangle.Contracts
{
  public interface IInputOutput
  {
    void Write(string message, params object[] args);
    void WriteLine(string message, params object[] args);
    string ReadLine();
  }
}