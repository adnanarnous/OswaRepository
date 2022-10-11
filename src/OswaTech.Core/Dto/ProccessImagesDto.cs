using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OswaTech.ProccessImagesModel;
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
    [AutoMapFrom(typeof(ProccessImages))]
    public class ProccessImagesDto : EntityDto<int>
    {
        [Required]
        public string ProccessImageUrl { get; set; }
        [Required]
        [DisplayName("Proccess Image")]
        public IFormFile ProccessImage { get; set; }
    }
}
