﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class ControllerBestellung:IControllerBestellung
    {
        private IControllerBestellung controllerBestellung;

        IControllerBestellung IControllerBestellung.IControllerBestellung { set => this.controllerBestellung=value; }
    }
}
