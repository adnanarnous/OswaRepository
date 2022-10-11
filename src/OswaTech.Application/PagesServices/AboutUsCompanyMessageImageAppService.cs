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
    public class AboutUsCompanyMessageImageAppService : CrudAppService<AboutUsCompanyMessageImages, AboutUsCompanyMessageImagesDto>
    {
        private readonly IRepository<AboutUsCompanyMessageImages, int> repository;
        private readonly IHostingEnvironment hosting;

        public AboutUsCompanyMessageImageAppService(IRepository<AboutUsCompanyMessageImages, int> repository, IHostingEnvironment hosting) : base(repository)
        {
            this.repository = repository;
            this.hosting = hosting;
        }
        public override AboutUsCompanyMessageImagesDto Create(AboutUsCompanyMessageImagesDto input)
        {
            try
            {
                if (input.AboutUsCompanyMessageImagesUrl != null)
                {
                    var BusinessImage = CreateImage(input.CompanyMessageImages) ?? string.Empty;
                    input.AboutUsCompanyMessageImagesUrl = BusinessImage;
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
        public override AboutUsCompanyMessageImagesDto Update(AboutUsCompanyMessageImagesDto input)

        {
            try
            {
                if (input.AboutUsCompanyMessageImagesUrl != null)
                {
                    EditImage(input.CompanyMessageImages, input.AboutUsCompanyMessageImagesUrl);
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
