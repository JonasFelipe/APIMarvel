using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Domain.Exceptions
{
    [Serializable]
    public class ConflictRequestException : Exception
    {
        public ConflictRequestException()
        {

        }

        public ConflictRequestException(int id)
        {

        }

        public ConflictRequestException(string message) : base(message)
        {

        }
    }
}
