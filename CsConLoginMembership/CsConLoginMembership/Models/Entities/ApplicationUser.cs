﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CsConLoginMembership.Models.Entities
{
    public class ApplicationUser
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int ID { get; set; }
    }
}