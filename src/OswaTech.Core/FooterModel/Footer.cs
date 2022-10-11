using Abp.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OswaTech.FooterModel
{
    [BindProperties]
    public class Footer : Entity<int>
    {
        [Required]
        public string FooterImageLogoUrl { get; set; }
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
