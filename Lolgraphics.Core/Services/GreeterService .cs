using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class GreeterService : IGreeterService
    {
        public string Greet(string name)
        {
            return $"Hello, {name}!";
        }
    }
}
