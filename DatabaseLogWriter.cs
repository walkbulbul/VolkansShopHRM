using VolkansPieShopHRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolkansPieShopHRM
{
    class DatabaseLogWriter : ILogWriter
    {
        public void WriteLog(string log)
        {
            Console.WriteLine("Database log Written {0}", log);
        }
    }
}
