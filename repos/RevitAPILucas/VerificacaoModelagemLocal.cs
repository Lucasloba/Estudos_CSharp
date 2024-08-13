using System;
using System.Collections.Generic;
using System.Linq;                                 // listar as q n tem material
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
    public class VerificacaoModelagemLocal : IExternalCommand 
    {
    public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements) 
        {
            UIDocument uiDoc = commandData.Application.ActiveUIDocument;
            Document doc = uiDoc.Document;

            FilteredElementCollector colecao = new FilteredElementCollector(doc);
            ElementCategoryFilter filter = new ElementCategoryFilter(BuiltInCategory.OST_Furniture);
            IList<Element> FamilyInstance = colecao.WherePasses(filter).WhereElementIsNotElementType().ToList();

            string info = "Cuidado! Modelagens Locais: " + "\n";
            
            

            foreach (Element elemento in FamilyInstance) 
            {
              info += elemento.Name + "\n";
            }

            TaskDialog.Show("Titulo", info);

            return Result.Succeeded;
        }
    }
}