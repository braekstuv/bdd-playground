using SimpleCalculator.Specs.Drivers;

namespace SimpleCalculator.Specs.StepDefinitions
{
    [Binding]
    public class SubtractionStepDefinitions
    {
        private readonly CalculatorDriver _calculatorDriver;

        public SubtractionStepDefinitions(CalculatorDriver calculatorDriver)
        {
            _calculatorDriver = calculatorDriver;
        }

        // We can also bind steps to 1 feature, scenario or tag:
        //[Given(@"the first number is (.*)")]
        //[Scope(Feature = "Subtraction")]
        //public void GivenTheFirstNumberIs(int number)
        //{
        //    ...
        //}

        [When(@"subtracting these two numbers")]
        public void WhenSubtractingTheseTwoNumbers()
        {
            _calculatorDriver.Subtract();
            // this would not be possible, as these are private members
            //_actualResult = _calculator.Subtract(_firstNumber, _secondNumber);
            
            // also, using base classes to share stepdefinitions is not possible
            // as Specflow will see these definitions as ambiguous


        }
    }
}
