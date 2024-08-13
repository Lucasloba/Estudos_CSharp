using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.DB.Architecture;

/*
namespace RevitAPILucas 
{
    [Transaction(TransactionMode.Manual)]
    class RotinasUtils : IExternalCommand 
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements) 
        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;
            Selection sel = uidoc.Selection;

             Element RotinasUtils() 
             {
                // Document
                var document = ActiveUIDocument.Document;
                // Selection
                var selection = ActiveUIDocument.Selection;

                try 
                {
                    document = new var();
                    selection = new var();


                    // Pick Object
                    var reference = selection.PickObject(ObjectType.Element);
                    // Element
                    var elementId = reference.ElementId;
                    var element = document.GetElement(elementId);

                    // Retorna Elemento
                    return element;

                } 
                catch (Exception) 
                {
                    return null;
                }

             }
                return Result.Succeeded;
        }
    }
}
*/