﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport_manager.Models
{
    internal class UserModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }
    }
}
