using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Microlise_Test.StepDefinitions
{
    [Binding]
    public class Resource_Search_FunctionalitySteps : TestSetup
    {
        private string _firstSearchResult = "";

        [Given(@"I navigate to Microlise site")]
        public void GivenINavigateToMicroliseSite()
        {
            WebPortal.CommonActions.Navigate(Properties.Settings.Default.URL);
        }
        
        [Given(@"I click on Resources tab")]
        public void GivenIClickOnResourcesTab()
        {
            WebPortal.CommonActions.Click(WebPortal.SearchResources.ResourcesMenu);
        }
        
        [Given(@"I enter '(.*)' in searchbox")]
        public void GivenIEnterInSearchbox(string searchTerm)
        {
            WebPortal.CommonActions.EnterText(WebPortal.SearchResources.SearchTermTextbox, searchTerm);
        }
        
        [Given(@"I select '(.*)' from Relevant Industry dropdown")]
        public void GivenISelectFromRelevantIndustryDropdown(string relevantIndustryText)
        {
            WebPortal.CommonActions.SelectDropdownUsingText(WebPortal.SearchResources.ReleventIndustryDropdown, relevantIndustryText);
        }
        
        [Given(@"I select '(.*)' from Resource Type")]
        public void GivenISelectFromResourceType(string resourceType)
        {
            WebPortal.CommonActions.SelectDropdownUsingText(WebPortal.SearchResources.ResourceTypeDropdown, resourceType);
        }
        
        [Given(@"I select '(.*)' year")]
        public void GivenISelectYear(int year)
        {
            WebPortal.CommonActions.SelectDropdownUsingText(WebPortal.SearchResources.YearDropdown, year.ToString());
        }
        
        [Given(@"I click on Search Now buton")]
        public void GivenIClickOnSearchNowButon()
        {
            WebPortal.CommonActions.Click(WebPortal.SearchResources.ResourcesSearchButton);
        }
        
        [When(@"I click first link of search result")]
        public void WhenIClickFirstLinkOfSearchResult()
        {
            _firstSearchResult = WebPortal.CommonActions.GetText(WebPortal.SearchResources.FirstLinkOfSearchResult);
            WebPortal.CommonActions.Click(WebPortal.SearchResources.FirstLinkOfSearchResult);
        }
        
        [Then(@"I am able to see '(.*)' on search result page")]
        public void ThenIAmAbleToSeeOnSearchResultPage(string displayString)
        {
            Assert.AreEqual(displayString.ToUpper(), WebPortal.CommonActions.GetText(WebPortal.SearchResources.AssertSearchResultText));
        }
        
        [Then(@"I am able to see detail description of first search result")]
        public void ThenIAmAbleToSeeDetailDescriptionOfFirstSearchResult()
        {
            Assert.AreEqual(_firstSearchResult.ToUpper(), WebPortal.CommonActions.GetText(WebPortal.SearchResources.AssertFirstLinkOfSearchResult));
        }
    }
}
