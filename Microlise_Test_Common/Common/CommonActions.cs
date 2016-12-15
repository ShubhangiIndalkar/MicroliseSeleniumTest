using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Microlise_Test_Common.Common
{
    public class CommonActions
    {
        private IWebDriver driver;

        public CommonActions(IWebDriver _driver)
        {
            this.driver = _driver;
        }

        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }

        public void Click(IWebElement element)
        {
            element.Click();
        }

        public void EnterText(IWebElement element, string text)
        {
            element.SendKeys(text);
        }

        public void SelectDropdownUsingText(IWebElement element, string text)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByText(text);
        }

        public void SelectDropdownUsingValue(IWebElement element, string text)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByValue(text);
        }

        public void SelectDropdownUsingIndex(IWebElement element, int index)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByIndex(index);
        }

        public string GetText(IWebElement element)
        {
            return element.Text;
        }

        public void ClearText(IWebElement element)
        {
            element.Clear();
        }

        public void ExplicitWait(IWebElement element, int secondTime)
        {
            //WebDriverWait webDriverWait = new WebDriverWait(PropertyCollections.Driver, TimeSpan.FromSeconds(secondTime));
            //webDriverWait.Until(ExpectedConditions.ElementToBeClickable(element));
        }
    }
}
