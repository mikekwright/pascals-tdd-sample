using System;
using NUnit.Framework;
using PascalsTriangle.Contracts;
using PascalsTriangle.Implementations;
using Rhino.Mocks;

namespace PascalsTriangle.Tests
{
  [TestFixture]
  public class TriangleCalculatorTests
  {
    private IInputOutput _mockInputOutput;
    private ITriangleCalculator _testCalculator;

    [SetUp]
    public void SetupDependencies()
    {
      _mockInputOutput = MockRepository.GenerateMock<IInputOutput>();
      _testCalculator = new TriangleCalculator(_mockInputOutput);
    }

    [Test]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void GetValueAt_ShouldThrowArgumentOutOfRangeException_WhenRowIsNegative()
    {
      _testCalculator.GetValueAt(-1, Arg<int>.Is.Anything);
    }

    [Test]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void GetValueAt_ShouldThrowArgumentOutOfRangeException_WhenColumnIsNegative()
    {
      _testCalculator.GetValueAt(Arg<int>.Is.Anything, -1);
    }

    [Test]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void GetValueAt_ShouldThrowArgumentOutOfRangeException_WhenColumnIsGreaterThenRow()
    {
      int row = 1;
      _testCalculator.GetValueAt(row, row + 1);
    }

    [Test]
    public void GetValueAt_ShouldReturnOne_WhenColumnIsZeroAndRowIsZero()
    {
      const int EXPECTED = 1;

      int actual = _testCalculator.GetValueAt(0, 0);

      Assert.AreEqual(EXPECTED, actual, "Row 0, Col 0 should result in 1.");
    }

    [Test]
    public void GetValueAt_ShouldReturnOne_WhenColumnIsSameValueAsRow()
    {
      const int EXPECTED = 1;

      const int ROW = 2;
      int actual = _testCalculator.GetValueAt(ROW, ROW);

      Assert.AreEqual(EXPECTED, actual, "Value for Row and Column being the same is 1");
    }

    [Test]
    public void GetValueAt_ShouldReturnOne_WhenColumnIsZero()
    {
      const int EXPECTED = 1;

      int actual = _testCalculator.GetValueAt(2, 0);

      Assert.AreEqual(EXPECTED, actual, "Value should be one when column is zero");
    }

    [Test]
    public void GetValueAt_ShouldReturnThree_WhenColumnIsOneAndRowIsThree()
    {
      const int EXPECTED = 3;
      const int ROW = 3;
      const int COLUMN = 1;

      int actual = _testCalculator.GetValueAt(ROW, COLUMN);

      Assert.AreEqual(EXPECTED, actual, "The value for Row 3, Col 1 should be 3");
    }

    [Test]
    public void PrintTriangle_ShouldPrintRowOf_1_5_10_10_5_1_WhenRowIsFive()
    {
      _mockInputOutput.Expect(x => x.WriteLine("1 5 10 10 5 1")).Repeat.AtLeastOnce();

      _testCalculator.PrintTriangle(5);

      _mockInputOutput.VerifyAllExpectations();
    }

    [Test]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void PrintTriangle_ShouldThrowArgumentOutOfRangeException_WhenRowIsNegative()
    {
      _testCalculator.PrintTriangle(-1);
    }
  }
}