namespace TelerikSystem.Core.Admin.Pages.ModulesPage
{
    using TestingFramework.Core.Base;

    public class ModulesPage : BasePage<ModulesPageMap, ModulesPageValidator>
    {
        public override string Url
        {
            get
            {
                return @"http://test.telerikacademy.com/Administration/Navigation";
            }
        }
    }
}