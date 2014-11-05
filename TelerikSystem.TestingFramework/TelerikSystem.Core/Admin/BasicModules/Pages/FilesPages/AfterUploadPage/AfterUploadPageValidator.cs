namespace TelerikSystem.Core.Admin.BasicModules.Pages.FilesPages.AfterUploadPage
{
    using ArtOfTest.Common.UnitTesting;
    using TelerikSystem.Core.Admin.BasicModules.Pages.FilesPages.FilesPage;
    using TestingFramework.Core.Base;

    public class AfterUploadPageValidator
    {
        public void AssertFileIsUploadedMsgAppears()
        {
            Assert.IsTrue(Pages<AfterUploadPage>.Instance.Map.MainSection.InnerText.Contains("Файлът е качен успешно"));
            if (Pages<AfterUploadPage>.Instance.Map.MainSection.InnerText.Contains("Файлът е качен успешно"))
            {
                Pages<FilesPage>.Instance.DeleteLastFileUploaded();
            }
        }
    }
}