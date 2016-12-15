
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.Events;

namespace Microlise_Test_Common.Web
{
    public class WebDriverFactory
    {
        public EventFiringWebDriver CreateDriver(string browser)
        {
            if (browser == null)
                throw new ArgumentException("You must be specify browser");

            switch (browser.ToUpper())
            {
                case "CHROME":
                    return new EventFiringWebDriver(new ChromeDriver());

                case "IE":
                    return new EventFiringWebDriver(new InternetExplorerDriver());

                case "FIREFOX":
                    return new EventFiringWebDriver(new FirefoxDriver());
            }

            throw new NotSupportedException(browser + "  browser is not supported");
        }
    }
}
