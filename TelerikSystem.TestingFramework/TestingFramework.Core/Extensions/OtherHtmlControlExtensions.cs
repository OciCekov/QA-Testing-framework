namespace TestingFramework.Core.Extensions
{
    using System.IO;

    using ArtOfTest.WebAii.Controls.HtmlControls;

    public static class OtherHtmlControlExtensions
    {
        public static T UploadFromDataFolder<T>(this T control, string fileFullName, string nestedFoldersPath = null) where T : HtmlInputFile
        {
            if (string.IsNullOrEmpty(nestedFoldersPath))
            {
                control.Upload(Path.GetFullPath(@"..\..\Data\" + fileFullName), 1000);
            }
            else
            {
                control.Upload(Path.GetFullPath(@"..\..\Data\" + nestedFoldersPath + fileFullName), 1000);
            }

            return control;
        }
    }
}