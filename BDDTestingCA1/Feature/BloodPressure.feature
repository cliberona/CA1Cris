Feature: BloodPressure
	Simple test for calculate blood pressure

@unitest
Scenario: Blood pressure
	Given the systolic pressure is 100
	And the diastolic pressure is 60
	When I press calculate
	Then the result should be 'Ideal Blood Pressure'