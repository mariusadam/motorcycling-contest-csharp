using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    class ContestException : Exception
    {
        public ContestException() : base()
        {
        }

        public ContestException(string msg) : base(msg)
        {
        }

        public ContestException(string msg, Exception ex) : base(msg, ex)
        {
        }
    }
}