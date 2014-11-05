namespace TestingFramework.Core.Base
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NUnit.Framework;
    
    /// <summary>
    /// This class encapsulates the core functionality of a test class.
    /// It is meant to be inherited by every test class.
    /// </summary>
    [TestClass]
    public class BaseTest
    {
        public Browser Browser
        {
            get
            {
                return Manager.Current.ActiveBrowser;
            }
        }

        public virtual void TestInit()
        {
        }

        [TestCleanup]
        public virtual void TestCleanUp()
        {
            Browser.ClearCache(BrowserCacheType.Cookies);
        }

        [TestFixtureSetUp]
        [TestInitialize]
        public void CoreTestInit()
        {
            this.InitializeBrowser();

            this.TestInit();
        }

        [TestFixtureTearDown]
        [ClassCleanup]
        public void CoreTestCleanUp()
        {
            this.TestCleanUp();
            this.DisposeBrowser();
        }

        private void InitializeBrowser()
        {
            if (Manager.Current == null)
            {
                Settings mySettings = new Settings();
                mySettings.Web.KillBrowserProcessOnClose = true;
                mySettings.DisableDialogMonitoring = true;
                mySettings.UnexpectedDialogAction = UnexpectedDialogAction.HandleAndContinue;
                mySettings.Web.ExecutingBrowsers.Add(BrowserExecutionType.InternetExplorer);
                mySettings.Web.Browser = BrowserExecutionType.InternetExplorer;
                mySettings.Web.DefaultBrowser = BrowserType.InternetExplorer;
                mySettings.Web.RecycleBrowser = true;
                mySettings.ExecutionDelay = 100;
                var manager = new Manager(mySettings);
                manager.Start();
            }

            Manager.Current.LaunchNewBrowser();
            Manager.Current.ActiveBrowser.ClearCache(BrowserCacheType.Cookies);
        }

        private void DisposeBrowser()
        {
            foreach (var browser in Manager.Current.Browsers)
            {
                browser.Close();
            }

            if (Manager.Current != null)
            {
                Manager.Current.Dispose();
            }
        }
    }
}
