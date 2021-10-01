using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Results
{
    public class Result : IResult
    { 
        public Result(string _message, bool _success)
        {
            Message = _message;
            Success = _success;
        }
        public string Message{get;}
        public bool Success { get; }
    }
}
