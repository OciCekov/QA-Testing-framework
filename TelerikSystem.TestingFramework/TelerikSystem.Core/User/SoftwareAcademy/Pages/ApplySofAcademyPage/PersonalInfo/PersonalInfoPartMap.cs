namespace TelerikSystem.Core.User.SoftwareAcademy.Pages.ApplySofAcademyPage.PersonalInfo
{
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TestingFramework.Core.Base;

    [TestClass]
    public class PersonalInfoPartMap : BaseElementMap
    {
        public HtmlInputText MiddleName
        {
            get
            {
                return this.Find.ById<HtmlInputText>("SecondName");
            }
        }

        public HtmlInputFile Picture
        {
            get
            {
                return this.Find.ById<HtmlInputFile>("Picture");
            }
        }

        public HtmlInputText BirthDay
        {
            get
            {
                return this.Find.ById<HtmlInputText>("BirthDay");
            }
        }

        public HtmlInputText Phone
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Phone");
            }
        }

        public HtmlInputText Faculty
        {
            get
            {
                return this.Find.ById<HtmlInputText>("FacultyName");
            }
        }

        public HtmlInputText UniversitySpeciality
        {
            get
            {
                return this.Find.ById<HtmlInputText>("UniversitySpeciality");
            }
        }

        public HtmlInputText SchoolName
        {
            get
            {
                return this.Find.ById<HtmlInputText>("SchoolName");
            }
        }

        public void SetGender(bool isMale = false)
        {
            if (isMale)
            {
                this.Find.ById<HtmlInputRadioButton>("IsMale_True").Click();
            }

            this.Find.ById<HtmlInputRadioButton>("IsMale_False").Click();
        }

        public void SetOccupation(OccupationType occupation)
        {
            HtmlSpan occupationInput = this.Find.AllByTagName<HtmlSpan>("span").Where(s => s.InnerText.Contains("Изберете занимание")).FirstOrDefault();
            occupationInput.Click();

            HtmlUnorderedList occupationList = this.Find.ById<HtmlUnorderedList>("WorkEducationStatusId_listbox");

            switch (occupation)
            {
                case OccupationType.Ученик:
                    occupationList.Find.ByContent<HtmlListItem>("Ученик").Click();
                    break;
                case OccupationType.Студент:
                    occupationList.Find.ByContent<HtmlListItem>("Студент").Click();
                    break;
                case OccupationType.Работещ:
                    occupationList.Find.ByContent<HtmlListItem>("Работещ").Click();
                    break;
                default:
                    occupationList.Find.ByContent<HtmlListItem>("Друго").Click();
                    break;
            }
        }

        public void SetBirthPlace(BirthPlace birthPlace)
        {
            HtmlSpan birthPlaceInput = this.Find.AllByTagName<HtmlSpan>("span").Where(s => s.InnerText.Contains("Изберете град")).FirstOrDefault();
            birthPlaceInput.Click();

            HtmlUnorderedList birthPlaceList = this.Find.ById<HtmlUnorderedList>("CityId_listbox");

            switch (birthPlace)
            {
                case BirthPlace.Айтос:
                    birthPlaceList.Find.ByContent<HtmlListItem>("Айтос").Click();
                    break;
                case BirthPlace.Аксаково:
                    birthPlaceList.Find.ByContent<HtmlListItem>("Аксаково").Click();
                    break;
                case BirthPlace.Алфатар:
                    birthPlaceList.Find.ByContent<HtmlListItem>("Алфатар").Click();
                    break;
                case BirthPlace.Антоново:
                    birthPlaceList.Find.ByContent<HtmlListItem>("Антоново").Click();
                    break;
                default:
                    birthPlaceList.Find.ByContent<HtmlListItem>("Антоново").Click();
                    break;
            }
        }

        public void SetUniversity(University university)
        {
            HtmlSpan universityInput = this.Find.AllByTagName<HtmlSpan>("span").Where(s => s.InnerText.Contains("Изберете университет")).FirstOrDefault();
            universityInput.Click();

            HtmlUnorderedList universityList = this.Find.ById<HtmlUnorderedList>("UniversityId_listbox");

            switch (university)
            {
                case University.АграренУниверситетПловдив:
                    universityList.Find.ByContent<HtmlListItem>("Аграрен университет - Пловдив").Click();
                    break;
                case University.АкадемияЗаМузикалноТанцовоИзобразителноИзкуствоПловдив:
                    universityList.Find.ByContent<HtmlListItem>("Академия за музикално, танцово и изобразително изкуство - Пловдив").Click();
                    break;
                case University.АкадемияНаМврСофия:
                    universityList.Find.ByContent<HtmlListItem>("Академия на МВР - София").Click();
                    break;
                default:
                    universityList.Find.ByContent<HtmlListItem>("Американски университет в България - Благоевград").Click();
                    break;
            }
        }
    }
}