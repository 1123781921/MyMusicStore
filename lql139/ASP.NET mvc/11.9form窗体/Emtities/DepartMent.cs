﻿using StuEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuEntities
{
   public class DepartMent
    {
        public Guid ID { get; set; }

        public string Name { get; set; }

        public string Desctiption { get; set; }//描述

        public string SortCode { get; set; }

        public DepartMent()
        {
            ID = Guid.NewGuid();
        }
    }
}
