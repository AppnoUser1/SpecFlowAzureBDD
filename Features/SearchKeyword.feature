Feature: Search keyword 
Scenario: Google home page basic search test
	Given user opens chrome browser 
	When user type a <keyword> in input field
	And user clicks on Search button
	Then search results is shown to user 
	Examples:
	| keyword         |
	| Selenium        |
	| Test Automation |
