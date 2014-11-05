namespace TelerikSystem.Tests.Admin.SoftwareAcademy.EntranceExam
{
    using System;
    using System.Globalization;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TelerikSystem.Core.Admin.SoftwareAcademy.Pages.EntranceExam.CreateNewExamPage;
    using TelerikSystem.Core.Pages.LoginPage;
    using TestingFramework.Core.Base;
    using TestingFramework.Core.Models;

    [TestClass]
    public class EntranceExamTests : BaseTest
    {
        private string startDate;
        private string endDate;
        private User currentUser;

        [TestInitialize]
        public override void TestInit()
        {
            currentUser = GetUser.Admin();
            startDate = DateTime.Now.AddDays(2)
                .ToString("dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
            endDate = DateTime.Now.AddDays(2)
                .AddHours(3)
                .ToString("dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
        }
       
        [TestMethod]
        public void EntranceExam_CreateNewExam()
        {
            var page = Pages<NewExamPage>.Instance;
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            page.Navigate();
            page.Validator.AssertTitleIsVisible();
            page.CreateNewExam(startDate, endDate);
        }

        [TestMethod]
        public void EntranceExam_CorrectExamDateIsSet()
        {
            var page = Pages<NewExamPage>.Instance;
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            //page.Validator.AssertEditExamTitleIsVisible(page);
            //page.CreateNewExam(startDate, endDate);
        }
    }
}