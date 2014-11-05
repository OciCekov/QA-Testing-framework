namespace TelerikSystem.Tests.Admin.BasicModules.FilesPage
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TelerikSystem.Core.Admin.BasicModules.Pages.FilesPages.AfterUploadPage;
    using TelerikSystem.Core.Admin.BasicModules.Pages.FilesPages.FilesPage;
    using TelerikSystem.Core.Admin.BasicModules.Pages.FilesPages.UploadFilesPage;
    using TelerikSystem.Core.Admin.Pages.ModulesPage;
    using TelerikSystem.Core.Pages.LoginPage;
    using TelerikSystem.Core.Pages.MainPage;

    using TestingFramework.Core.Base;
    using TestingFramework.Core.Models;

    [TestClass]
    public class FilesPageTests : BaseTest
    {
        private const string DocFileName = "test.docx";
        private const string JpgFileName = "test.jpg";
        private const string DllFileName = "test.dll";
        private const string ExeFileName = "test.exe";
        private const string JsFileName = "test.js";
        private const string Mp4FileName = "test.mp4";
        private const string PptFileName = "test.ppt";
        private const string PdfFileName = "test.pdf";
        private const string XlsFileName = "test.xls";
        private const string RarFileName = "test.rar";
        private const string ZipFileName = "test.zip";
        private const string InvalidFileName = "invalid";

        private User currentUser;

        public override void TestInit()
        {
            this.currentUser = GetUser.Admin();
        }

        [TestMethod]
        public void FilesUpload_UploadDocMessageAppers()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<UploadFilesPage>.Instance.UploadFile(DocFileName, "random description");
            Pages<AfterUploadPage>.Instance.Validator.AssertFileIsUploadedMsgAppears();
        }

        [TestMethod]
        public void FilesUpload_UploadDocIsPresent()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<UploadFilesPage>.Instance.UploadFile(DocFileName, "random description");
            Pages<FilesPage>.Instance.Validator.AssertUploadedFileIsPresentByHashedName();
        }

        [TestMethod]
        public void FilesUpload_UploadJpgMessageAppers()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<UploadFilesPage>.Instance.UploadFile(JpgFileName, "random description");
            Pages<AfterUploadPage>.Instance.Validator.AssertFileIsUploadedMsgAppears();
        }

        [TestMethod]
        public void FilesUpload_UploadJpgIsPresent()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<UploadFilesPage>.Instance.UploadFile(JpgFileName, "random description");
            Pages<FilesPage>.Instance.Validator.AssertUploadedFileIsPresentByHashedName();
        }

        [TestMethod]
        public void FilesUpload_UploadDllMessageAppers()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<UploadFilesPage>.Instance.UploadFile(DllFileName, "random description");
            Pages<AfterUploadPage>.Instance.Validator.AssertFileIsUploadedMsgAppears();
        }

        [TestMethod]
        public void FilesUpload_UploadDllIsPresent()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<UploadFilesPage>.Instance.UploadFile(DllFileName, "random description");
            Pages<FilesPage>.Instance.Validator.AssertUploadedFileIsPresentByHashedName();
        }

        [TestMethod]
        public void FilesUpload_UploadExeMessageAppers()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<UploadFilesPage>.Instance.UploadFile(ExeFileName, "random description");
            Pages<AfterUploadPage>.Instance.Validator.AssertFileIsUploadedMsgAppears();
        }

        [TestMethod]
        public void FilesUpload_UploadExeIsPresent()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<UploadFilesPage>.Instance.UploadFile(ExeFileName, "random description");
            Pages<FilesPage>.Instance.Validator.AssertUploadedFileIsPresentByHashedName();
        }

        [TestMethod]
        public void FilesUpload_UploadJsMessageAppers()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<UploadFilesPage>.Instance.UploadFile(JsFileName, "random description");
            Pages<AfterUploadPage>.Instance.Validator.AssertFileIsUploadedMsgAppears();
        }

        [TestMethod]
        public void FilesUpload_UploadJsIsPresent()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<UploadFilesPage>.Instance.UploadFile(JsFileName, "random description");
            Pages<FilesPage>.Instance.Validator.AssertUploadedFileIsPresentByHashedName();
        }

        [TestMethod]
        public void FilesUpload_UploadMp4MessageAppers()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<UploadFilesPage>.Instance.UploadFile(Mp4FileName, "random description");
            Pages<AfterUploadPage>.Instance.Validator.AssertFileIsUploadedMsgAppears();
        }

        [TestMethod]
        public void FilesUpload_UploadMp4IsPresent()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<UploadFilesPage>.Instance.UploadFile(Mp4FileName, "random description");
            Pages<FilesPage>.Instance.Validator.AssertUploadedFileIsPresentByHashedName();
        }

        [TestMethod]
        public void FilesUpload_UploadPptMessageAppers()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<UploadFilesPage>.Instance.UploadFile(PptFileName, "random description");
            Pages<AfterUploadPage>.Instance.Validator.AssertFileIsUploadedMsgAppears();
        }

        [TestMethod]
        public void FilesUpload_UploadPptIsPresent()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<UploadFilesPage>.Instance.UploadFile(PptFileName, "random description");
            Pages<FilesPage>.Instance.Validator.AssertUploadedFileIsPresentByHashedName();
        }

        [TestMethod]
        public void FilesUpload_UploadPdfMessageAppers()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<UploadFilesPage>.Instance.UploadFile(PdfFileName, "random description");
            Pages<AfterUploadPage>.Instance.Validator.AssertFileIsUploadedMsgAppears();
        }

        [TestMethod]
        public void FilesUpload_UploadPdfIsPresent()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<UploadFilesPage>.Instance.UploadFile(PdfFileName, "random description");
            Pages<FilesPage>.Instance.Validator.AssertUploadedFileIsPresentByHashedName();
        }

        [TestMethod]
        public void FilesUpload_UploadXlsMessageAppers()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<UploadFilesPage>.Instance.UploadFile(XlsFileName, "random description");
            Pages<AfterUploadPage>.Instance.Validator.AssertFileIsUploadedMsgAppears();
        }

        [TestMethod]
        public void FilesUpload_UploadXlsIsPresent()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<UploadFilesPage>.Instance.UploadFile(XlsFileName, "random description");
            Pages<FilesPage>.Instance.Validator.AssertUploadedFileIsPresentByHashedName();
        }

        [TestMethod]
        public void FilesUpload_UploadRarMessageAppers()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<UploadFilesPage>.Instance.UploadFile(RarFileName, "random description");
            Pages<AfterUploadPage>.Instance.Validator.AssertFileIsUploadedMsgAppears();
        }

        [TestMethod]
        public void FilesUpload_UploadRarIsPresent()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<UploadFilesPage>.Instance.UploadFile(RarFileName, "random description");
            Pages<FilesPage>.Instance.Validator.AssertUploadedFileIsPresentByHashedName();
        }

        [TestMethod]
        public void FilesUpload_UploadZipMessageAppers()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<UploadFilesPage>.Instance.UploadFile(ZipFileName, "random description");
            Pages<AfterUploadPage>.Instance.Validator.AssertFileIsUploadedMsgAppears();
        }

        [TestMethod]
        public void FilesUpload_UploadZipIsPresent()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<UploadFilesPage>.Instance.UploadFile(ZipFileName, "random description");
            Pages<FilesPage>.Instance.Validator.AssertUploadedFileIsPresentByHashedName();
        }

        [TestMethod]
        public void FilesUpload_CanNavigateToFilesUploadPage()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<MainPage>.Instance.Map.Admin.Click();
            Pages<ModulesPage>.Instance.Map.FilesUploadModule.Click();
            Pages<FilesPage>.Instance.Validator.AssertIsOnFileUploadPage();
        }

        [TestMethod]
        public void FilesUpload_PickFileRequiredAppears()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<FilesPage>.Instance.UploadFile();
            Pages<UploadFilesPage>.Instance.UploadFile(null, "random description");
            Pages<UploadFilesPage>.Instance.Validator.AssertPickFileRequiredMsgAppers();
        }

        [TestMethod]
        public void FilesUpload_DescriptionRequiredAppears()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<FilesPage>.Instance.UploadFile();
            Pages<UploadFilesPage>.Instance.UploadFile(DocFileName, null);
            Pages<UploadFilesPage>.Instance.Validator.AssertDescriptionRequiredMsgAppers();
        }

        [TestMethod]
        public void FilesUpload_RequiredMessagesAppers()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<FilesPage>.Instance.UploadFile();
            Pages<UploadFilesPage>.Instance.UploadFile(null, null);
            Pages<UploadFilesPage>.Instance.Validator.AssertDescriptionRequiredMsgAppers();
            Pages<UploadFilesPage>.Instance.Validator.AssertPickFileRequiredMsgAppers();
        }

        [TestMethod]
        public void FilesUpload_InvalidFormatNotUploaded()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<UploadFilesPage>.Instance.UploadFile(InvalidFileName, "random description");
            Pages<FilesPage>.Instance.Validator.AssertFileNotPresentByOriginalName(InvalidFileName);
        }

        [TestMethod]
        public void KendoTest()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<FilesPage>.Instance.Navigate();
        }
    }
}
