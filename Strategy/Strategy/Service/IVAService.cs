using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategy.IVA;

namespace Strategy.Service
{
    class IVAService
    {
        private readonly IIVA _IVAService;

        public IVAService(IIVA IVAService) 
        {
            _IVAService = IVAService;
        }

        public float SumarIVA (float ImporteBruto) 
        {
            return _IVAService.SumarIVA(ImporteBruto);
        }

        public float RestarIVA(float ImporteBruto)
        {
            return _IVAService.RestarIVA(ImporteBruto);
        }
    }
}
