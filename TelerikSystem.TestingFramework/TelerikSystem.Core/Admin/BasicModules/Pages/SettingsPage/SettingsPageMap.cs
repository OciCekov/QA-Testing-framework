namespace TelerikSystem.Core.Admin.BasicModules.Pages.SettingsPage
{
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using Telerik.TestingFramework.Controls.KendoUI;
    using TestingFramework.Core.Base;

    public class SettingsPageMap : BaseElementMap
    {
        public HtmlAnchor NewSetting
        {
            get
            {
                return this.Find.AllByTagName<HtmlAnchor>("a")
                           .Where(a => a.InnerText.Contains("Създай настройка"))
                           .FirstOrDefault();
            }
        }

        public HtmlInputText NewSettingName
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputText>("data-val-required=The Име field is required.");
            }
        }

        public HtmlInputText NewSettingValue
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputText>("data-val-required=The Стойност field is required.");
            }
        }

        public HtmlAnchor Update
        {
            get
            {
                return this.Find.AllByTagName<HtmlAnchor>("a")
                           .Where(a => a.InnerText.Contains("Update"))
                           .FirstOrDefault();
            }
        }

        public KendoGrid SettingsGrid
        {
            get
            {
                return this.Find.ById<KendoGrid>("DataGrid");
            }
        }

        public HtmlDiv NameValidationMessage
        {
            get
            {
                return this.Find.ById<HtmlDiv>("Name_validationMessage");
            }
        }

        public HtmlDiv ValueValidationMessage
        {
            get
            {
                return this.Find.ById<HtmlDiv>("Value_validationMessage");
            }
        }
    }
}