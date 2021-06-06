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
    class WebDriverGenerator
    {
        private IWebDriver _webDriver;
        private readonly ScenarioContext _scenarioContext;

        public WebDriverGenerator(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        public void CreateChromeDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _webDriver = new ChromeDriver();
            _scenarioContext.TryAdd("webDriver", _webDriver);
        }

        public void CreateFireFoxDriver()
        {
            new DriverManager().SetUpDriver(new FirefoxConfig());
            _webDriver = new FirefoxDriver();
            _scenarioContext.TryAdd("webDriver", _webDriver);
        }
    }
}
