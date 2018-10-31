using System;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var boolResult = new OperationResult<bool>(true, "Success");
            var decimalResult = new OperationResult<decimal>(10m, "Decimal value");

            var stringValueResult = RetrieveValue<string>("Select ...", "No value");
            var inValueResult = RetrieveValue<int>("Select ...", 10);

            var classInstanceResult = RetrieveClassInstanceResult<int, OperationResult<decimal>>(10, decimalResult);

            Console.WriteLine(classInstanceResult.Result);
        }

        public static T RetrieveValue<T>(string sql, T defaultValue)
        {
            return defaultValue;
        }

        // example of generic constraints
        // where TValue type has to be a struct
        // and VResult type has to be a class and have a parameterless constructor
        public static VResult RetrieveClassInstanceResult<TValue, VResult>(TValue value, VResult resultType) 
                                                                                        where TValue : struct
                                                                                        where VResult : class, new()
        {
            return new VResult();
        }
    }
}
