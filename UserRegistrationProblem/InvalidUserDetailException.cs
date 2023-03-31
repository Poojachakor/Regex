using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class InvalidUserDetailException : Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRST_NAME,
            INVALID_LAST_NAME,
            INVALID_EMAIL,
            INVALID_PASSWORD,
            INVALID_MOBILE
        }
        private ExceptionType type;
        public InvalidUserDetailException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }

}



