using Course.Data.Interfaces;
using Course.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Controllers
{
    public class UnitsController: Controller {
        private readonly IAllUnits _allUnits;
        private readonly IUnitsCategory _allCategories;

        public UnitsController(IAllUnits allUnits, IUnitsCategory allCategories) {
            _allUnits = allUnits;
            _allCategories = allCategories;
        }
        public ViewResult List() {
            UnitsListViewModel obj = new UnitsListViewModel();
            obj.allUnits = _allUnits.getUnits;
            obj.currCategory = "Юниты";
            return View(obj);
        }
    }
}
