using SimpleCalculator.Specs.Drivers;

namespace SimpleCalculator.Specs.StepDefinitions
{
    [Binding]
    public class AdditionStepDefinitions
    {
        private readonly CalculatorDriver _calculatorDriver;

        public AdditionStepDefinitions(CalculatorDriver calculatorDriver)
        {
            _calculatorDriver = calculatorDriver;
        }

        [When(@"adding these two numbers")]
        public void WhenAddingTheseTwoNumbers()
        {
            _calculatorDriver.Add();
        }
    }
}
