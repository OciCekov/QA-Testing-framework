using ArtOfTest.WebAii.Controls.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.TestingFramework.Controls.KendoUI;
using TestingFramework.Core.Base;

namespace TelerikSystem.Core.Admin.Certificates.Pages
{
    public class CertificatesPageMap : BaseElementMap
    {

        public KendoGrid CertificatesGrid
        {
            get
            {
                return Find.ById<KendoGrid>("DataGrid");
            }
        }

        public HtmlAnchor AddButton
        {
            get { return Find.ByAttributes<HtmlAnchor>("href=/Administration_Certificates/Certificates/Read?DataGrid-mode=insert"); }
        }

        public HtmlTable GridData
        {
            get { return Find.ByAttributes<HtmlTable>("role=treegrid"); }
        }

        public HtmlSpan LoadCertificateTypes
        {
            get { return Find.ByAttributes<HtmlSpan>("class=k-icon k-i-arrow-s"); }
        }

        public HtmlUnorderedList CertificateType
        {
            get { return Find.ById<HtmlUnorderedList>("CertificateTypeId_listbox"); }
        }

        public HtmlInputText FullName
        {
            get { return Find.ById<HtmlInputText>("FullName"); }
        }

        public HtmlInputCheckBox IsDeleted
        {
            get { return Find.ById<HtmlInputCheckBox>("IsDeleted"); }
        }

        public HtmlInputCheckBox IsPublic
        {
            get { return Find.ById<HtmlInputCheckBox>("IsPublic"); }
        }

        public HtmlInputText UserName
        {
            get { return Find.ById<HtmlInputText>("CertifiedUserUsername"); }
        }

        public HtmlAnchor UpdateButton
        {
            get { return Find.ByAttributes<HtmlAnchor>("class=k-button k-button-icontext k-grid-update"); }
        }

    }
}
