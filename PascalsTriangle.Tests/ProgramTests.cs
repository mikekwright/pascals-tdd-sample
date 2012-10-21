using NUnit.Framework;
using PascalsTriangle.Contracts;
using Rhino.Mocks;

namespace PascalsTriangle.Tests
{
  [TestFixture]
  public class ProgramTests
  {
    private IInputOutput _mockInputOutput;
    private ITriangleCalculator _mockTriangleCalculator;

    [SetUp]
    public void SetupDependencies()
    {
      _mockInputOutput = MockRepository.GenerateMock<IInputOutput>();
      _mockTriangleCalculator = MockRepository.GenerateMock<ITriangleCalculator>();
    }

    [Test]
    public void RunProgram_ShouldReturnExitCodeOne_WhenTheUserInputIsNotANumber()
    {
      Assert.Fail("Not Implemented"); 
    }

    [Test]
    public void RunProgram_ShouldPassEnteredValue_ToTriangleCalculatorPrintTriangle()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void RunProgram_ShouldReturnExitCodeOfOne_WhenThePrintTriangleFunctionThrowsAnException()
    {
      Assert.Fail("Not Implemented");
    }

    [Test]
    public void RunProgram_ShouldReturnExitCodeOfZero_WhenPrintTriangleDoesntThrowAnException()
    {
      Assert.Fail("Not Implemented");
    }
  }
}