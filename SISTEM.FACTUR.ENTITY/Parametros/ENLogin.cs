﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEM.FACTUR.ENTITY.Parametros
{
    public class ENLogin
    {
        public string ruc { get; set; }
        public string user { get; set; }
        public string pass { get; set; }
        public string proyecto { get; set; } = "Factur";
        public string usertoken { get; set; } = "SISTEM";
        public string passwordtoken { get; set; } = "SISTEM";


    }
}
