namespace TelerikSystem.Core.Admin.BasicModules.Pages.FilesPages.FilesPage
{
    using System.Collections.Generic;
    using ArtOfTest.Common.UnitTesting;
    using ArtOfTest.WebAii.Core;
    using Telerik.TestingFramework.Controls.KendoUI;
    using TelerikSystem.Core.Admin.BasicModules.Pages.FilesPages.AfterUploadPage;
    using TestingFramework.Core.Base;

    public class FilesPageValidator
    {
        public void AssertUploadedFileIsPresentByHashedName()
        {
            string uploadedFileName = Pages<AfterUploadPage>.Instance.GetUploadedFileName();
            string lastGridItemName = Pages<FilesPage>.Instance.GetLastUploadedFileName();

            Assert.AreEqual(uploadedFileName, lastGridItemName);
            if (uploadedFileName == lastGridItemName)
            {
                Pages<FilesPage>.Instance.DeleteLastFileUploaded();
            }
        }

        public void AssertFileNotPresentByOriginalName(string fileName)
        {
            if (Manager.Current.ActiveBrowser.Url != Pages<FilesPage>.Instance.Url)
            {
                Pages<FilesPage>.Instance.Navigate();
            }

            var fileNames = new List<string>();
            foreach (KendoGridDataItem item in Pages<FilesPage>.Instance.Map.FilesGrid.DataItems)
            {
                fileNames.Add(item[1].InnerText);
            }

            Assert.IsFalse(fileNames.Contains(fileName));
        }

        public void AssertIsOnFileUploadPage()
        {
            Assert.IsTrue(Pages<FilesPage>.Instance.Map.MainContent.InnerText.Contains("Качи файл"));
        }
    }
}