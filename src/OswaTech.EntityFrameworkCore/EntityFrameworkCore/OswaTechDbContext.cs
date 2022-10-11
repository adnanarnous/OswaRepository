using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using OswaTech.Authorization.Roles;
using OswaTech.Authorization.Users;
using OswaTech.MultiTenancy;
using OswaTech.AboutUsPageModel;
using OswaTech.BusinessModel;
using OswaTech.BusinessModelsPageModel;
using OswaTech.FooterModel;
using OswaTech.HomePageModel;
using OswaTech.HomePhoneImagesModel;
using OswaTech.ProccessImagesModel;
using OswaTech.ServiceImagesModel;
using OswaTech.ServicePageModel;
using OswaTech.ProccessModel;
using OswaTech.AboutUsModel;

namespace OswaTech.EntityFrameworkCore
{
    public class OswaTechDbContext : AbpZeroDbContext<Tenant, Role, User, OswaTechDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public OswaTechDbContext(DbContextOptions<OswaTechDbContext> options)
            : base(options)
        {
        }
        public DbSet<AboutUs> AboutUsDb { get; set; }
        public DbSet<AboutUsCompanyMessageImages> AboutUsCompanyMessageImagesDb { get; set; }
        public DbSet<AboutUsCompanyPurposesImage> AboutUsCompanyPurposesImageDb { get; set; }
        public DbSet<BusinessImages> BusinessImagesDb { get; set; }
        public DbSet<Business> businessesDb { get; set; }
        public DbSet<Footer> FooterDb { set; get; }
        public DbSet<Home> HomeDb { set; get; }
        public DbSet<PhoneImages> PhoneImagesDb { set; get; }
        public DbSet<ProccessImages> ProccessImagesDb { set; get; }
        public DbSet<TheProccess> ProccessDb { set; get; }
        public DbSet<Service> ServicesDb { set; get; }
        public DbSet<ServiceImages> ServiceImages { set; get; }
        public DbSet<ServiceImages> ServiceImagesDb { set; get; }
    }
}
