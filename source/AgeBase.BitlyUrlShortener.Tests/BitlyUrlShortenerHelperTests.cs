using System;
using System.Configuration;
using AgeBase.BitlyUrlShortener.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgeBase.BitlyUrlShortener.Tests
{
    [TestClass]
    public class BitlyUrlShortenerHelperTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNoParameters()
        {
            BitlyUrlShortenerHelper.ShortenUrl("http://", string.Empty, string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNoApiKey()
        {
            BitlyUrlShortenerHelper.ShortenUrl("http://", string.Empty, "abc");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNoLogin()
        {
            BitlyUrlShortenerHelper.ShortenUrl("http://", "abc", string.Empty);
        }

        [TestMethod]
        public void TestNoLongUrl()
        {
            var result = BitlyUrlShortenerHelper.ShortenUrl(string.Empty, "abc", "abc");
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void TestShortening()
        {
            var result = BitlyUrlShortenerHelper.ShortenUrl("http://www.google.co.uk/",
                ConfigurationManager.AppSettings["BitlyApiKey"],
                ConfigurationManager.AppSettings["BitlyLogin"]);

            Assert.AreNotEqual(string.Empty, result);
        }
    }
}