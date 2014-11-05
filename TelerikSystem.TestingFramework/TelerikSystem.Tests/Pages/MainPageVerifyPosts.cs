using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingFramework.Core.Base;
using TelerikSystem.Core.Pages.MainPage;

namespace TelerikSystem.Tests.Pages
{
    [TestClass]
    public class MainPageVerifyPosts : BaseTest
    {
        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
        public void VerifyFirstPostForum()
        {
            Pages<MainPage>.Instance.Validator.AssertFirstForumPost();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
        public void VerifySecondPostForum()
        {
            Pages<MainPage>.Instance.Validator.AssertFirstForumPost();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
        public void VerifyThirdPostForum()
        {
            Pages<MainPage>.Instance.Validator.AssertFirstForumPost();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
        public void VerifyFirstFacebookForum()
        {
            Pages<MainPage>.Instance.Validator.AssertFirstFacebookPost();
        }
    }
}
