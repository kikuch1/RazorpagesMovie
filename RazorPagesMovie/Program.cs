using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace RazorPagesMovie
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // .Net Coreの汎用ホスト：HostBuilderが生成
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                // webBuilder=>：ラムダ式
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
