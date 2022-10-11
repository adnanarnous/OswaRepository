using Abp.Application.Services;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using OswaTech.AboutUsModel;
using OswaTech.Dto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OswaTech.PagesServices
{
    public class AboutUsCompanyPurposesImageAppService : CrudAppService<AboutUsCompanyPurposesImage, AboutUsCompanyPurposesImageDto>
    {
        private readonly IRepository<AboutUsCompanyPurposesImage, int> repository;
        private readonly IHostingEnvironment hosting;

        public AboutUsCompanyPurposesImageAppService(IRepository<AboutUsCompanyPurposesImage, int> repository, IHostingEnvironment hosting) : base(repository)
        {
            this.repository = repository;
            this.hosting = hosting;
        }
        public override AboutUsCompanyPurposesImageDto Create(AboutUsCompanyPurposesImageDto input)
        {
            try
            {
                if (input.AboutUsCompanyPurposesImagesUrl != null)
                {
                    var BusinessImage = CreateImage(input.CompanyPurposesImages) ?? string.Empty;
                    input.AboutUsCompanyPurposesImagesUrl = BusinessImage;
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
        public override AboutUsCompanyPurposesImageDto Update(AboutUsCompanyPurposesImageDto input)
        {
            try
            {
                if (input.AboutUsCompanyPurposesImagesUrl != null)
                {
                    EditImage(input.CompanyPurposesImages, input.AboutUsCompanyPurposesImagesUrl);
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
                string uploads = Path.Combine(hosting.WebRootPath, "AboutUsImages");
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
                string uploads = Path.Combine(hosting.WebRootPath, "AboutUsImages");
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
