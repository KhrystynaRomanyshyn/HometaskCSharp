Feature: Test 1

@mytag
Scenario: Login as admin
	Given the main page with credentials is opened
	When user logs in 
	| Login          | Password |
	| admin@epam.com | admin123 | 
	Then the user's main page opens
