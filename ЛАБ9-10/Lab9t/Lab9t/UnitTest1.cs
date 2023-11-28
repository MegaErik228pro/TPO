using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace Lab9t
{
    public class Tests
    {
        /*private static WebDriver driver = new EdgeDriver();
        private static string login = "newstasy@icloud.com";
        private static string pass = "Ma#vPR4x8q!Gn7O)z0j$&KD1";*/

        [SetUp]
        public void Setup()
        {
            //artstation
            /*driver.Navigate().GoToUrl("https://www.artstation.com/?sort_by=community&dimension=all");
            driver.FindElement(By.XPath("//a[@class=\"main-menu-bar-link justify-content-end menu-item-auth menu-item-signin\"]")).Click();
            driver.FindElement(By.XPath("//input[@id=\"user_email\"]")).SendKeys(login);
            driver.FindElement(By.XPath("//input[@id=\"user_password\"]")).SendKeys(pass);
            driver.FindElement(By.XPath("//button[@class=\"bs-btn bs-btn-block bs-btn-primary\"]")).Click();*/

            //driver.Navigate().GoToUrl("https://www.artstation.com/marketplace/p/kVl9/zombie-skin-vd-brushes?utm_source=artstation&utm_medium=referral&utm_campaign=artwork_search&utm_term=marketplace");
        }

        [Test]
        public void AddToWishlist()
        {
            HomePage.OpenPage();
            HomePage.SignIn();
            HomePage.AddFirstItemToWishlist();
            HomePage.OpenWishlist();
            if (HomePage.CountWishlistItems() <= 0)
            {
                Assert.Fail("Test Failed!");
            }

            //artstation
            /*driver.FindElement(By.XPath("//input[@class=\"form-control product-variant-quantity-input\"]")).Clear();
            driver.FindElement(By.XPath("//input[@class=\"form-control product-variant-quantity-input\"]")).SendKeys("3");
            driver.FindElement(By.XPath("//div[@class=\"d-flex row-wrap row-gutter-8\"]")).Click();
            driver.FindElement(By.XPath("//span[@class=\"has-value-show\"]")).Click();*/
        }

        [Test]
        public void Filters()
        {
            HomePage.OpenPageF();
            HomePage.SearchPrices();
            if (HomePage.GetPrice() < HomePage.lower || HomePage.GetPrice() > HomePage.upper)
            {
                Assert.Fail("Test Failed!");
            }
        }
    }
}