﻿using Entities.Abstract;
using Entities.Congrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Congrete
{
    public class Category: IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryNname { get; set; }

    }
}
