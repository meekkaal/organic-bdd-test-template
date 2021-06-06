using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Organic_BDD_Test_Template_Project.Drivers;
using System.Threading;
using NUnit.Framework;

namespace Organic_BDD_Test_Template_Project.Steps
{
    [Binding]
    public sealed class WebUISteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private IWebDriver driver;
        private WebDriverGenerator driverGenerator = new WebDriverGenerator();

        public WebUISteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"a ""(.*)"" web driver is constructed")]
        public void GivenAWebDriverIsConstructed(string browserName)
        {

            switch (browserName.ToLower())
            {
                case "firefox":
                    driver = driverGenerator.CreateFireFoxDriver();
                    break;
                case "chrome":
                    driver = driverGenerator.CreateChromeDriver();
                    break;
                default:
                    break;
            }
        }

        [When(@"the web driver navigates to ""(.*)""")]
        public void WhenTheWebDriverNavigatesTo(string url)
        {
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
        }

        [Then(@"the web page title is ""(.*)""")]
        public void ThenTheWebPageTitleIs(string expectedTitle)
        {
            Assert.That(driver.Title, Is.EqualTo(expectedTitle));
        }


    }
}
