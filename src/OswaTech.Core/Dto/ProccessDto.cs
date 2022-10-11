using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OswaTech.ProccessModel;

namespace OswaTech.Dto
{
    [BindProperties]
    [AutoMapFrom(typeof(TheProccess))]
    public class ProccessDto : EntityDto<int>
    {
        [Required]
        public int ProccessImageId { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Proccess Title Arabic")]
        public string ProccessTitleArabic { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Proccess Title English")]
        public string ProccessTitleEnglish { get; set; }
        [Required]
        [DisplayName("Proccess Desvription English")]
        public string ProccessDescriptionEnglish { get; set; }
        [Required]
        [DisplayName("Proccess Description Arabic")]
        public string ProccessDescriptionArabic { get; set; }
    }
}
