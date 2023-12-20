using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab11.Loger.Loger;

namespace Lab11.Pages
{
    internal class MainPage : PageBase.PageBase
    {

        private readonly string _baseUrl = "https://www.kufar.by";
        private static string login = "newstasy@icloud.com";
        private static string pass = "Ma#vPR4x8q!Gn7O)z0j$&KD1";
        public static int lower = 10;
        public static int upper = 15;

        public MainPage(IWebDriver driver) : base(driver)
        {
        }

        public void OpenPage()
        {
            Driver.Navigate().GoToUrl("https://www.kufar.by/l/r~minsk?sort=lst.d");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(200);
            Driver.FindElement(By.XPath("//button[text()=\"Принять\"]")).Click();
            Thread.Sleep(10000);
            Info("Main page opened.");
        }

        public void OpenPageF()
        {
            Driver.Navigate().GoToUrl("https://www.kufar.by/l/r~minsk?sort=lst.d");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(10000);
            Info("Main page opened.");
        }

        public void SignIn()
        {
            Driver.FindElement(By.XPath("//button[@class=\"styles_button__oKUgO styles_outline__maWFU styles_size-m__NgAcw\"]")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.XPath("//input[@id=\"login\"]")).SendKeys(login);
            Driver.FindElement(By.XPath("//input[@id=\"password\"]")).SendKeys(pass);
            Thread.Sleep(1000);
            Driver.FindElement(By.XPath("//div[@class=\"styles_form__submit_login__r7ELP\"]")).Click();
            Thread.Sleep(2000);
        }

        public void AddFirstItemToWishlist()
        {
            Driver.FindElements(By.XPath("//div[@class=\"styles_wrapper__FNoK6\"]"))[0].Click();
            Thread.Sleep(200);
        }

        public void OpenWishlist()
        {
            Driver.FindElement(By.XPath("//div[@class=\"styles_avatar-block__ygFCL\"]")).Click();
            Thread.Sleep(5000);
            Driver.FindElement(By.XPath("//span[text()=\"Избранное\"]")).Click();
            Thread.Sleep(1000);
        }

        public void OpenProfile()
        {
            Driver.FindElement(By.XPath("//div[@class=\"styles_avatar-block__ygFCL\"]")).Click();
            Thread.Sleep(5000);
            Driver.FindElement(By.XPath("//span[text()=\"Настройки\"]")).Click();
            Thread.Sleep(1000);
        }

        public bool CheckAuth()
        {
            if (Driver.FindElement(By.XPath("//*[@id=\"personal_info_form\"]/div[1]/div/span/p[2]")).Text == login)
                return true;
            else
                return false;
        }

        public int CountWishlistItems()
        {
            return Driver.FindElements(By.XPath("//div[@class=\"styles_image__kwQfE\"]")).Count();
        }

        public void SearchPrices()
        {
            Driver.FindElement(By.XPath("//input[@name=\"prc.lower\"]")).SendKeys(lower.ToString());
            Driver.FindElement(By.XPath("//input[@name=\"prc.upper\"]")).SendKeys(upper.ToString());
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//button[@class=\"styles_button__oKUgO styles_default__ws8JN styles_size-m__NgAcw styles_block___PraQ\"]")).Click();
            Thread.Sleep(2000);
        }

        public void SearchCategory()
        {
            Driver.FindElement(By.XPath("//span[text()=\"Категории\"]")).Click();
            Thread.Sleep(3000);
            Driver.FindElement(By.XPath("//div[@class=\"styles_link__wrapper__iZscr styles_link__wrapper--active__S0jQa\"]")).Click();
            Thread.Sleep(2000);
        }

        public bool CheckCategory()
        {
            if (Driver.FindElement(By.XPath("//span[@class=\"styles_main_link__hJ5KM\"]")).Text == "Недвижимость")
                return true;
            else
                return false;
        }

        public int GetPrice()
        {
            string result = Driver.FindElement(By.XPath("//p[@class=\"styles_price__G3lbO\"]//span")).Text.Substring(0, 2);
            int price = Int32.Parse(result);
            return price;
        }

    }
}
