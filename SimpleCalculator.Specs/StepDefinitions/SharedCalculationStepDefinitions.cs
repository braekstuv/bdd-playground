using SimpleCalculator.Specs.Drivers;

namespace SimpleCalculator.Specs.StepDefinitions
{
    [Binding]
    public class SharedCalculationStepDefinitions
    {
        private readonly CalculatorDriver _calculatorDriver;

        public SharedCalculationStepDefinitions(CalculatorDriver calculatorDriver)
        {
            _calculatorDriver = calculatorDriver;
        }

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            // another way to use ScenarioContext directly:
            //_scenarioContext["FirstNumber"] = number;

            _calculatorDriver.FirstNumber = number;
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculatorDriver.SecondNumber = number;
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            _calculatorDriver.ActualResult.Should().Be(expectedResult);
        }

        [Then(@"the result is greater than (.*)")]
        public void ThenTheResultIsGreaterThan(int smallerNumber)
        {
            _calculatorDriver.ActualResult.Should().BeGreaterThan(smallerNumber);
        }
    }
}
