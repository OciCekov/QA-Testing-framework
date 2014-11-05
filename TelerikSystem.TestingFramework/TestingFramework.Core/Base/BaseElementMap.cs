namespace TestingFramework.Core.Base
{
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.TestTemplates;

    /// <summary>
    /// This class encapsulates the constructor required for every page map
    /// providing the ability to declare custom methods for locating dom elements.
    /// It is meant to be inherited by every page map class.
    /// </summary>
    public class BaseElementMap : HtmlElementContainer
    {
        public BaseElementMap()
            : base(Manager.Current.ActiveBrowser.Find)
        {
        }
    }
}
