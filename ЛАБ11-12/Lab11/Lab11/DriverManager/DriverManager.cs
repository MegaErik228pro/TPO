using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.DevTools;
using static Lab11.Loger.Loger;
using OpenQA.Selenium.Edge;

namespace Lab11.DriverManager
{
    public class DriverMaganer
    {
        private static IWebDriver? _driver;

        public static IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                {
                    InitializeDriver();
                }
                return _driver;
            }
        }

        private static void InitializeDriver()
        {
            _driver = new EdgeDriver();
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            Info("WebDriver initialized.");
        }

        public static void QuitDriver()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver = null;
                Info("WebDriver quit.");
            }
        }
    }
}
