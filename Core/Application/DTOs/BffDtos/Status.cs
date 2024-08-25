﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.DTOs.BffDtos
{
    public class Status
    {
        [JsonProperty("status_code")]
        public int StatusCode { get; set; }

        public required string Message { get; set; }
    }
}
