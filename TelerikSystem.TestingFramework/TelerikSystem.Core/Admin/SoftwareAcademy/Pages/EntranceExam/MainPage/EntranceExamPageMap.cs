using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikSystem.Core.Admin.SoftwareAcademy.Pages.EntranceExam.MainPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using TestingFramework.Core.Base;

    public class EntranceExamPageMap : BaseElementMap
    {
        public HtmlAnchor GetToExams
        {
            get
            {
                return
                    this.Find.AllByTagName<HtmlAnchor>("a")
                        .FirstOrDefault(a => a.InnerText == "Добавяне на нов входен изпит");
            }
        }

        public HtmlAnchor EditExam
        {
            get { return this.Find.ByXPath<HtmlAnchor>("//*[@id='DataGrid']/table/tbody/tr[1]/td[12]/a"); }
        }
    }
}
