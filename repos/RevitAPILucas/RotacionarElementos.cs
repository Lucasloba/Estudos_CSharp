using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI.Selection;

/*
namespace RevitAPILucas 
{
    
            /// <summary>
            /// Seleciona elemento e rotaciona em relação ao ponto
            /// </summary>
            public void ElementRotate() {
                // Document
                var document = ActiveUIDocument.Document;

                // Pick Element
                var element = PickElement();

                // Se Element for valido
                while (element != null) {
                    // angle
                    var angle = 30.0;

                    // deg to rad
                    angle *= Math.PI / 180.0;

                    // Pega ponto
                    var center = PickXYZ();

                    // Se ponto existir
                    if (center != null) {
                        // axis
                        var axis = Line.CreateBound(center, center + XYZ.BasisZ);

                        // Cria Transaction
                        using (Transaction transaction = new Transaction(document)) {
                            transaction.Start("ElementRotate");

                            // Rotate Element
                            ElementTransformUtils.RotateElement(document, element.Id, axis, angle);

                            // Envia todas as modificações
                            transaction.Commit();
                        }

                        // Pick Element
                        element = PickElement();
                    }
                }
            }

            /// <summary>
            /// Seleciona elementos e rotaciona em relação ao ponto
            /// </summary>
            public void ElementRotateAll() {
                // Document
                var document = ActiveUIDocument.Document;

                // Pick Element
                var elements = PickElements();

                // Se Element for valido
                if (elements != null) {
                    // angle
                    var angle = 30.0;

                    // deg to rad
                    angle *= Math.PI / 180.0;

                    // Pega ponto
                    var center = PickXYZ();

                    // Se ponto existir
                    if (center != null) {
                        // axis
                        var axis = Line.CreateBound(center, center + XYZ.BasisZ);

                        // Cria Transaction
                        using (Transaction transaction = new Transaction(document)) {
                            transaction.Start("ElementRotate");

                            // Rotate Element
                            ElementTransformUtils.RotateElements(document, elements.Select(e => e.Id).ToList(), axis, angle);

                            // Envia todas as modificações
                            transaction.Commit();
                        }
                    }
                }
            }

            /// <summary>
            /// Seleciona elemento e rotaciona com o centro
            /// </summary>
            public void ElementRotateCenter() {
                // Document
                var document = ActiveUIDocument.Document;

                // Pick Element
                var element = PickElement();

                // Se Element for valido
                while (element != null) {
                    // angle
                    var angle = 30.0;

                    // deg to rad
                    angle *= Math.PI / 180.0;

                    // Pega ponto
                    var center = XYZ.Zero;

                    // Location
                    var location = element.Location;

                    // Location é do tipo ponto
                    if (location is LocationPoint) {
                        var locationPoint = location as LocationPoint;
                        center = locationPoint.Point;
                    }

                    // Location é do tipo curva
                    else if (location is LocationCurve) {
                        var locationCurve = location as LocationCurve;
                        center = (locationCurve.Curve.GetEndPoint(0) + locationCurve.Curve.GetEndPoint(1)) / 2.0;
                    }

                    // axis
                    var axis = Line.CreateBound(center, center + XYZ.BasisZ);

                    // Cria Transaction
                    using (Transaction transaction = new Transaction(document)) {
                        transaction.Start("ElementRotate");

                        // Rotate Element
                        ElementTransformUtils.RotateElement(document, element.Id, axis, angle);

                        // Envia todas as modificações
                        transaction.Commit();
                    }
                    // Pick Element
                    element = PickElement();
                }
            }


        }
}   
}
*/
