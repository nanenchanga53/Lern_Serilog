using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serilog_test
{
    class SerilogTest
    {
        public void HelloSerilog()
        {
            var log = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            log.Information("hello, Serilog!");
            log.Warning("Goodbye, Serilog.");
            Log.CloseAndFlush();

            //이렇게 쓸 수 도 있다
            //using (var log = new LoggerConfiguration().WriteTo.Console().CreateLogger())
            //{
            //    log.Information("hello, Serilog!");
            //    log.Warning("Goodbye, Serilog.");
            //}
        }
    }
}
