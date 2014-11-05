namespace TelerikSystem.Core.User.SoftwareAcademy.Pages.ApplySofAcademyPage.Documents
{
    using System;
    
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TestingFramework.Core.Base;
    using TestingFramework.Core.Extensions;

    [TestClass]
    public class DocumentsPart : BasePage<DocumentsPartMap, ApplySofAcademyPageValidator>
    {
        public override string Url
        {
            get
            {
                return @"http://test.telerikacademy.com/SoftwareAcademy/Candidate"; // това не ми трябва !!!!
            }
        }

        public void SetValidDocuments()
        {
            this.Map.Cv.UploadFromDataFolder("CV.docx");
            this.Map.Cl.UploadFromDataFolder("CL.docx");
        }
    }
}