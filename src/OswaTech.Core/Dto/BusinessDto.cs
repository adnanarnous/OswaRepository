using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OswaTech.BusinessModel;
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
    [AutoMapFrom(typeof(Business))]
    public class BusinessDto : EntityDto<int>
    {
        [Required]
        public int BusinessModelImageId { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Business Title Arabic")]
        public string BusinessModelTitleArabic { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Business Title English")]
        public string BusinessModelTitleEnglish { get; set; }
        [Required]
        [DisplayName("Business Description English")]
        public string BusinessModelDescriptionsEnglish { get; set; }
        [Required]
        [DisplayName("Business Descrition Arabic")]
        public string BusinessModelDescriptionsArabic { get; set; }
    }
}
