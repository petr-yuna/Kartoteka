﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartoteka
{
    public static class StaticInfoClass
    {
        // для корректного изменения ширины главной формы
        static ControlArchive arch = new ControlArchive();
        public static int archiveControlWidth = arch.Width;        
    }
}