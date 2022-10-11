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
    [AutoMapFrom(typeof(AboutUsCompanyPurposesImage))]
    public class AboutUsCompanyPurposesImageDto : EntityDto<int>
    {
        [Required]
        public string AboutUsCompanyPurposesImagesUrl { get; set; }
        [Required]
        [DisplayName("Company Purposes Images")]
        public IFormFile CompanyPurposesImages { set; get; }
    }
}
