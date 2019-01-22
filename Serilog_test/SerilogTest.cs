using Serilog;
using Serilog.Formatting.Compact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serilog_test
{
    class SerilogTest
    {
        internal void HelloSerilog()
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

        /// <summary>
        /// Serilog에서 제공해준 서버에 올려보기
        /// https://getseq.net/Download 에서 다운
        /// </summary>
        internal void WritingLogServer()
        {
            var log = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Seq("http://localhost:5341")
            .CreateLogger();

            var itemCount = 99;
            for (var itemNumber = 0; itemNumber < itemCount; ++itemNumber)
                log.Debug("Processing item {ItemNumber} of {ItemCount}", itemNumber, itemCount);

            log.Dispose();
        }

        /// <summary>
        /// Json으로 출력
        /// </summary>
        internal void JSONLogFileTest()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File(new CompactJsonFormatter(), "log.json")
                .CreateLogger();

            var itemCount = 99;
            for (var itemNumber = 0; itemNumber < itemCount; ++itemNumber)
                Log.Debug("Processing item {ItemNumber} of {ItemCount}", itemNumber, itemCount);

            Log.CloseAndFlush();
        }

        /// <summary>
        /// Serilog의 포멧팅 
        /// </summary>
        internal void EmittingAndCllecting()
        {
            var itemNumber = 10;
            var itemcount = 999;
            //debug 부터 로그 남기기 설정
            var log = new LoggerConfiguration().MinimumLevel.Debug().WriteTo.Console().CreateLogger();
            //가로 안에 이름을 연동해서 쓸 수 있고 대소문자가 달라도 알아서 찾는다
            log.Debug("Processing item {ItemNumber} of {ItemCount}", itemNumber, itemcount);

            var user = new { Name = "Nick", Id = "nblumhardt" };
            log.Information("Logged on user {@User}", user);

        }
    }
}
