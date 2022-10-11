using Abp.Application.Services;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using OswaTech.Dto;
using OswaTech.HomePhoneImagesModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OswaTech.PagesServices
{
    public class PhoneImagesAppServices : CrudAppService<PhoneImages, PhoneImagesDto>
    {
        private readonly IRepository<PhoneImages, int> repository;
        private readonly IHostingEnvironment hosting;

        public PhoneImagesAppServices(IRepository<PhoneImages, int> repository, IHostingEnvironment hosting) : base(repository)
        {
            this.repository = repository;
            this.hosting = hosting;
        }
        public override PhoneImagesDto Create(PhoneImagesDto input)
        {
            try
            {
                if (input.PhoneImageUrl != null)
                {
                    var PhoneImage = CreateImage(input.PhoneImage);
                    input.PhoneImageUrl = PhoneImage;
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
        public override PhoneImagesDto Update(PhoneImagesDto input)
        {
            try
            {
                if (input.PhoneImageUrl != null)
                {
                    EditImage(input.PhoneImage, input.PhoneImageUrl);
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
                string uploads = Path.Combine(hosting.WebRootPath, "PhoneImages");
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
                string uploads = Path.Combine(hosting.WebRootPath, "PhoneImages");
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
