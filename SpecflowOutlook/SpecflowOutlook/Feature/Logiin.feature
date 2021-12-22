Feature: Logiin
	Login feature

@smoke
Scenario: Successful Logiin of new user with valid credential
    Given User Launch Application
    And User Enters Email as and click next
    When user Enters Password as and click next
    Then Click on Signiin

