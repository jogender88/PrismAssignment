﻿using System;
using System.Collections.Generic;

namespace APIModel.Models
{
    public partial class GenderTable
    {
        public GenderTable()
        {
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string GenderType { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
