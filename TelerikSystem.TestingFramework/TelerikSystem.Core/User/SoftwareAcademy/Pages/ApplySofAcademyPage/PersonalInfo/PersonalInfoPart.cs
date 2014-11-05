namespace TelerikSystem.Core.User.SoftwareAcademy.Pages.ApplySofAcademyPage.PersonalInfo
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TestingFramework.Core.Extensions;

    [TestClass]
    public class PersonalInfoPart
    {
        private static PersonalInfoPart instance;

        public static PersonalInfoPart Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PersonalInfoPart();
                }

                return instance;
            }
        }

        public PersonalInfoPartMap Map
        {
            get
            {
                return new PersonalInfoPartMap();
            }
        }

        public void SetValidInputPersonalInfo()
        {
            this.Map.MiddleName.Text = "сссссс";
            this.Map.Picture.UploadFromDataFolder("picture.jpg");
            //// this.Map.Picture.Upload(@"C:\Data\5.jpg", 1000);
            this.Map.SetGender(false);
            this.Map.SetOccupation(OccupationType.Студент);
            this.Map.BirthDay.Text = "08/08/1988";
            this.Map.Phone.Text = "0888123456";
            this.Map.SetBirthPlace(BirthPlace.Аксаково);
            this.Map.SetUniversity(University.АграренУниверситетПловдив);
            this.Map.Faculty.Text = "Дентален";
            this.Map.UniversitySpeciality.Text = "Лицева херургия";
            this.Map.SchoolName.Text = "123";
        }
    }
}