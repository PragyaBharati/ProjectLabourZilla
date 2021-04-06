﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LabourZillaProjectAPI.Models
{
    public partial class Test
    {
        public string Tname { get; set; }
        public string Temail { get; set; }
        public string TprojectName { get; set; }
        public DateTime? Tdate { get; set; }
    }
}
