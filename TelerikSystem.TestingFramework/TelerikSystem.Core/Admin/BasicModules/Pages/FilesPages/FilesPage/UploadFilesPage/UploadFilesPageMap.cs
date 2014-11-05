namespace TelerikSystem.Core.Admin.BasicModules.Pages.FilesPages.UploadFilesPage
{
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using TestingFramework.Core.Base;

    public class UploadFilesPageMap : BaseElementMap
    {
        public HtmlInputFile FilePicker
        {
            get
            {
                return this.Find.ById<HtmlInputFile>("File");
            }
        }

        public HtmlTextArea FileDescription
        {
            get
            {
                return this.Find.ById<HtmlTextArea>("Description");
            }
        }

        public HtmlInputSubmit Submit
        {
            get
            {
                return this.Find.ById<HtmlInputSubmit>("SendButton");
            }
        }

        public HtmlDiv ValidationProblemsList
        {
            get
            {
                return this.Find.ByAttributes<HtmlDiv>("class=validation-summary-errors");
            }
        }
    }
}