using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OswaTech.ServicePageModel;
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
    [AutoMapFrom(typeof(Service))]
    public class ServiceDto : EntityDto<int>
    {
        [Required]
        public int ServiceImageId { set; get; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Service Title Arabic")]
        public string ServiceTitleArabic { set; get; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Service Title English")]
        public string ServiceTitleEnglish { set; get; }
        [Required]
        [DisplayName("Service Description English")]
        public string ServiceDescriptionEnglish { set; get; }
        [Required]
        [DisplayName("Service Description Arabic")]
        public string ServiceDescriptionArabic { set; get; }
    }
}
