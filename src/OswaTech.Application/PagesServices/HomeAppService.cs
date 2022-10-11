using Abp.Application.Services;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using OswaTech.Dto;
using OswaTech.HomePageModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OswaTech.PagesServices
{
    public class HomeAppServices : CrudAppService<Home, HomeDto>
    {
        private readonly IRepository<Home, int> repository;
        private readonly IHostingEnvironment hosting;

        public HomeAppServices(IRepository<Home, int> repository, IHostingEnvironment hosting) : base(repository)
        {
            this.repository = repository;
            this.hosting = hosting;
        }
        public override HomeDto Create(HomeDto input)
        {
            try
            {
                if (input.HomeBackGroundUrl != null)
                {
                    var PhoneImage = CreateImage(input.HomeBackGround);
                    input.HomeBackGroundUrl = PhoneImage;
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
        public override HomeDto Update(HomeDto input)
        {
            try
            {
                if (input.HomeBackGroundUrl != null)
                {
                    EditImage(input.HomeBackGround, input.HomeBackGroundUrl);
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
