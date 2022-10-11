using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OswaTech.EntityFrameworkCore;
using OswaTech.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace OswaTech.Web.Tests
{
    [DependsOn(
        typeof(OswaTechWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class OswaTechWebTestModule : AbpModule
    {
        public OswaTechWebTestModule(OswaTechEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OswaTechWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(OswaTechWebMvcModule).Assembly);
        }
    }
}