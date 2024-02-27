﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarModelMgmt.Core.Entities
{
    public class Menu
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public int RoleId { get; set; }
    }
}