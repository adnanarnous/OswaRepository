using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OswaTech.Authorization;

namespace OswaTech
{
    [DependsOn(
        typeof(OswaTechCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class OswaTechApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<OswaTechAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(OswaTechApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
