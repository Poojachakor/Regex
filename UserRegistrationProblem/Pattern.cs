using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
  internal class Pattern
    {

        public static string Regex_Rule = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[!@#$%_])[a-zA-Z0-9!@#$%_]{8,}$";

        public bool validatePassword(string inputString)
        {
            return Regex.IsMatch(inputString, Regex_Rule);
        }

    }
}
