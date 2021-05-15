﻿using Course.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Data.Interfaces
{
    interface IAllUnits {
        IEnumerable<Unit> getUnits { get; }
        IEnumerable<Unit> getFavouriteUnits { get; set; }
        Unit getUnit(int UnitID);
    }
}
