Feature: APITestWithSpecFlow
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: API Test
	Given I have my End point
	And I sent a "Method.Get"
	When I execute the respose
	Then the response is successful
