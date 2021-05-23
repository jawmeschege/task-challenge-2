using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge2.Responses
{
    public abstract class BaseResponses
    {
        public bool Success { get; protected set; }
        public string Message { get; protected set; }

        public BaseResponses(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }
}
