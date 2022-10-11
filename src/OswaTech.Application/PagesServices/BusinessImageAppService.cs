using Abp.Application.Services;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using OswaTech.BusinessModelsPageModel;
using OswaTech.Dto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OswaTech.PagesServices
{
    public class BusinessImageAppServices : CrudAppService<BusinessImages, BusinessImageDto>
    {
        private readonly IRepository<BusinessImages, int> repository;
        private readonly IHostingEnvironment hosting;

        public BusinessImageAppServices(IRepository<BusinessImages, int> repository, IHostingEnvironment hosting) : base(repository)
        {
            this.repository = repository;
            this.hosting = hosting;
        }
        public override BusinessImageDto Create(BusinessImageDto input)
        {
            try
            {
                if (input.BusinessModelImageUrl != null)
                {
                    var BusinessImage = CreateImage(input.BusinessImage) ?? string.Empty;
                    input.BusinessModelImageUrl = BusinessImage;
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
        public override BusinessImageDto Update(BusinessImageDto input)
        {
            try
            {
                if (input.BusinessModelImageUrl != null)
                {
                    EditImage(input.BusinessImage, input.BusinessModelImageUrl);
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
                string uploads = Path.Combine(hosting.WebRootPath, "BusinessImages");
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
                string uploads = Path.Combine(hosting.WebRootPath, "BusinessImages");
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
