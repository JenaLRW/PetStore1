﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petstore1
{

    internal class DogLeash : Product
    {
        public int LengthInches { get; set; }
        public string Material { get; set; }
    }
}