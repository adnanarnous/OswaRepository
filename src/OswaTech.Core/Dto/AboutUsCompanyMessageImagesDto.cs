using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OswaTech.AboutUsModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OswaTech.Dto
{
    [BindProperties]
    [AutoMapFrom(typeof(AboutUsCompanyMessageImages))]
    public class AboutUsCompanyMessageImagesDto : EntityDto<int>
    {
        [Required]
        public string AboutUsCompanyMessageImagesUrl { get; set; }
        [Required]
        [DisplayName("Company Message Images")]
        public IFormFile CompanyMessageImages { set; get; }
    }
}
