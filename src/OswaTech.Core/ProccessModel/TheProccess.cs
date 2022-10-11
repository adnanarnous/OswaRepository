using Abp.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OswaTech.ProccessModel
{
    [BindProperties]
    public class TheProccess : Entity<int>
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
