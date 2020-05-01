using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bludata.Teste.CSharp.Application.Services.GenericService
{
    public class CommandResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public CommandResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }

    }
}
