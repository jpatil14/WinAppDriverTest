Feature: CalcFeature
Calculator

@mytag
Scenario: Add two numbers in windows calculator application
	Given I open the calculator application
	And I click following numbers
	| Numbers |
	| Nine    |
	| Five	  |
	And I perform Addition operation
	And I click following numbers
	| Numbers |
	| Seven        |
	And I click equals
	Then the result should be 102
