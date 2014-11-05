namespace TelerikSystem.Core.User.SoftwareAcademy.Pages.ApplySofAcademyPage
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TestingFramework.Core.Base;

    [TestClass]
    public class ApplySofAcademyPage : BasePage<ApplySofAcademyPageMap, ApplySofAcademyPageValidator>
    {
        public override string Url
        {
            get
            {
                return @"http://test.telerikacademy.com/SoftwareAcademy/Candidate";
            }
        }
    }
}