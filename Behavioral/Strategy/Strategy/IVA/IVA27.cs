using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy.IVA
{
    class IVA27 : IIVA
    {
        private const double MULTIPLICADOR = 0.27;

        public double SumarIVA(double ImporteBruto)
        {
            return ImporteBruto + (ImporteBruto * MULTIPLICADOR);
        }

        public double RestarIVA(double ImporteBruto)
        {
            return (ImporteBruto / (1 + MULTIPLICADOR));
        }
    }
}
