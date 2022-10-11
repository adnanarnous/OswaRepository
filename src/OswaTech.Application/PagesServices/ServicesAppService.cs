using Abp.Application.Services;
using Abp.Domain.Repositories;
using OswaTech.Dto;
using OswaTech.ServicePageModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OswaTech.PagesServices
{
    public class SeviceAppServices : CrudAppService<Service, ServiceDto>
    {
        private readonly IRepository<Service, int> repository;

        public SeviceAppServices(IRepository<Service, int> repository) : base(repository)
        {
            this.repository = repository;
        }
        public void GetAllServiceCount()
        {
            repository.Count();
        }
    }
}
