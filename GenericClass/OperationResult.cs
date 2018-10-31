using System;

namespace GenericClass
{
    public class OperationResult<TResult>
    {
        public TResult Result { get; set; }

        public string Message { get; set; }

        public OperationResult(TResult result, string message)
        {
            Result = result;
            Message = message;
        }

        public OperationResult()
        {

        }
    }
}
