using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core.Base;

namespace TelerikSystem.Core.Admin.Certificates.Pages
{
    public class CertificatesPage : BasePage<CertificatesPageMap, CertificatesPageValidator>
    {
        public override string Url
        {
            get { return "http://test.telerikacademy.com/Administration_Certificates/Certificates"; }
        }

        public void AddCertificate(int certificateTypeIndex, string fullName, string userName, bool isPublic, bool isDeleted )
        {
            var keyBoard = Manager.Current.Desktop.KeyBoard;

            Map.AddButton.Click();
            Map.LoadCertificateTypes.Click();
            Map.CertificateType.Items[certificateTypeIndex].Click();

            Map.FullName.MouseClick();
            keyBoard.TypeText(fullName);

            Map.UserName.MouseClick();
            keyBoard.TypeText(userName);

            Map.IsDeleted.Checked = isDeleted;
            Map.IsPublic.Checked = isPublic;

            Map.UpdateButton.Click();
        }

    }
}
