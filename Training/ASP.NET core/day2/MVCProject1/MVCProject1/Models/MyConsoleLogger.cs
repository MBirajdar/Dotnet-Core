using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MVCProject1.Models
{
    public interface ILog
    {
        void info(string str);
    }
    class MyConsoleLogger :ILog
    {
        public void info(string str)
        {
            Debug.WriteLine(str);
        }
    }
}
