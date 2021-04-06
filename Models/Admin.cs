﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LabourZillaProjectAPI.Models
{
    public partial class Admin
    {
        public string LoginId { get; set; }
        public string AdminName { get; set; }
        public string Apassword { get; set; }
        public string RoleA { get; set; }
    }
}
