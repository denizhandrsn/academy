using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Exceptions.ValidatioExceptions
{
    public class NotValidationException:ValidationException
    {
        public NotValidationException() : base("This is not an validation")
        {
            
        }
    }
}
