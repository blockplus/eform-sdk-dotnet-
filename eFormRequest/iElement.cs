﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    public interface iElement
    {
        string Id { get; set; }
        string Description { get; set; }
        bool Mandatory { get; set; }
        string Label { get; set; }
    }
}