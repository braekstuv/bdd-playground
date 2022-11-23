namespace SimpleCalculator.Specs.Drivers
{
    public class CalculatorDriver
    {
        private readonly ScenarioContext _scenarioContext;

        public int ActualResult
        {
            get => (int)_scenarioContext[nameof(ActualResult)];
            private set => _scenarioContext[nameof(ActualResult)] = value;
        }

        public int FirstNumber
        {
            get => (int)_scenarioContext[nameof(FirstNumber)];
            set => _scenarioContext[nameof(FirstNumber)] = value;
        }

        public int SecondNumber
        {
            get => (int)_scenarioContext[nameof(SecondNumber)];
            set => _scenarioContext[nameof(SecondNumber)] = value;
        }

        private Calculator Calculator
        {
            get
            {
                if (_scenarioContext.TryGetValue(nameof(Calculator), out Calculator calc))
                {
                    return calc;
                }

                calc = new Calculator();
                Calculator = calc;
                return calc;
            }

            set => _scenarioContext[nameof(Calculator)] = value;
        }

        public CalculatorDriver(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        public void Add()
        {
            ActualResult = Calculator.Add(FirstNumber, SecondNumber);
        }

        internal void Subtract()
        {
            ActualResult = Calculator.Subtract(FirstNumber, SecondNumber);
        }

        internal void Divide()
        {
            ActualResult = Calculator.Divide(FirstNumber, SecondNumber);
        }
    }
}
