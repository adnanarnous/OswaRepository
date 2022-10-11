using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OswaTech.ServiceImagesModel;
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
    [AutoMapFrom(typeof(ServiceImages))]
    public class ServiceImagesDto : EntityDto<int>
    {
        [Required]
        public string ServiceImageUrl { get; set; }
        [Required]
        [DisplayName("Service Image")]
        public IFormFile ServiceImage { set; get; }
    }
}
