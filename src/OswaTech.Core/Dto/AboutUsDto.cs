using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OswaTech.AboutUsPageModel;
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
    [AutoMapFrom(typeof(AboutUs))]
    public class AboutUsDto : EntityDto<int>
    {
        [Required]
        public string AboutUsBackGroundUrl { get; set; }
        [Required]
        [DisplayName("AboutUs Background")]
        public IFormFile AboutUsBackGround { set; get; }
        [Required]
        [MaxLength(50)]
        [DisplayName("AboutUs Title Arabic")]
        public string AboutUsTitleArabic { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("AboutUs Title English")]
        public string AboutUsTitleEnglish { get; set; }
        [Required]
        public string CompanyPurposesImageId { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("First Address English")]
        public string FirstAddressEnglish { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("First Address Arabic")]
        public string FirstAddressArabic { get; set; }
        [Required]
        public string CompanyMessageImageId { set; get; }

        [Required]
        [MaxLength(50)]
        [DisplayName("Second Address English")]
        public string SecondAddressArabic { set; get; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Second Address English")]
        public string SecondAddressEnglish { set; get; }
        [Required]
        [DisplayName("First Content English")]
        public string FirstContentEnglish { set; get; }
        [Required]
        [DisplayName("First Content Arabic")]
        public string FirstContentArabic { set; get; }
        [Required]
        [DisplayName("Second Content Arabic")]
        public string SecondContentArabic { set; get; }
        [Required]
        [DisplayName("Second Content English")]
        public string SecondContentEnglish { set; get; }

    }
}
