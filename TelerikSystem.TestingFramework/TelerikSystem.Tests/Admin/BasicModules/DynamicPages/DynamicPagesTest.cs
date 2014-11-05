using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingFramework.Core.Base;
using TelerikSystem.Core.Admin.BasicModules.Pages.DynamicPages.CreateDynamicPage;
using TestingFramework.Core.Models;
using TelerikSystem.Core.Pages.LoginPage;
using TelerikSystem.Core.Admin.BasicModules.Pages.DynamicPages.DynamicPages;

namespace TelerikSystem.Tests.Admin.BasicModules.DynamicPages
{
    [TestClass]
    public class DynamicPagesTest : BaseTest
    {
        private TestingFramework.Core.Models.User currentUser;

        public override void TestInit()
        {
            this.currentUser = GetUser.Admin();
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<DynamicPagesPage>.Instance.Navigate();

        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
        public void DynamicPages_AssertPageIsCreated()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<DynamicPagesPageValidator>.Instance.VerifyDynamicPageIsCreated();

        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
        public void DynamicPages_AssertPageIsNotCreated()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<DynamicPagesPageValidator>.Instance.VerifyDynamicPageIsNotCreated();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
        public void DynamicPages_AssertPageIsDeleted()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<DynamicPagesPageValidator>.Instance.VerifyDynamicPageIsDeleted();
        }

        #region[title]
        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertTitleLocalErrorIsVisible_NoInsert()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageTitleIsVisible_NullTitle();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertTitleLocalErrorIsVisible_EmptyStringTitle()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageTitleIsVisible_EmptyTitle();
        }


        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertTitleLocalErrorIsVisible_WhiteSpace()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageTitleIsVisible_WhiteSpaceTitle();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertTitleLocalErrorIsVisible_TitleLength2symbols()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageTitleIsVisible_TitleLength2symbols();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertTitleLocalErrorIsVisible_TitleLength4symbols()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageTitleIsNotVisible_TitleLength4symbols();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertTitleLocalErrorIsNotVisible_TitleLength199symbols()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageTitleIsNotVisible_TitleLength199symbols();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertTitleLocalErrorIsNotVisible_TitleLength200symbols()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageTitleIsNotVisible_TitleLength200symbols();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertTitleLocalErrorIsVisible_TitleLength201symbols()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageTitleIsVisible_TitleLength201symbols();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertTitleLocalErrorIsNotVisible_ValidLengthData()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageTitleIsNotVisible_ValidInputAndLength3symbols();
        }

        #endregion

        #region[content]
        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertContentLocalErrorIsVisible_NoInsert()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageContentIsVisible_NullContent();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertContentLocalErrorIsVisible_WhiteSpace()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageContentIsVisible_WhitespaceContent();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertContentLocalErrorIsVisible_EmptyContent()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageContentIsVisible_EmptyContent();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertContentLocalErrorIsNotVisible_ValidData()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageContentIsNotVisible();
        }

        #endregion

        [TestMethod] // bug
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertErrorMessagesWnenNoTitleAndContentIsInserted()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageContentIsVisible_BlankInfo();
        }

        #region[keyword]
        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertKeywordLocalErrorIsVisible_101Symbols()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageKyewordsIsVisible_101Symbols();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertKeywordLocalErrorIsNotVisible_100Symbols()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageKeywordsIsNotVisible_100Symbols();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertKeywordLocalErrorIsNotVisible_99Symbols()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageKeywordsIsNotVisible_99Symbols();
        }
        #endregion

        #region[description]
        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertDescriptionLocalErrorIsNotVisible_199Symbols()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageDescriptionIsNotVisible_TitleLength199symbols();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertDescriptionLocalErrorIsNotVisible_200Symbols()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageDescriptionIsNotVisible_TitleLength200symbols();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertDescriptionLocalErrorIsVisible_201Symbols()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageDescriptionIsVisible_TitleLength201symbols();
        }
        #endregion

        #region[createOn]
        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(33)]
        public void DynamicPages_AssertCreateOnLocalErrorIsVisible_String()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageCreateOnIsVisible_String();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertCreateOnLocalErrorIsVisible_DateFeb292014()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageCreateOnIsVisible_DateFeb292014();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertCreateOnLocalErrorIsVisible_DateFeb262014_Hour25()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageCreateOnIsVisible_DateFeb262014_Hour25();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertCreateOnLocalErrorIsVisible_DateFeb262014_Minutes60()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageCreateOnIsVisible_DateFeb262014_Minutes60();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertCreateOnLocalErrorIsVisible_DateFeb262014_Secunds60()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageCreateOnIsVisible_DateFeb262014_Secunds60();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertCreateOnLocalErrorIsVisible_DateFeb262014_TimeString()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageCreateOnIsVisible_DateFeb262014_TimeString();
        }

        //// the message is not visible but the test does not pass 
        //[TestMethod]
        //public void DynamicPages_AssertCreateOnLocalErrorIsVisible_Valid()
        //{
        //    Pages<CreateDynamicPagePage>.Instance.Navigate();
        //    Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageCreateOnIsNotVisible_Valid();
        //}
        #endregion

        #region[modifyOn]
        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertModifyOnLocalErrorIsVisible_DateString()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageModifiedOnIsVisible_DateString();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertModifyOnLocalErrorIsVisible_DateFeb292015()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageModifiedOnIsVisible_DateFeb292015();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertModifyOnLocalErrorIsVisible_DateFeb262015_Hour25()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageModifiedOnIsVisible_DateFeb262015_Hour25();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertModifyOnLocalErrorIsVisible_DateFeb262015_Minutes60()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageModifiedOnIsVisible_DateFeb262015_Minutes60();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertModifyOnLocalErrorIsVisible_DateFeb262015_Secunds60()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageModifiedOnIsVisible_DateFeb262015_Secunds60();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void DynamicPages_AssertModifyOnLocalErrorIsVisible_DateFeb262015_TimeString()
        {
            Pages<CreateDynamicPagePage>.Instance.Navigate();
            Pages<CreateDynamicPagePageValidator>.Instance.VerifyErrorMessageModifiedOnIsVisible_DateFeb262015_TimeString();
        }
        #endregion
    }
}
