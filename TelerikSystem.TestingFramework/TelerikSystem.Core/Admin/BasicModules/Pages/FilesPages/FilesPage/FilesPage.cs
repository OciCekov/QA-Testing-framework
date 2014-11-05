namespace TelerikSystem.Core.Admin.BasicModules.Pages.FilesPages.FilesPage
{
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using TestingFramework.Core.Base;

    public class FilesPage : BasePage<FilesPageMap, FilesPageValidator>
    {
        public override string Url
        {
            get
            {
                return @"http://test.telerikacademy.com/Administration/Files";
            }
        }

        public void UploadFile()
        {
            this.Navigate();
            this.Map.UploadFile.Click();
        }

        public string GetLastUploadedFileName()
        {
            this.Navigate();
            int gridItems = this.Map.FilesGrid.DataItems.Count;
            string lastUploadedFileName = this.Map.FilesGrid.DataItems[gridItems - 1][0].InnerText;

            return lastUploadedFileName;
        }

        public void DeleteLastFileUploaded()
        {
            this.Navigate();
            AlertDialog confirmDeletionDialog = AlertDialog.CreateAlertDialog(Manager.Current.ActiveBrowser, DialogButton.OK);
            Manager.Current.DialogMonitor.AddDialog(confirmDeletionDialog);
            Manager.Current.DialogMonitor.Start();
            this.Map.LastGridItemDelete.Click();
            confirmDeletionDialog.WaitUntilHandled();
            Manager.Current.DialogMonitor.Stop();
        }
    }
}