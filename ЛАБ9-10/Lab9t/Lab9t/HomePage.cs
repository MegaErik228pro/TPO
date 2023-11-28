using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9t
{
    public class HomePage
    {
        private static WebDriver driver = new EdgeDriver();
        private static string login = "newstasy@icloud.com";
        private static string pass = "Ma#vPR4x8q!Gn7O)z0j$&KD1";

        public static int lower = 10;
        public static int upper = 15;

        public static void OpenPage()
        {
            driver.Navigate().GoToUrl("https://www.kufar.by/l/r~minsk?sort=lst.d");
            driver.Manage().Window.Maximize();
            Thread.Sleep(200);
            driver.FindElement(By.XPath("//button[text()=\"Принять\"]")).Click();
            Thread.Sleep(10000);
        }

        public static void OpenPageF()
        {
            driver.Navigate().GoToUrl("https://www.kufar.by/l/r~minsk?sort=lst.d");
            driver.Manage().Window.Maximize();
            Thread.Sleep(10000);
        }

        public static void SignIn()
        {
            driver.FindElement(By.XPath("//button[@class=\"styles_button__oKUgO styles_outline__maWFU styles_size-m__NgAcw\"]")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id=\"login\"]")).SendKeys(login);
            driver.FindElement(By.XPath("//input[@id=\"password\"]")).SendKeys(pass);
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//div[@class=\"styles_form__submit_login__r7ELP\"]")).Click();
            Thread.Sleep(2000);
        }

        public static void AddFirstItemToWishlist()
        {
            driver.FindElements(By.XPath("//div[@class=\"styles_wrapper__FNoK6\"]"))[0].Click();
            Thread.Sleep(200);
        }

        public static void OpenWishlist()
        {
            driver.FindElement(By.XPath("//div[@class=\"styles_avatar-block__ygFCL\"]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//span[text()=\"Избранное\"]")).Click();
            Thread.Sleep(1000);
        }

        public static int CountWishlistItems()
        {
            return driver.FindElements(By.XPath("//div[@class=\"styles_image__kwQfE\"]")).Count();
        }

        public static void SearchPrices()
        {
            driver.FindElement(By.XPath("//input[@name=\"prc.lower\"]")).SendKeys(lower.ToString());
            driver.FindElement(By.XPath("//input[@name=\"prc.upper\"]")).SendKeys(upper.ToString());
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@class=\"styles_button__oKUgO styles_default__ws8JN styles_size-m__NgAcw styles_block___PraQ\"]")).Click();
            Thread.Sleep(2000);
        }

        public static int GetPrice()
        {
            string result = driver.FindElement(By.XPath("//p[@class=\"styles_price__G3lbO\"]//span")).Text.Substring(0, 2);
            int price = Int32.Parse(result);
            return price;
        }
    }
}
