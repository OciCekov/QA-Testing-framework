namespace TelerikSystem.Core.User.SoftwareAcademy.Pages.ApplySofAcademyPage.Documents
{
    using System;
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TestingFramework.Core.Base;

    [TestClass]
    public class DocumentsPartMap : BaseElementMap
    {
        public HtmlInputFile Cl
        {
            get
            {
                return this.Find.ById<HtmlInputFile>("CoverLetter");
            }
        }

        public HtmlInputFile Cv
        {
            get
            {
                return this.Find.ById<HtmlInputFile>("CV");
            }
        }

        public HtmlInputFile AddDoc
        {
            get
            {
                return this.Find.ById<HtmlInputFile>("AdditionalDocuments");
            }
        }
    }
}