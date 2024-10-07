using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy.IVA
{
    interface IIVA
    {
        double SumarIVA(double ImporteBruto);

        double RestarIVA(double ImporteBruto);
    }
}
