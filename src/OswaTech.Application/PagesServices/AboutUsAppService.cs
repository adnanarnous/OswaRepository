using Abp.Application.Services;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using OswaTech.AboutUsPageModel;
using OswaTech.Dto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OswaTech.PagesServices
{
    public class AboutUsAppServices : CrudAppService<AboutUs, AboutUsDto>
    {
        private readonly IRepository<AboutUs, int> repository;
        private readonly IHostingEnvironment hosting;

        public AboutUsAppServices(IRepository<AboutUs, int> repository, IHostingEnvironment hosting) : base(repository)
        {
            this.repository = repository;
            this.hosting = hosting;
        }
        public override AboutUsDto Create(AboutUsDto input)
        {
            try
            {
                if (input.AboutUsBackGroundUrl != null)
                {
                    var PhoneImage = CreateImage(input.AboutUsBackGround);
                    input.AboutUsBackGroundUrl = PhoneImage;
                    return base.Create(input);
                }
                else
                {
                    return base.Create(input);
                }
            }
            catch (Exception)
            {
                throw new Exception("Error In Image");
            }
        }
        public override AboutUsDto Update(AboutUsDto input)
        {
            try
            {
                if (input.AboutUsBackGroundUrl != null)
                {
                    EditImage(input.AboutUsBackGround, input.AboutUsBackGroundUrl);
                    return base.Update(input);
                }
                else
                {
                    return base.Update(input);
                }
            }
            catch (Exception)
            {
                throw new Exception("Error In Image");
            }
        }
        string CreateImage(IFormFile file)
        {
            if (file != null)
            {
                string uploads = Path.Combine(hosting.WebRootPath, "BackgroundImages");
                string fullPath = Path.Combine(uploads, file.FileName);
                file.CopyTo(new FileStream(fullPath, FileMode.Create));

                return file.FileName;
            }

            return null;
        }
        string EditImage(IFormFile file, string ImageUrl)
        {
            if (file != null)
            {
                string uploads = Path.Combine(hosting.WebRootPath, "BackgroundImages");
                string newPath = Path.Combine(uploads, file.FileName);
                string oldPath = Path.Combine(uploads, ImageUrl);
                if (oldPath != newPath)
                {
                    System.IO.File.Delete(oldPath);
                    file.CopyTo(new FileStream(newPath, FileMode.Create));
                }

                return file.FileName;
            }

            return ImageUrl;
        }
    }
}
