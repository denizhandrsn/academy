using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Exceptions.ValidatioExceptions
{
    public class ValidationException:Exception
    {
        public ValidationException(string message):base(message)
        {
            
        }
        public ValidationException() : base("Validation Error")
        {
            
        }
    }
}
