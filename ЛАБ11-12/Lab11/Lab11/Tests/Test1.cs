using Lab11.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab11.DriverManager.DriverMaganer;
using Assert = NUnit.Framework.Assert;
using static Lab11.Loger.Loger;

namespace Lab11.Tests
{
    [TestClass]
    public class Test1
    {
        private MainPage _mainPage;

        [SetUp]
        public void Setup()
        {
            _mainPage = new MainPage(Driver);
        }

        [Test]
        public void Test()
        {
            Info("Test 1 started.");
            _mainPage.OpenPage();
            _mainPage.SignIn();
            _mainPage.AddFirstItemToWishlist();
            _mainPage.OpenWishlist();
            if (_mainPage.CountWishlistItems() <= 0)
            {
                Info("Test 1 failed.");
                Assert.Fail("Test Failed!");
            }
            else
            {
                Info("Test 1 finished successfully.");
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            QuitDriver();
        }
    }
}
