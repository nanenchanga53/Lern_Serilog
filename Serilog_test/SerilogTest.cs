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

        public void EmittingAndCllecting()
        {
            var itemNumber = 10;
            var itemcount = 999;
            //debug 부터 로그 남기기 설정
            var log = new LoggerConfiguration().MinimumLevel.Debug().WriteTo.Console().CreateLogger();
            //가로 안에 이름을 연동해서 쓸 수 있고 대소문자가 달라도 알아서 찾는다
            log.Debug("Processing item {ItemNumber} of {ItemCount}", itemNumber, itemcount);
            
        }
    }
}
