namespace TelerikSystem.Core.User.SoftwareAcademy.Pages.ApplySofAcademyPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TestingFramework.Core.Base;

    [TestClass]
    public class ApplySofAcademyPageMap : BaseElementMap
    {
        public HtmlInputSubmit ApplyButton
        {
            get
            {
                return this.Find.ById<HtmlInputSubmit>("SendButton");
            }
        }

        public HtmlContainerControl MainContent
        {
            get
            {
                return this.Find.ById<HtmlContainerControl>("MainContent");
            }
        }

        public HtmlDiv MainMessage
        {
            get
            {
                return this.Find.ByExpression<HtmlDiv>("class=validation-summary-errors");
            }
        }
    }
}