using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.DB;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.DB.Architecture;

namespace RevitAPILucas 
{
    [Transaction(TransactionMode.Manual)]
    public class VerificacaoMaterialFamilias : IExternalCommand 
        {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements) 
        {
            UIDocument uiDoc = commandData.Application.ActiveUIDocument;
            Document doc = uiDoc.Document;
       


            FilteredElementCollector colecao = new FilteredElementCollector(doc);
            ElementCategoryFilter filter = new ElementCategoryFilter(BuiltInCategory.OST_Furniture) ;
            IList<Element> FamilyInstance = colecao.WherePasses(filter).WhereElementIsNotElementType().ToList();
           // Element elementmaterial = null;
           
            


            string info = "Cuidado! Famílias sem material: " + "\n";

            foreach (Element elemento in FamilyInstance) 
            {
                
                StringBuilder materialInfo = new StringBuilder();
                materialInfo.AppendFormat("Name: {0}", materialInfo);

            }

          


            TaskDialog.Show("Titulo", info);
            return Result.Succeeded;
        }
    }
}
