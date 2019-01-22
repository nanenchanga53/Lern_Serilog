using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

//https://blog.getseq.net/serilog-tutorial/ 사이트의 튜토리얼을 실습한다

namespace Serilog_test
{
    class Program
    {
        static void Main(string[] args)
        {
            SerilogTest logTest = new SerilogTest();
            //logTest.HelloSerilog();
            //logTest.EmittingAndCllecting();
            //logTest.JSONLogFileTest();
            logTest.WritingLogServer();
        }
    }
}
