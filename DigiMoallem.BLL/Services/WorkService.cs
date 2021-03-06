﻿using DigiMoallem.BLL.DTOs.Works;
using DigiMoallem.BLL.Helpers.Converters;
using DigiMoallem.BLL.Helpers.Generators;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Context;
using DigiMoallem.DAL.Entities.General;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DigiMoallem.BLL.Services
{
    public class WorkService : IWorkService
    {
        private ApplicationDbContext _context;
        private readonly ILogger<WorkService> _logger;

        public WorkService(ApplicationDbContext context,
            ILogger<WorkService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public Work AddWork(WorkInitialDataViewModel workInitVM)
        {
            try
            {
                var work = new Work
                {
                    FirstName = workInitVM.FirstName,
                    LastName = workInitVM.LastName,
                    Email = workInitVM.Email,
                    PhoneNumber = workInitVM.PhoneNumber,
                    Mobile = workInitVM.Mobile,
                    Gender = workInitVM.Gender,
                    SubmitDate = DateTime.Now,
                    IsChecked = false
                };

                work.AvatarName = UploadAvatarImage(workInitVM.AvatarFile);
                work.CvTitle = UploadCv(workInitVM.CvFile);

                _context.Works.Add(work);
                _context.SaveChanges();

                return work;
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.StackTrace}\n{ex.Message}");

                return null;
            }
        }

        public async Task<Work> AddWorkAsync(WorkInitialDataViewModel workInitVM)
        {
            try
            {
                var work = new Work
                {
                    FirstName = workInitVM.FirstName,
                    LastName = workInitVM.LastName,
                    Email = workInitVM.Email,
                    PhoneNumber = workInitVM.PhoneNumber,
                    Mobile = workInitVM.Mobile,
                    Gender = workInitVM.Gender,
                    SubmitDate = DateTime.Now,
                    IsChecked = false,
                    EducationalLevel = workInitVM.EducationalLevel,
                    CardNumber = workInitVM.CardNumber,
                    Sheba = workInitVM.Sheba
                };

                work.AvatarName = UploadAvatarImage(workInitVM.AvatarFile);
                work.CvTitle = UploadCv(workInitVM.CvFile);

                await _context.Works.AddAsync(work);
                await _context.SaveChangesAsync();

                return work;
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.StackTrace}\n{ex.Message}");

                return null;
            }
        }

        public Work UpdateWork(WorkComplementDataViewModel workCompVM)
        {
            try
            {
                var work = GetWorkById(workCompVM.WorkId);

                work.Skills = workCompVM.Skills;
                work.Experiences = workCompVM.Experiences;
                work.ContributionFields = workCompVM.ContributionFields;

                _context.Works.Update(work);
                _context.SaveChanges();

                return work;
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.StackTrace}\n{ex.Message}");

                return null;
            }
        }

        public async Task<Work> UpdateWorkAsync(WorkComplementDataViewModel workCompVM)
        {
            try
            {
                var work = await GetWorkByIdAsync(workCompVM.WorkId);

                work.Skills = workCompVM.Skills;
                work.Experiences = workCompVM.Experiences;
                work.ContributionFields = workCompVM.ContributionFields;

                _context.Works.Update(work);
                await _context.SaveChangesAsync();

                return work;
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.StackTrace}\n{ex.Message}");

                return null;
            }
        }

        public Work GetWorkById(int workId) => _context.Works
            .SingleOrDefault(w => w.WorkId == workId);

        public async Task<Work> GetWorkByIdAsync(int workId) => await _context.Works
            .SingleOrDefaultAsync(w => w.WorkId == workId);

        public WorkComplementDataViewModel GetWorkCompById(int workId) => _context.Works.Select(w =>
        new WorkComplementDataViewModel { WorkId = w.WorkId }).SingleOrDefault(w => w.WorkId == workId);

        public async Task<WorkComplementDataViewModel> GetWorkCompByIdAsync(int workId) => await _context.Works.Select(w =>
        new WorkComplementDataViewModel { WorkId = w.WorkId }).SingleOrDefaultAsync(w => w.WorkId == workId);

        public WorkPagingViewModel GetWorks(int pageNumber = 1, int pageSize = 16)
        {
            IQueryable<Work> works = _context.Works;

            int take = pageSize;
            int skip = (pageNumber - 1) * pageSize;
            int worksCount = works.Count();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(worksCount, take));

            return new WorkPagingViewModel
            {
                Works = works
                .Skip(skip)
                .Take(take)
                .OrderByDescending(w => w.IsChecked == false)
                .AsNoTracking()
                .ToList(),
                PageCount = pagesCount,
                PageNumber = pageNumber
            };
        }

        public async Task<WorkPagingViewModel> GetWorksAsync(int pageNumber, int pageSize)
        {
            IQueryable<Work> works = _context.Works;

            int take = pageSize;
            int skip = (pageNumber - 1) * pageSize;
            int worksCount = await works.CountAsync();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(worksCount, take));

            return new WorkPagingViewModel
            {
                Works = await works
                .Skip(skip)
                .Take(take)
                .OrderByDescending(w => w.IsChecked == false)
                .AsNoTracking()
                .ToListAsync(),
                PageCount = pagesCount,
                PageNumber = pageNumber
            };
        }

        public void RemoveWork(int workId)
        {
            var work = GetWorkById(workId);

            _context.Works.Remove(work);
            _context.SaveChanges();
        }

        public async Task RemoveWorkAsync(int workId)
        {
            var work = await GetWorkByIdAsync(workId);

            _context.Works.Remove(work);
            await _context.SaveChangesAsync();
        }

        public Work UpdateWork(Work work)
        {
            try
            {
                _context.Works.Update(work);
                _context.SaveChanges();

                return work;
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.StackTrace}\n{ex.Message}");

                return null;
            }
        }

        #region SearchWorks
        public WorkPagingViewModel SearchWorks(string email, int pageNumber, int pageSize)
        {
            IQueryable<Work> works = _context.Works;

            int take = pageSize;
            int skip = (pageNumber - 1) * pageSize;
            int worksCount = works.Count();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(worksCount, take));

            return new WorkPagingViewModel
            {
                Works = works
                .Where(p => p.Email.TextTransform().Contains(email.TextTransform()))
                .OrderByDescending(w => w.SubmitDate)
                .Skip(skip)
                .Take(take)
                .AsNoTracking()
                .ToList(),
                PageCount = pagesCount,
                PageNumber = pageNumber
            };
        }

        public async Task<WorkPagingViewModel> SearchWorksAsync(string email, int pageNumber = 1, int pageSize = 16)
        {
            IQueryable<Work> works = _context.Works
                                .Where(p => p.Email.TextTransform().Contains(email.TextTransform()));
            int take = pageSize;
            int skip = (pageNumber - 1) * take;
            int worksCount = works.Count();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(worksCount, take));

            return new WorkPagingViewModel
            {
                Works = await works
                .OrderByDescending(w => w.SubmitDate)
                .Skip(skip)
                .Take(take)
                .ToListAsync(),
                PageCount = pagesCount,
                PageNumber = pageNumber
            };
        }
        #endregion

        public async Task<Work> UpdateWorkAsync(Work work)
        {
            try
            {
                _context.Works.Update(work);
                await _context.SaveChangesAsync();

                return work;
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.StackTrace}\n{ex.Message}");

                return null;
            }
        }

        public int WorksCount() => _context.Works.Count();

        public async Task<int> WorksCountAsync() => await _context.Works.CountAsync();

        public int NewWorksCount() => _context.Works.Where(w => w.IsChecked == false).Count();

        public string UploadAvatarImage(IFormFile avatarImage)
        {
            if (avatarImage != null)
            {
                // image file uploaded
                string imageName = CodeGenerator.GenerateUniqueCode() + Path.GetExtension(avatarImage.FileName);
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/avatars/", imageName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    avatarImage.CopyTo(stream);
                }

                return imageName;
            }
            else
            {
                // no image file uploaded
                return "default.png";
            }
        }

        public string UploadCv(IFormFile cv)
        {
            if (cv != null)
            {
                // cv file uploaded
                string cvName = CodeGenerator.GenerateUniqueCode() + Path.GetExtension(cv.FileName);
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/cvs/", cvName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    cv.CopyTo(stream);
                }

                return cvName;
            }
            else
            {
                // no cv file uploaded
                return null;
            }
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
                GC.SuppressFinalize(true);
            }

            _context = null;
        }
    }
}
