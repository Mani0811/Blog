﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog2
{
    public class ApplicationUser:IdentityUser
    {
        public string FullName { get; set; }
        public string PictureUrl { get; set; }
    }
}
