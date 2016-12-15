using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Microlise_Test_Common.POMWebElements
{
    public class SearchResources
    {
        private IWebDriver driver;

        public SearchResources(IWebDriver _driver)
        {
            driver = _driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@class='top-bar-container']/nav/section/ul/li[3]/a")]
        public IWebElement ResourcesMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='search-block']/form/div[1]/div[1]/p[1]/input")]
        public IWebElement SearchTermTextbox { get; set; }

        [FindsBy(How = How.Id, Using = "cat")]
        public IWebElement ReleventIndustryDropdown { get; set; }

        [FindsBy(How = How.Name, Using = "post_type")]
        public IWebElement ResourceTypeDropdown { get; set; }

        [FindsBy(How = How.Name, Using = "year")]
        public IWebElement YearDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='search-block']/form/div[2]/div/input")]
        public IWebElement ResourcesSearchButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".main-column .list-block header h1")]
        public IWebElement AssertSearchResultText { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='main-column']/section/article[1]/header/h2/a")]
        public IWebElement FirstLinkOfSearchResult { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='main-column']/article[1]/header/h1")]
        public IWebElement AssertFirstLinkOfSearchResult { get; set; }
    }
}
