using Abp.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OswaTech.BusinessModelsPageModel
{
    [BindProperties]
    public class BusinessImages : Entity<int>
    {
        [Required]
        public string BusinessModelImageUrl { get; set; }
    }
}
