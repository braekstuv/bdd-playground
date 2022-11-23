Feature: Division

As a user, I can pass two numbers to a calculator,
so that I can get the division of those two numbers

Scenario: Dividing 10 by 2 equals 5
	Given the first number is 10
	And the second number is 2
	When dividing these two numbers
	Then the result should be 5
