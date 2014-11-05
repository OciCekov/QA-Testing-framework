namespace TelerikSystem.Core.Admin.Pages.ModulesPage
{
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using TestingFramework.Core.Base;

    public class ModulesPageMap : BaseElementMap
    {
        public HtmlAnchor SettingsModule
        {
            get
            {
                return this.Find.AllByExpression<HtmlAnchor>("tagname=a", "class=admin-navigation-link")
                           .Where(a => a.InnerText.Contains("Настройки"))
                           .FirstOrDefault();
            }
        }

        public HtmlAnchor FilesUploadModule
        {
            get
            {
                return this.Find.AllByExpression<HtmlAnchor>("tagname=a", "class=admin-navigation-link")
                           .Where(a => a.InnerText.Contains("Качване на файл"))
                           .FirstOrDefault();
            }
        }
    }
}