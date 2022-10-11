using Abp.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OswaTech.HomePageModel
{
    [BindProperties]
    public class Home : Entity<int>
    {
        [Required]
        public string HomeBackGroundUrl { get; set; }
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
