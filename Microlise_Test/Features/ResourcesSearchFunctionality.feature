Feature: Resource_Search_Functionality

@Test1
Scenario:Should display valid search result when entering valid term, relevent industry, resource type and year
	Given I navigate to Microlise site
	And I click on Resources tab
	And I enter 'Vehicle' in searchbox
	And I select 'Defence & Government' from Relevant Industry dropdown
	And I select 'Press Releases' from Resource Type
	And I select '2016' year 
	And I click on Search Now buton
	Then I am able to see 'Search results - Vehicle' on search result page

@Test2
Scenario: Should not display result when entering invalid search criteria
	Given I navigate to Microlise site
	And I click on Resources tab
	And I enter 'ABC112' in searchbox
	And I select 'Defence & Government' from Relevant Industry dropdown
	And I select 'Press Releases' from Resource Type
	And I select '2016' year 
	And I click on Search Now buton
	Then I am able to see 'Nothing Found' on search result page

@Test3
Scenario: Should open page with detail description of first search result 
	Given I navigate to Microlise site
	And I click on Resources tab
	And I enter 'Vehicle' in searchbox
	And I select 'Defence & Government' from Relevant Industry dropdown
	And I select 'Press Releases' from Resource Type
	And I select '2016' year 
	And I click on Search Now buton
	When I click first link of search result
	Then I am able to see detail description of first search result
