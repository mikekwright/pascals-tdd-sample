using System;
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
      _mockInputOutput.Expect(x => x.ReadLine()).Return("Not A Number");
      const int EXPECTED = 1;

      int actual = Program.RunProgram(_mockInputOutput, _mockTriangleCalculator);

      Assert.AreEqual(EXPECTED, actual, "The exit code when a user enters invalid input is 1");
    }

    [Test]
    public void RunProgram_ShouldPassEnteredValue_ToTriangleCalculatorPrintTriangle()
    {
      const int EXPECTED = 10;
      _mockInputOutput.Expect(x => x.ReadLine()).Return(EXPECTED.ToString());
      _mockTriangleCalculator.Expect(x => x.PrintTriangle(EXPECTED));

      Program.RunProgram(_mockInputOutput, _mockTriangleCalculator);

      _mockTriangleCalculator.VerifyAllExpectations();
    }

    [Test]
    public void RunProgram_ShouldReturnExitCodeOfOne_WhenThePrintTriangleFunctionThrowsAnException()
    {
      _mockInputOutput.Stub(x => x.ReadLine()).Return(10.ToString());
      _mockTriangleCalculator.Expect(x => x.PrintTriangle(Arg<int>.Is.Anything)).Throw(new Exception());
      const int EXPECTED = 1;

      int actual = Program.RunProgram(_mockInputOutput, _mockTriangleCalculator);

      _mockTriangleCalculator.VerifyAllExpectations();
    }

    [Test]
    public void RunProgram_ShouldReturnExitCodeOfZero_WhenPrintTriangleDoesntThrowAnException()
    {
      const int EXPECTED = 0;
      _mockInputOutput.Stub(x => x.ReadLine()).Return(10.ToString());

      int actual = Program.RunProgram(_mockInputOutput, _mockTriangleCalculator);

      Assert.AreEqual(EXPECTED, actual, "A successful run should have an exit code of zero");
    }
  }
}