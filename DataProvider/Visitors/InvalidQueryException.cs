using System;

namespace DataProvider.Visitors
{
    class InvalidQueryException : Exception
    {
        private string _message;

        public InvalidQueryException(string message)
        {
            _message = message + " ";
        }

        public override string Message
        {
            get
            {
                return "The client query is invalid: " + _message;
            }
        }
    }
}
