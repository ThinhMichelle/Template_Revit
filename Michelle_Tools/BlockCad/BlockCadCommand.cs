using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Structure;
using Autodesk.Revit.UI;
using BlockCad.View;
using BlockCad.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Michelle_Tools.BlockCad
{
    [Transaction(TransactionMode.Manual)]
    public class BlockCadCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            var uidoc = commandData.Application.ActiveUIDocument;
            var doc = uidoc.Document;
            var vm = new SolidViewModel(doc);
            vm.SolidView.ShowDialog();

            return Result.Succeeded;
        }
       

        }
    }


