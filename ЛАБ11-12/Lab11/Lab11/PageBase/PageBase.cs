using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Lab11.PageBase
{
    internal class PageBase
    {
        protected IWebDriver Driver;

        public PageBase(IWebDriver driver)
        {
            this.Driver = driver;
        }
    }
}
