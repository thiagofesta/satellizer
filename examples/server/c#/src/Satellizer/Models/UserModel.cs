﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Satellizer.Models
{
    public class User
    {
        public int Id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string facebook { get; set; }
        public string google { get; set; }
        public string linkedin { get; set; }
        public string twitter { get; set; }
    }
}
