using Microlise_Test_Common.Web;
using TechTalk.SpecFlow;

namespace Microlise_Test
{
    [Binding]
    public class TestSetup
    {
        public static WebPortal WebPortal;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            if (WebPortal == null)
                WebPortal = new WebPortal(Properties.Settings.Default.BrowserType);
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            WebPortal.Driver.Quit();
        }
    }
}
