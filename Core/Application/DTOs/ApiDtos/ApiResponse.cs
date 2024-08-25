using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.DTOs.ApiDtos
{
    public class ApiResponse(int code, string message, object data)
    {
        public int Code { get; set; } = code;
        public string Message { get; set; } = message;
        public object Data { get; set; } = data;
    }
}
