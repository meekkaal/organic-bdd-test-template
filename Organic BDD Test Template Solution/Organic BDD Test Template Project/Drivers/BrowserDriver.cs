using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace Organic_BDD_Test_Template_Project.Drivers
{
    [Binding]
    public class BrowserDriver
    {
        private readonly Lazy<IWebDriver> _currentWebDriverLazy;
        private readonly ScenarioContext _scenarioContext;
        private bool _isDisposed;

        public BrowserDriver(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _currentWebDriverLazy = new Lazy<IWebDriver>(CreateWebDriver);
        }

        /// <summary>
        /// The Selenium IWebDriver instance
        /// </summary>
        public IWebDriver Current => _currentWebDriverLazy.Value;

        /// <summary>
        /// Creates the Selenium web driver (opens a browser)
        /// </summary>
        /// <returns></returns>
        private IWebDriver CreateWebDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            var chromeDriver = new ChromeDriver();
            return chromeDriver;
            //We use the Chrome browser
        }

        /// <summary>
        /// Disposes the Selenium web driver (closing the browser)
        /// </summary>
        public void Dispose()
        {
            if (_isDisposed)
            {
                return;
            }

            if (_currentWebDriverLazy.IsValueCreated)
            {
                Current.Quit();
            }

            _isDisposed = true;
        }
    }
}
