using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy.IVA
{
    class IVA21 : IIVA
    {
        private const float MULTIPLICADOR = 0.21f;

        public float SumarIVA(float ImporteBruto) 
        {
            return ImporteBruto + (ImporteBruto * MULTIPLICADOR);
        }

        public float RestarIVA(float ImporteBruto)
        {
            return (ImporteBruto / 1 + MULTIPLICADOR);
        }
    }
}
