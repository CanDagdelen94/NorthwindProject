using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Abstract
{
    public interface IResult
    {
        // sadece voidler
        bool Success { get; }
        string Message { get; }
    }
}
