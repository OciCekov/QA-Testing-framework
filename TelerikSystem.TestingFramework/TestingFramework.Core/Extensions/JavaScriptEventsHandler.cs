namespace TestingFramework.Core.Extensions
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.jQuery;

    public static class JavaScriptEventsHandler
    {        
        public static T FireClick<T>(this T control) where T : HtmlControl
        {
            control.AsjQueryControl().InvokejQueryEvent(jQueryControl.jQueryControlEvents.click);

            return control;
        }

        public static T FireChange<T>(this T control) where T : HtmlControl
        {
            control.AsjQueryControl().InvokejQueryEvent(jQueryControl.jQueryControlEvents.change);

            return control;
        }
    }
}