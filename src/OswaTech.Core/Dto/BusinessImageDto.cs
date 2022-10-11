using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OswaTech.BusinessModelsPageModel;
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
    [AutoMapFrom(typeof(BusinessImages))]
    public class BusinessImageDto : EntityDto<int>
    {
        [Required]
        public string BusinessModelImageUrl { get; set; }
        [Required]
        [DisplayName("Business Image")]
        public IFormFile BusinessImage { set; get; }
    }
}
