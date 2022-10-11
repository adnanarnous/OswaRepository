using Abp.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OswaTech.AboutUsModel
{
    public class AboutUsCompanyMessageImages : Entity<int>
    {
        [Required]
        [BindProperty]
        public string AboutUsCompanyMessageImagesUrl { get; set; }
    }
}
