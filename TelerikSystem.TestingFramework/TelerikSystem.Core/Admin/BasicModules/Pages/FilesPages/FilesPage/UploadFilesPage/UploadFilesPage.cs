namespace TelerikSystem.Core.Admin.BasicModules.Pages.FilesPages.UploadFilesPage
{
    using TestingFramework.Core.Base;
    using TestingFramework.Core.Extensions;

    public class UploadFilesPage : BasePage<UploadFilesPageMap, UploadFilesPageValidator>
    {
        public override string Url
        {
            get
            {
                return @"http://test.telerikacademy.com/Administration/Files/Upload";
            }
        }

        public void UploadFile(string fileFullName, string description)
        {
            this.Navigate();
            if (fileFullName != null)
            {
                this.Map.FilePicker.UploadFromDataFolder(fileFullName);
            }

            if (description != null)
            {
                this.Map.FileDescription.Text = description;
            }

            this.Map.Submit.Click();
        }
    }
}