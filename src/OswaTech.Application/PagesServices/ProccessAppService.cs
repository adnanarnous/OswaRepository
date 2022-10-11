using Abp.Application.Services;
using Abp.Domain.Repositories;
using OswaTech.Dto;
using OswaTech.ProccessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OswaTech.PagesServices
{
    public class ProccessAppServices : CrudAppService<TheProccess, ProccessDto>
    {
        private readonly IRepository<TheProccess, int> repository;

        public ProccessAppServices(IRepository<TheProccess, int> repository) : base(repository)
        {
            this.repository = repository;
        }
        public void GetAllProccessCount()
        {
            repository.Count();
        }
    }
}
