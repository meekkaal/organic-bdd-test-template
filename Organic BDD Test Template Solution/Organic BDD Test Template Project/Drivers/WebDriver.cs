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


namespace Organic_BDD_Test_Template_Project.Drivers
{
    class WebDriver
    {
        private IWebDriver _webDriver;

        public WebDriver()
        {
        }


        public IWebDriver CreateChromeDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _webDriver = new ChromeDriver();
            return _webDriver;
        }

        public IWebDriver CreateFireFoxDriver()
        {
            new DriverManager().SetUpDriver(new FirefoxConfig());
            _webDriver = new FirefoxDriver();
            return _webDriver;
        }

    }
}
