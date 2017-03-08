using System;

namespace gitDemo.Controllers
{
    internal class Execption : Exception
    {
        public Execption()
        {
        }

        public Execption(string message) : base(message)
        {
        }

        public Execption(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}