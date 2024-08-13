using System;
using System.Collections.Generic;
using System.Text;
// using System.Windows.Forms;
// Add additional using statements
using Aveva.ApplicationFramework;
using Aveva.ApplicationFramework.Presentation;

namespace Aveva.Presentation.AttributeBrowserAddin
{
    public class AttributeBrowserAddin : IAddin
    {
        #region IAddin Members

        public string Description
        {
            get

            {
                return "Provides a simple attribute browser";
            }
        }

        public string Name
        {
            get

            {
                return "AttributeBrowserAddin";
            }
        }

        public void Start(ServiceManager serviceManager)
        {
            // Create Addins Windows
            // Get the WindowManager service
            WindowManager windowManager = (WindowManager)serviceManager.GetService(typeof(WindowManager));
            // Create a docked window to host an AttributeListControl
            DockedWindow attributeListWindow = windowManager.CreateDockedWindow("Aveva.AttributeBrowser.AttributeList", "Attributes", new AttributeListControl(), DockedPosition.Right);
            // Docked windows created at addin start should ensure their layout is saved between sessions.
            attributeListWindow.SaveLayout = true;

            // Create and register addins commands
            // Get the CommandManager
            CommandManager commandManager = (CommandManager)serviceManager.GetService(typeof(CommandManager));
            ShowAttributeBrowserCommand showCommand = new ShowAttributeBrowserCommand(attributeListWindow);
            commandManager.Commands.Add(showCommand);
        }

        public void Stop()
        {
        }

        #endregion
    }
}