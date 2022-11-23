Feature: Addition

As a user, I can pass two numbers to a calculator,
so that I can get the sum of those two numbers

Scenario: Adding 1 to 1 equals 2
	Given the first number is 1
	And the second number is 1
	When adding these two numbers
	Then the result should be 2
	And the result is greater than 0

Scenario: Adding 3 to -5 equals -2
	Given the first number is 3
	And the second number is -5
	When adding these two numbers
	Then the result should be -2