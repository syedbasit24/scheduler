using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeGreeting.data
{
    public class ErrorLog
    {
        public DateTime Timestamp { get; set; }
        public string ErrorMessage { get; set; }
        public string StackTrace { get; set; }
    }
}
