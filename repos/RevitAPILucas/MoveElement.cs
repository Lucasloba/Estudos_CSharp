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
    class MoveElement : IExternalCommand 
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;
            Selection sel = uidoc.Selection;

            Element selectedElement = doc.GetElement(sel.PickObject(ObjectType.Element, "Selecione um elemento para mover"));

            LocationPoint selectedElementLocation = selectedElement.Location as LocationPoint;

            using (Transaction t1 = new Transaction(doc, "Mover Elemento" )) 
            {
                t1.Start();
                selectedElement.Location.Move(XYZ.BasisX.Multiply(1));
                t1.Commit();
            }

            return Result.Succeeded;
        }
    }
}
