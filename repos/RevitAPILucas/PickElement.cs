using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI.Selection;

namespace RevitAPILucas 
{
    [Transaction(TransactionMode.Manual)]
    class PickElement : IExternalCommand 
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements) 
        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;
            Selection sel = uidoc.Selection;

            Element selectedElement = doc.GetElement(sel.PickObject(ObjectType.Element, "Selecione um elemento"));

            string elementInfo = "Categoria: " + selectedElement.Category.Name + " \n " + "Tipo: " + selectedElement.Name;

            TaskDialog.Show("Informações do objeto", elementInfo);

            return Result.Succeeded;
        }
    }
}
