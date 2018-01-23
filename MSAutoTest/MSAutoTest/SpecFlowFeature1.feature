Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: The "Contacts" page exists.
	Given I am on the Home page
	| Login | Password |
	| admin | admin    | 
	When About Us menu item is clicked
    And Contacts submenu item is clicked
	Then Contacts page opens
