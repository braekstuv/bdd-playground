using SimpleCalculator.Specs.Drivers;

namespace SimpleCalculator.Specs.StepDefinitions
{
    [Binding]
    public class DivisionStepDefinitions
    {
        private readonly CalculatorDriver _calculatorDriver;

        public DivisionStepDefinitions(CalculatorDriver calculatorDriver)
        {
            _calculatorDriver = calculatorDriver;
        }

        [When(@"dividing these two numbers")]
        public void WhenDividingTheseTwoNumbers()
        {
            _calculatorDriver.Divide();
        }
    }
}
