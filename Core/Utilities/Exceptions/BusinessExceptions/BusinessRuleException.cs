using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Exceptions.BusinessExceptions
{
    public class BusinessRuleException:Exception
    {
        public BusinessRuleException(string message):base(message)
        {
            
        }
        public BusinessRuleException():base("İş Kuralı Hatası")
        {
            
        }
    }
}
