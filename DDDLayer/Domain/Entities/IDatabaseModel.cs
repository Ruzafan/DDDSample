﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDLayer.Domain.Entities
{
    public interface IDatabaseModel
    {
        string Id { get; set; }

        int Status { get; set; }

    }
}
