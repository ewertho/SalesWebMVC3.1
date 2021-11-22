using System;

namespace SalesWebMVC3._1.Models.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string message): base(message) { }
    }
}
