﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGroup
{
    class Deer : Herbivores
    {
        public new string Description()
        {
            return string.Format("This is deer");
        }
    }
}