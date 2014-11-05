namespace TelerikSystem.Core.Admin.BasicModules.Pages.DynamicPages.CreateDynamicPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using System.Threading;
    using TelerikSystem.Core.Admin.BasicModules.Pages.DynamicPages.DynamicPages;
    using TestingFramework.Core.Base;

    public class CreateDynamicPagePage : BasePage<CreateDynamicPagePageMap, CreateDynamicPagePageValidator>
    {
        public override string Url
        {
            get
            {
                return @"http://test.telerikacademy.com/Administration/PagesOld/Create"; 
            }
        }

        public void CreateDynamicPage(string title,string content ,string description, string keyWords, string createdOn, string modifiedOn )
        {
            this.Map.Title.Text = title;
            this.Map.Content.Focus();
            Manager.Current.Desktop.KeyBoard.TypeText(content);
            this.Map.Description.Text = description;
            this.Map.Keywords.Text = keyWords;
            this.Map.CreatedOn.Text = createdOn;
            this.Map.ModifiedOn.Text = modifiedOn;
            this.Map.CreateButton.Click();
            Thread.Sleep(2000);
        }
    }
}