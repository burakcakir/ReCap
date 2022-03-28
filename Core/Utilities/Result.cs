using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class Result : IResult
    {
        public Result(bool success,string message):this(success)
        {

        }

        public Result(bool succes)
        {
            this.Success = succes;
        }

        public bool Success { get; }
        public string Message { get; }
    }
}
