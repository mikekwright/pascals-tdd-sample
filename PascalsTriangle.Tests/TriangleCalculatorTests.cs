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
      Assert.Fail("Not Implemented");
    }

    [Test]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void GetValueAt_ShouldThrowArgumentOutOfRangeException_WhenColumnIsNegative()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void GetValueAt_ShouldThrowArgumentOutOfRangeException_WhenColumnIsGreaterThenRow()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void GetValueAt_ShouldReturnOne_WhenColumnIsZeroAndRowIsZero()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void GetValueAt_ShouldReturnOne_WhenColumnIsSameValueAsRow()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void GetValueAt_ShouldReturnOne_WhenColumnIsZero()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void GetValueAt_ShouldReturnThree_WhenColumnIsOneAndRowIsThree()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void PrintTriangle_ShouldPrintRowOf_1_5_10_10_5_1_WhenRowIsFive()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void PrintTriangle_ShouldThrowArgumentOutOfRangeException_WhenRowIsNegative()
    {
      Assert.Fail("Not Implemented");
    }
  }
}