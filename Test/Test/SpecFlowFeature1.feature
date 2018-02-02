Feature: Test 1

@mytag
Scenario: Login as admin
	Given the main page with credentials is opened
	When user logs in 
	| Login          | Password |
	| admin@epam.com | admin123 | 
	Then the user's main page opens

Scenario: Load json file from folder
	Given login as admin
	| Login          | Password |
	| admin@epam.com | admin123 | 
	When admin choose file

	Then button Import test group is available
