using System;

namespace Core.Common.Exceptions
{
    public class ApiException(int code, string message, object data) : Exception(message)
    {
        public int Code { get; } = code;
        public new object Data { get; } = data;
    }
}
