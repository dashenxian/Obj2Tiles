using Obj2Tiles;

namespace GDObj2Tiles.Test
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            args = new[] {
                "--lat", "29.6456337183119", 
                "--lon", "106.5632975756124", 
                "-l", "1", 
                "-d", "2",
                "-t", "false",
                "E:\\DeskTop\\3dloupan\\test\\ceModel\\BasicsOfRules_0.obj",
                "E:\\DeskTop\\3dloupan\\test\\output1" };
            var entry = new Obj2TilesEntry();
            await entry.Run(args);
        }
    }
}
