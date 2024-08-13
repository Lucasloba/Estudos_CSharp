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
    class TesteMensagem : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements) 
        {
 

            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document document = uidoc.Document;
            Selection sel = uidoc.Selection;
            
            

            Element columnElement = document.GetElement(sel.PickObject(ObjectType.Element, "Selecione a coluna para mover"));


            // obter a localização atual da coluna
            LocationPoint columnElementLocation = columnElement.Location as LocationPoint;

            XYZ oldPlace = columnElementLocation.Point;

            // Mova a coluna para o novo local.
            XYZ newPlace = new XYZ(10, 20, 30);
            ElementTransformUtils.MoveElement(document, columnElement.Id, newPlace);

            // agora obtenha o novo local da coluna
            columnElementLocation = columnElement.Location as LocationPoint;
            XYZ newActual = columnElementLocation.Point;

            string info = "Original Z location: " + oldPlace.Z +
                          "\nNew Z location: " + newActual.Z;

            TaskDialog.Show("Revit", info);

            return Result.Succeeded;
        }
    }
}
