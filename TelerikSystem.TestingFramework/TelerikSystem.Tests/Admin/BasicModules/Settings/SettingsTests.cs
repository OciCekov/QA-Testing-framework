namespace TelerikSystem.Tests.Admin.BasicModules.Settings
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TelerikSystem.Core.Admin.BasicModules.Pages.SettingsPage;
    using TelerikSystem.Core.Admin.Pages.ModulesPage;
    using TelerikSystem.Core.Pages.LoginPage;
    using TelerikSystem.Core.Pages.MainPage;
    using TelerikSystem.Core.Pages.SeleniumIdeCoursePage;
    using TelerikSystem.Core.User.SoftwareAcademy.Pages.ApplySofAcademyPage;
    using TestingFramework.Core.Base;
    using TestingFramework.Core.Models;

    [TestClass]
    public class SettingsTests : BaseTest
    {
        private User currentUser;

        public override void TestInit()
        {
            currentUser = GetUser.Admin();
        }

        [TestMethod]
        public void Setting_CanCreateAndModifyNewSetting()
        {
            const string SettingName = "TestSetting";
            const string SettingValue = "SettingValue";
            const string NewSettingName = "NewTestSetting";

            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<SettingsPage>.Instance.CreateNewSetting(SettingName, SettingValue);
            Pages<SettingsPage>.Instance.Validator.AssertSettingPresent(SettingName);
            Pages<SettingsPage>.Instance.ModifySetting(SettingName, NewSettingName);
            Pages<SettingsPage>.Instance.Validator.AssertSettingPresent(NewSettingName);
            Pages<SettingsPage>.Instance.Validator.AssertCanDeleteSetting(NewSettingName);
        }

        [TestMethod]
        public void Setting_NewSettingFieldsAreRequired()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<SettingsPage>.Instance.Navigate();
            Pages<SettingsPage>.Instance.Validator.AssertNewSettingFieldsAreRequired();
        }

        [TestMethod]
        public void Settings_AdminSettingsButtonsExist()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<MainPage>.Instance.Validator.AssertAdminIsVisible();
            Pages<MainPage>.Instance.Map.Admin.Click();
            Pages<ModulesPage>.Instance.Validator.AssertSettingsModuleExists();
            Pages<ModulesPage>.Instance.Map.SettingsModule.Click();
            Pages<SettingsPage>.Instance.Validator.AssertNewSettingButtonIsVisible();
        }

        [TestMethod]
        public void Settings_DoesSoftwareAcademyCandidateFormOpenedFunctionsCorrectly()
        {
            const string SettingName = "IsSoftwareAcademyCandidateFormOpened";

            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<SettingsPage>.Instance.ModifySetting(SettingName, null, "false");
            Pages<ApplySofAcademyPage>.Instance.Navigate();
            Pages<ApplySofAcademyPage>.Instance.Validator.AssertIsNotInCandidatePeriod();
            Pages<SettingsPage>.Instance.ModifySetting(SettingName, null, "true");
            Pages<ApplySofAcademyPage>.Instance.Navigate();
            Pages<ApplySofAcademyPage>.Instance.Validator.AssertIsInCandidatePeriod();
        }

        [TestMethod]
        public void Settings_DoesIsCourseUnenrollmentActiveFunctionsCorrectly()
        {
            const string SettingName = "IsCourseUnenrollmentActive";

            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<SettingsPage>.Instance.ModifySetting(SettingName, null, "false");
            Pages<SeleniumIdePage>.Instance.Validator.AssertUnenrollmentNotActive();
            Pages<SettingsPage>.Instance.ModifySetting(SettingName, null, "true");
            Pages<SeleniumIdePage>.Instance.Validator.AssertUnenrollmentActive();
        }

        [TestMethod]
        public void Settings_DoesFirstHomePageCourseInstanceFunctionsCorrectly()
        {
            const string SettingName = "FirstHomePageCourseInstance";
            const string CourseName = "Курс \"Kids Course\"";
            const int CourseId = 2;

            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<SettingsPage>.Instance.ModifySetting(SettingName, null, "{" + CourseName + "} = {" + CourseId + "}");
            Pages<MainPage>.Instance.Validator.AssertCourseButtonPresent(CourseName, CourseId);
            Pages<SettingsPage>.Instance.ModifySetting(SettingName, null, "{} = {}");
            Pages<MainPage>.Instance.Validator.AssertCourseButtonNotPresent(CourseName, CourseId);
        }

        [TestMethod]
        public void Settings_DoesSecondHomePageCourseInstanceFunctionsCorrectly()
        {
            const string SettingName = "SecondHomePageCourseInstance";
            const string CourseName = "Test Course2";
            const int CourseId = 4;

            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<SettingsPage>.Instance.ModifySetting(SettingName, null, "{" + CourseName + "} = {" + CourseId + "}");
            Pages<MainPage>.Instance.Validator.AssertCourseButtonPresent(CourseName, CourseId);
            Pages<SettingsPage>.Instance.ModifySetting(SettingName, null, "{} = {}");
            Pages<MainPage>.Instance.Validator.AssertCourseButtonNotPresent(CourseName, CourseId);
        }
    }
}
