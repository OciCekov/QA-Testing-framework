namespace TelerikSystem.Core.Admin.BasicModules.Pages.FilesPages.AfterUploadPage
{
    using TestingFramework.Core.Base;

    public class AfterUploadPage : BasePage<AfterUploadPageMap, AfterUploadPageValidator>
    {
        public override string Url
        {
            get
            {
                return null; 
            }
        }

        public string GetUploadedFileName()
        {
            string[] filePathSplit = this.Map.FilePath.InnerText.Split('/');

            return filePathSplit[filePathSplit.Length - 1].Split('.')[0];
        }
    }
}