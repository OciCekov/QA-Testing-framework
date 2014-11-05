namespace TelerikSystem.Core.Admin.BasicModules.Pages.FilesPages.AfterUploadPage
{
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using TestingFramework.Core.Base;

    public class AfterUploadPageMap : BaseElementMap
    {
        public HtmlContainerControl MainSection
        {
            get
            {
                return this.Find.ById<HtmlContainerControl>("MainContent");
            }
        }

        public HtmlAnchor FilePath
        {
            get
            {
                return this.Find.ById<HtmlContainerControl>("MainContent")
                           .Find.AllByTagName<HtmlAnchor>("a")
                           .FirstOrDefault();
            }
        }
    }
}