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
    class AreaMinimaAmbientes : IExternalCommand 
        {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements) 
        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;
            Selection sel = uidoc.Selection;

           // bool WasVerificationChecked(SelectionFilterElement.Location);





            TaskDialog.Show("Verificação de Área Mínima dos Ambientes", "V.A");

            return Result.Succeeded;
        }
    }
}
