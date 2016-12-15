
using Microlise_Test_Common.Common;
using Microlise_Test_Common.POMWebElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;

namespace Microlise_Test_Common.Web
{
    public class WebPortal
    {
        private CommonActions _commonActions;
        private SearchResources _searchResources;
        private EventFiringWebDriver _driver;
        private string _browserType;

        public WebPortal(string browserType)
        {
            _browserType = browserType;
        }

        private void Create()
        {
            if (_driver == null)
            {
                _driver = new WebDriverFactory().CreateDriver(_browserType);
                _commonActions = new CommonActions(_driver);
                _searchResources = new SearchResources(_driver);
            }
        }

        public SearchResources SearchResources
        {
            get
            {
                Create();
                return _searchResources;
            }
        }

        public CommonActions CommonActions
        {
            get
            {
                Create();
                return _commonActions;
            }
        }

        public IWebDriver Driver
        {
            get
            {
                Create();
                return _driver;
            }
        }
    }
}
