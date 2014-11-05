namespace TelerikSystem.Core.User.SoftwareAcademy.Pages.ApplySofAcademyPage.AcceptPolicy
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TestingFramework.Core.Base;

    [TestClass]
    public class AcceptTermsPart : BasePage<AcceptTermsPartMap, ApplySofAcademyPageValidator>
    {
        public override string Url
        {
            get
            {
                return @"http://test.telerikacademy.com/SoftwareAcademy/Candidate"; // това не ми трябва !!!!
            }
        }

        public void AcceptTerms()
        {
            this.Map.AcceptTerms.Click();
        }
    }
}