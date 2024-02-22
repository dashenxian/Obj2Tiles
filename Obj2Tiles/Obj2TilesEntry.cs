using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obj2Tiles
{
    /// <summary>
    /// 库调用入库
    /// </summary>
    public class Obj2TilesEntry
    {
        public async Task Run(Options opts)
        {
            await Program.Run(opts);
        }
        public async Task Run(string[] args)
        {
            var oResult = await Parser.Default.ParseArguments<Options>(args).WithParsedAsync(Run);
            if (oResult.Tag == ParserResultType.NotParsed)
            {
                throw new ArgumentException("参数输入错误，要知道详细的参数用法请调用Run(Options opts)重载");
            }
        }
    }
}
