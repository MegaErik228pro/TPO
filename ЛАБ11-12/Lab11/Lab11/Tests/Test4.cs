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
    public class Test4
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
            Info("Test 4 started.");
            _mainPage.OpenPageF();
            _mainPage.OpenProfile();
            if (_mainPage.CheckAuth() == false)
            {
                Info("Test 4 failed.");
                Assert.Fail("Test Failed!");
            }
            else
            {
                Info("Test 4 finished successfully.");
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            QuitDriver();
        }
    }
}
