namespace TelerikSystem.Core.Admin.BasicModules.Pages.Feedback
{
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using Telerik.TestingFramework.Controls.KendoUI;
    using TestingFramework.Core.Base;

    public class FeedbackPageMap : BaseElementMap
    {
        public HtmlSpan HelpButton
        {
            get
            {
                return this.Find.AllByAttributes<HtmlSpan>("class=k-link")
                           .Where(hb => hb.InnerText.Contains("Помощ"))
                           .FirstOrDefault();
            }
        }

        public HtmlAnchor FeedbackUserLink
        {
            get
            {
                return this.Find.AllByTagName<HtmlAnchor>("a")
                           .FirstOrDefault(a => a.InnerText == "Обратна връзка");
            }
        }

        public HtmlTextArea Message
        {
            get
            {
                return this.Find.ById<HtmlTextArea>("FeedbackContent");
            }
        }

        public HtmlInputSubmit SubmitButton
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputSubmit>("value=Изпратете съобщението");
            }
        }

        public HtmlDiv ErrorLengthOfMessage
        {
            get
            {
                return this.Find.ByAttributes<HtmlDiv>("class=validation-summary-errors");
            }
        }

        public HtmlAnchor AdminButton
        {
            get
            {
                return this.Find.AllByAttributes<HtmlAnchor>("class=k-link")
                           .Where(ab => ab.InnerText.Contains("Админ"))
                           .FirstOrDefault();
            }
        }

        public HtmlAnchor FeedbackAdminLink
        {
            get
            {
                return this.Find.AllByAttributes<HtmlAnchor>("class=admin-navigation-link")
                           .Where(ab => ab.InnerText.Contains("Обратна връзка"))
                           .FirstOrDefault();
            }
        }

        public KendoGrid FeedbackGrid
        {
            get
            {
                return this.Find.ById<KendoGrid>("DataGrid");
            }
        }

        public HtmlAnchor EditButton
        {
            get
            {
                return this.Find.ByAttributes<HtmlAnchor>("class=k-button k-button-icontext k-grid-edit");
            }
        }

        public HtmlInputCheckBox PopUpWindowCheckBoxTrue
        {
            get
            {
                return this.Find.ById<HtmlInputCheckBox>("Ready");
            }
        }

        public HtmlAnchor UpdateButton
        {
            get
            {
                return this.Find.ByAttributes<HtmlAnchor>("class=k-button k-button-icontext k-grid-update");
            }
        }
    }
}