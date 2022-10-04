using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    public class SuccessResult : Result
    {
        public SuccessResult(bool success) : base(true)
        {
        }

        public SuccessResult(string message) : base(success:true, message)
        {
        }
    }
}
