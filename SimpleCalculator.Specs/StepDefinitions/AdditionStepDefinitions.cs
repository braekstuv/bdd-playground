using System;
using TechTalk.SpecFlow;

namespace SimpleCalculator.Specs.StepDefinitions
{
    [Binding]
    public class AdditionStepDefinitions
    {
        private readonly Calculator _calculator = new Calculator();
        private int _firstNumber;
        private int _secondNumber;
        private int _actualResult;

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _firstNumber = number;
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _secondNumber = number;
        }

        [When(@"adding these two numbers")]
        public void WhenAddingTheseTwoNumbers()
        {
            _actualResult = _calculator.Add(_firstNumber, _secondNumber);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            _actualResult.Should().Be(expectedResult);
        }

        [Then(@"the result is greater than (.*)")]
        public void ThenTheResultIsGreaterThan(int smallerNumber)
        {
            _actualResult.Should().BeGreaterThan(smallerNumber);
        }

    }
}
