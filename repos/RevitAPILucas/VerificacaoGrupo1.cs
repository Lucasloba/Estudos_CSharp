using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.DB.Architecture;

namespace RevitAPILucas 
{
    [Transaction(TransactionMode.Manual)]
    public class VerificacaoGrupo1 : IExternalCommand 
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {

            UIDocument uiDoc = commandData.Application.ActiveUIDocument;
            Document doc = uiDoc.Document;

            FilteredElementCollector colecao = new FilteredElementCollector(doc);
            ElementCategoryFilter filter = new ElementCategoryFilter(BuiltInCategory.OST_IOSModelGroups);
            IList<Element> group = colecao.WherePasses(filter).WhereElementIsNotElementType().ToList();

            string info = "Cuidado! Grupos no arquivo: " + "\n";


            foreach (Element elemento in group) 
            {
                info += elemento.Name + "\n";
            }
            TaskDialog.Show("Titulo", info);

            return Result.Succeeded;
        }
    }
}
