using System;
using System.Collections.Generic;
using System.Text;

namespace Tycoon
{
    public class Warehouse
    {
        readonly IEnumerable<Cargo> _cargos = new List<Cargo>();
    }
}
