using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    /// <summary>
    /// Temel voidler için başlangıç
    /// </summary>
    public interface IResult
    {
        bool Success { get; }

        string Message { get; }
    }
}
