using DigiMoallem.BLL.DTOs.Works;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Context;
using DigiMoallem.DAL.Entities.General;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DigiMoallem.BLL.Services
{
    public class WorkService : IWorkService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<WorkService> _logger;

        public WorkService(ApplicationDbContext context,
            ILogger<WorkService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public Work AddWork(Work work)
        {
            try
            {
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

        public async Task<Work> AddWorkAsync(Work work)
        {
            try
            {
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

        public Work GetWorkById(int workId) => _context.Works
            .AsNoTracking()
            .SingleOrDefault(w => w.WorkId == workId);

        public async Task<Work> GetWorkByIdAsync(int workId) => await _context.Works
            .AsNoTracking()
            .SingleOrDefaultAsync(w => w.WorkId == workId);

        public WorkPagingViewModel GetWorks(int pageNumber = 1, int pageSize = 16)
        {
            IQueryable<Work> works = _context.Works;

            int take = pageNumber;
            int skip = (pageNumber - 1) * pageSize;
            int worksCount = works.Count();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(worksCount, take));

            return new WorkPagingViewModel
            {
                Works = works
                .OrderByDescending(w => w.WorkId)
                .Take(take)
                .Skip(skip)
                .ToList(),
                PageCount = pagesCount,
                PageNumber = pageNumber
            };
        }

        public async Task<WorkPagingViewModel> GetWorksAsync(int pageNumber, int pageSize)
        {
            IQueryable<Work> works = _context.Works;

            int take = pageNumber;
            int skip = (pageNumber - 1) * pageSize;
            int worksCount = await works.CountAsync();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(worksCount, take));

            return new WorkPagingViewModel
            {
                Works = await works
                .OrderByDescending(w => w.WorkId)
                .Take(take)
                .Skip(skip)
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
    }
}
