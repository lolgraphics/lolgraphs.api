﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Core.Application.DTOs.BffDTOs
{
    public class ErrorDetails
    {
        public required Status Status { get; set; }
    }
}
