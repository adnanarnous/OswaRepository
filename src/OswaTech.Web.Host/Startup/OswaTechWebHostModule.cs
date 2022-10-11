using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OswaTech.Configuration;

namespace OswaTech.Web.Host.Startup
{
    [DependsOn(
       typeof(OswaTechWebCoreModule))]
    public class OswaTechWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public OswaTechWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OswaTechWebHostModule).GetAssembly());
        }
    }
}
