using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy.IVA
{
    interface IIVA
    {
        float SumarIVA(float ImporteBruto);

        float RestarIVA(float ImporteBruto);
    }
}
