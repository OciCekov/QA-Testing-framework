namespace TelerikSystem.Core.Admin.BasicModules.Pages.SettingsPage
{
    using System.Linq;
    using ArtOfTest.Common.UnitTesting;
    using TestingFramework.Core.Base;
    using TestingFramework.Core.Extensions;

    public class SettingsPageValidator
    {
        public void AssertSettingPresent(string settingName)
        {
            Assert.IsTrue(Pages<SettingsPage>.Instance.IsSettingPresent(settingName));
        }

        public void AssertNewSettingFieldsAreRequired()
        {
            Pages<SettingsPage>.Instance.Map.NewSetting.Click();
            Pages<SettingsPage>.Instance.Map.Update.Click();
            Assert.IsTrue(Pages<SettingsPage>.Instance.Map.NameValidationMessage.IsVisible());
            Assert.IsTrue(Pages<SettingsPage>.Instance.Map.ValueValidationMessage.IsVisible());

            Pages<SettingsPage>.Instance.Map.NewSettingName.Text = "ValidName";
            Pages<SettingsPage>.Instance.Map.NewSettingName.FireChange();
            Pages<SettingsPage>.Instance.Map.Update.Click();
            Assert.IsTrue(Pages<SettingsPage>.Instance.Map.ValueValidationMessage.IsVisible());

            Pages<SettingsPage>.Instance.Map.NewSettingName.Text = string.Empty;
            Pages<SettingsPage>.Instance.Map.NewSettingName.FireChange();
            Pages<SettingsPage>.Instance.Map.NewSettingValue.Text = "ValidValue";
            Pages<SettingsPage>.Instance.Map.NewSettingValue.FireChange();
            Pages<SettingsPage>.Instance.Map.Update.Click();
            Assert.IsTrue(Pages<SettingsPage>.Instance.Map.NameValidationMessage.IsVisible());
        }

        public void AssertCanDeleteSetting(string name)
        {
            Pages<SettingsPage>.Instance.DeleteSetting(name);
            Assert.IsFalse(Pages<SettingsPage>.Instance.IsSettingPresent(name));            
        }

        public void AssertNewSettingButtonIsVisible()
        {
            Assert.IsTrue(Pages<SettingsPage>.Instance.Map.NewSetting.IsVisible());
        }
    }
}