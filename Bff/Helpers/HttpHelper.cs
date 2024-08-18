using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Application.DTOs.BffDtos;
using Core.Common.Exceptions;
using Newtonsoft.Json;

namespace Bff.Helpers
{
    public static class HttpHelper
    {
        public static async Task<T> HandleHttpResponseAsync<T>(HttpResponseMessage response, Func<Task<T>> onSuccess)
        {
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                var errorDetails = JsonConvert.DeserializeObject<ErrorDetails>(errorContent) 
                                    ?? new ErrorDetails { Status = new Status { Message = "Error details unavailable" } };
                
                throw new ApiException(
                    (int)response.StatusCode,
                    $"Request failed with status code {response.StatusCode}",
                    errorDetails
                );
            }

            return await onSuccess();
        }
    }
}
