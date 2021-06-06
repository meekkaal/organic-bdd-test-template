using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Organic_BDD_Test_Template_Project.Drivers;
using System.Threading;
using NUnit.Framework;
using Organic_BDD_Test_Template_Project.PageObjects;
using FluentAssertions;

namespace Organic_BDD_Test_Template_Project.Steps
{
    [Binding]
    public sealed class WebUISteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private GenericPageObject _genericPageObject;
        private readonly IWebDriver _webDriver;

        public WebUISteps(ScenarioContext scenarioContext, BrowserDriver browserDriver)
        {
            _scenarioContext = scenarioContext;
            _genericPageObject = new GenericPageObject(browserDriver.Current);
            _webDriver = browserDriver.Current;
        }

        [Given(@"a ""(.*)"" web driver is constructed")]
        public void GivenAWebDriverIsConstructed(string browserName)
        {
        }

        [When(@"the web driver navigates to ""(.*)""")]
        public void WhenTheWebDriverNavigatesTo(string url)
        {
            _webDriver.Navigate().GoToUrl(url);
        }

        [Then(@"the web page title is ""(.*)""")]
        public void ThenTheWebPageTitleIs(string expectedTitle)
        {
            var actualResult = _genericPageObject.WaitForTitle();

            actualResult.Should().Be(expectedTitle);
        }


    }
}
