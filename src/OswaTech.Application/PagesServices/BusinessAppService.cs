using Abp.Application.Services;
using Abp.Domain.Repositories;
using OswaTech.BusinessModel;
using OswaTech.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OswaTech.PagesServices
{
    public class BusinessAppServices : CrudAppService<Business, BusinessDto>
    {
        private readonly IRepository<Business, int> repository;

        public BusinessAppServices(IRepository<Business, int> repository) : base(repository)
        {
            this.repository = repository;
        }
        public void GetAllServiceCount()
        {
            repository.Count();
        }
    }
}
