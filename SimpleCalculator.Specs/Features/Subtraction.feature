Feature: Subtraction

As a user, I can pass two numbers to a calculator,
so that I can get the difference of those two numbers

Scenario: Subtracting 1 to 1 equals 0
	Given the first number is 1
	And the second number is 1
	When subtracting these two numbers
	Then the result should be 0
