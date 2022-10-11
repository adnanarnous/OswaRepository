using Abp.Application.Services;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using OswaTech.Dto;
using OswaTech.ServiceImagesModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OswaTech.PagesServices
{
    public class ServiceImageAppServices : CrudAppService<ServiceImages, ServiceImagesDto>
    {
        private readonly IRepository<ServiceImages, int> repository;
        private readonly IHostingEnvironment hosting;

        public ServiceImageAppServices(IRepository<ServiceImages, int> repository, ServiceImages images, IHostingEnvironment hosting) : base(repository)
        {
            this.repository = repository;
            this.hosting = hosting;
        }
        public override ServiceImagesDto Create(ServiceImagesDto input)
        {
            try
            {
                if (input.ServiceImageUrl != null)
                {
                    var ServiceImage = CreateImage(input.ServiceImage) ?? string.Empty;
                    input.ServiceImageUrl = ServiceImage;
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
        public override ServiceImagesDto Update(ServiceImagesDto input)
        {
            try
            {
                if (input.ServiceImageUrl != null)
                {
                    EditImage(input.ServiceImage, input.ServiceImageUrl);
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
                string uploads = Path.Combine(hosting.WebRootPath, "ServiceImages");
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
                string uploads = Path.Combine(hosting.WebRootPath, "ServiceImages");
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
