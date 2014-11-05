namespace TelerikSystem.Core.Admin.BasicModules.Pages.Auditoriums
{
    using System.Collections.Generic;
    using System.Linq;

    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32;
    using ArtOfTest.WebAii.Win32.Dialogs;

    using TestingFramework.Core.Base;
    using TestingFramework.Core.Models;

    public class AuditoriumPage : BasePage<AuditoriumPageMap, AuditoriumsPageValidator>
    {
        public override string Url
        {
            get
            {
                return @"http://test.telerikacademy.com/Administration_Courses/TrainingRooms";
            }
        }

        public void AddAuditorium(string name, string address, string capacity, string equipment)
        {
            KeyBoard keyBoard = Manager.Current.Desktop.KeyBoard;

            this.Map.AddAuditoriumButton.Click();

            this.Map.NameInput.MouseClick();
            keyBoard.TypeText(name);

            this.Map.AddressInput.MouseClick();
            keyBoard.TypeText(address);

            this.Map.CapacityInput.MouseClick();
            keyBoard.TypeText(capacity);

            this.Map.EquipmentInput.MouseClick();
            keyBoard.TypeText(equipment);

            this.Map.UpdateButton.Click();
        }

        public IEnumerable<Auditorium> GetAllAuditoriums()
        {
            return this.Map.ContentTable.Rows.Select(Auditorium.Parse);
        }

        public void DeleteAuditorium(int id)
        {
            var dialog = new AlertDialog(Manager.Current.ActiveBrowser, DialogButton.OK);
            Manager.Current.DialogMonitor.AddDialog(dialog);
            Manager.Current.DialogMonitor.Start();
            this.Map.GetDeleteButtonOf(id).Click();
            dialog.WaitUntilHandled();
        }
    }
}