using BethanysPieShopHRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolkansPieShopHRM
{
    class FileLogWriter : ILogWriter
    {
        public void WriteLog(string log)
        {
            Console.WriteLine("File log Written {0}", log);
        }
    }
}
