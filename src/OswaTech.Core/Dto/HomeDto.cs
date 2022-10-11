using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OswaTech.HomePageModel;
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
    [AutoMapFrom(typeof(Home))]
    public class HomeDto : EntityDto<int>
    {
        [Required]
        public string HomeBackGroundUrl { get; set; }
        [Required]
        [DisplayName("Home Background")]
        public IFormFile HomeBackGround { set; get; }
        [Required]
        public int PhoneImageId { get; set; }
        [Required]
        [DisplayName("Button Link Url")]
        public string ButtonLinkUrl { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Home Title Arabic")]
        public string HomeTextTitleArabic { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Home Title English")]
        public string HomeTextTitleEnglish { get; set; }
        [Required]
        [DisplayName("Home Description English")]
        public string HomeTextDescriptionEnglish { get; set; }
        [Required]
        [DisplayName("Home Description Arabic")]
        public string HomeTextDescriptionArabic { get; set; }
    }
}
