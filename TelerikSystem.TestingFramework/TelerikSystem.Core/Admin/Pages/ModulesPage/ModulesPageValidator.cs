namespace TelerikSystem.Core.Admin.Pages.ModulesPage
{
    using ArtOfTest.Common.UnitTesting;

    using TestingFramework.Core.Base;

    public class ModulesPageValidator
    {
        public void AssertSettingsModuleExists()
        {
            Assert.IsTrue(Pages<ModulesPage>.Instance.Map.SettingsModule.IsVisible());
        }
    }
}