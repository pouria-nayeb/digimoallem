using DigiMoallem.BLL.DTOs.HyperLink;
using DigiMoallem.BLL.Helpers.Generators;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Context;
using DigiMoallem.DAL.Entities.General;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Linq;

namespace DigiMoallem.BLL.Services
{
    public class HyperLinkService : IHyperLinkService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HyperLinkService> _logger;

        public HyperLinkService(ApplicationDbContext context,
            ILogger<HyperLinkService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public UploadLink AddHyperLink(UploadLink uploadLink, IFormFile file)
        {
            try
            {
                string fileName = UploadFile(file);

                uploadLink.FileTitle = fileName;
                uploadLink.Url = $"/images/files/{fileName}";

                _context.UploadLinks.Add(uploadLink);
                _context.SaveChanges();

                return uploadLink;
            }
            catch (Exception ex)
            {
                _logger.LogError($"{nameof(HyperLinkService)}\n{ex.StackTrace}\n{ex.Message}");

                return null;
            }
        }

        public HyperLinkViewModel GetHyperLinks(int pageNumber = 1, int pageSize = 32)
        {
            IQueryable<UploadLink> uploadLinks = _context.UploadLinks;

            int take = pageSize;
            int skip = (pageNumber - 1) * take;
            int uploadLinksCount = uploadLinks.Count();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(uploadLinksCount, take));

            return new HyperLinkViewModel
            {
                UploadLinks = uploadLinks.
                Skip(skip)
                .Take(take)
                .OrderByDescending(ul => ul.UploadLinkId)
                .ToList(),
                PageNumber = pageNumber,
                PagesCount = pagesCount
            };
        }

        public UploadLink GetHyperLinkById(int UploadLinkId) => _context.UploadLinks.Find(UploadLinkId);

        public void RemoveHyperLink(int uploadLinkId)
        {
            var uploadLink = GetHyperLinkById(uploadLinkId);

            RemoveFile(uploadLink);

            _context.UploadLinks.Remove(uploadLink);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
                GC.SuppressFinalize(true);
            }
        }

        private string UploadFile(IFormFile file) 
        {
            if (file != null)
            {
                string fileName = CodeGenerator.GenerateUniqueCode() + Path.GetExtension(file.FileName);
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files/", fileName);

                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                return fileName;
            }

            return string.Empty;
        }

        private void RemoveFile(UploadLink uploadLink) 
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files/", uploadLink.FileTitle);

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}
