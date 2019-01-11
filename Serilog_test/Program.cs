using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace Serilog_test
{
    class Program
    {
        static void Main(string[] args)
        {
            SerilogTest logTest = new SerilogTest();
            //logTest.HelloSerilog();
            logTest.EmittingAndCllecting();

        }
    }
}
