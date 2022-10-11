using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OswaTech.HomePhoneImagesModel;
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
    [AutoMapFrom(typeof(PhoneImages))]
    public class PhoneImagesDto : EntityDto<int>
    {
        [Required]
        public string PhoneImageUrl { get; set; }
        [Required]
        [DisplayName("Phone Image")]
        public IFormFile PhoneImage { get; set; }

    }
}
