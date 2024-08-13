using System;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;



namespace TesteDeBotaoExterno 
{
    public class Class1 : IExternalApplication 
    {
        private static RibbonPanel ribbonPanel1;

        public Result OnStartup(UIControlledApplication application) 
        {
            ribbonPanel = application.CreatePanel("TesteDeBotaoExterno");
            ribbonPanel.CreatePushButton<Commands.Command>()
            .SetLargeImage(Properties.Resources.Revit.GetBitmapSource());

            ribbonPanel.CreatePushButton<Commands.Command>("New")
            .SetLargeImage(Properties.Resources.Revit.GetBitmapSource());

            return Result.Succeeded;
        }
    }
}