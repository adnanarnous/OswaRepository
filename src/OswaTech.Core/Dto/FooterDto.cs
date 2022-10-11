using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OswaTech.FooterModel;
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
    [AutoMapFrom(typeof(Footer))]
    public class FooterDto : EntityDto<int>
    {
        [Required]
        public string FooterImageLogoUrl { get; set; }
        [Required]
        [DisplayName("Footer Image")]
        public IFormFile FooterImage { set; get; }
        [Required]
        [DisplayName("Footer Content Arabic")]
        public string FooterContentArabic { get; set; }
        [Required]
        [DisplayName("Footer Content English")]
        public string FooterContentEnglish { get; set; }
        [Required]
        [DisplayName("FaceBook Link")]
        public string FaceBookLink { get; set; }
        [Required]
        [DisplayName("Telegram Link")]
        public string TelegramLink { get; set; }
        [Required]
        [DisplayName("Twitter Link")]
        public string TwitterLink { get; set; }
        [Required]
        [DisplayName("Instagram Link")]
        public string InstagramLink { get; set; }
    }
}
