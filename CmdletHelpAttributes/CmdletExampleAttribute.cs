﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmdletHelpAttributes
{
    [AttributeUsage(AttributeTargets.Class,
                      AllowMultiple = true)]
    public sealed class CmdletExampleAttribute : Attribute
    {

        public string Code { get; set; }
        public string Introduction { get; set; }
        public string Remarks { get; set; }
        public int SortOrder { get; set; }

        public CmdletExampleAttribute()
        {

        }
    }
}
