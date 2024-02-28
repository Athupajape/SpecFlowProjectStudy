Feature: Login Parallel

It helps to check the login functionality.

@tag1
Scenario Outline: Login with Valid credentails
	Given I am on the login page
	When I provide username <username>
	And I provide password <password>
	And I select login
	Then I am shown a dashboard of the application
	And user adds firstname and lastname
	#And I am shown the user details.
Examples: 
| username | password |
|  standard_user        |  secret_sauce        |
|   problem_user       |    secret_sauce      |

@tag1
Scenario Outline: Login with Valid credentails second
	Given display employee full name
	
	#And I am shown the user details.
Examples: 
| username | password |
|  standard_user        |  secret_sauce        |
