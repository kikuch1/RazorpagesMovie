using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace RazorPagesMovie
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // .Net Core�̔ėp�z�X�g�FHostBuilder������
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                // webBuilder=>�F�����_��
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
