using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataLayer
{
    public class clsLogger
    {
        public delegate void LogAction(Exception ex ,System.Diagnostics.EventLogEntryType entryType);

        private static LogAction _logAction;
        public clsLogger(LogAction action) 
        {
            _logAction = action;
        }

        public static void Log(Exception ex, System.Diagnostics.EventLogEntryType entryType) 
        {
            _logAction(ex,entryType);
        }
    }
}
