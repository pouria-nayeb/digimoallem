using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Context;
using DigiMoallem.DAL.Entities.General;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DigiMoallem.BLL.Services
{
    public class StandardService : IStandardService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<StandardService> _logger;

        public StandardService(ApplicationDbContext context, ILogger<StandardService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public Standard AddStandard(Standard standard)
        {
            try
            {
                _context.Standards.Add(standard);
                _context.SaveChanges();

                return standard;
            }
            catch (Exception ex)
            {
                _logger.LogError($"{nameof(StandardService)}:\n{ex.StackTrace}\n{ex.Message}");

                return null;
            }
        }

        public Standard GetStandardById(int standardId) => _context.Standards.Find(standardId);

        public List<Standard> GetStandards() => _context.Standards.AsNoTracking().ToList();

        public Standard UpdateStandard(Standard standard)
        {
            try
            {
                _context.Standards.Update(standard);
                _context.SaveChanges();

                return standard;
            }
            catch (Exception ex)
            {
                _logger.LogError($"{nameof(StandardService)}:\n{ex.StackTrace}\n{ex.Message}");

                return null;
            }
        }

        public void RemoveStandard(int standardId)
        {
            try
            {
                var standard = GetStandardById(standardId);

                _context.Standards.Remove(standard);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError($"{nameof(StandardService)}:\n{ex.StackTrace}\n{ex.Message}");
            }
        }

        public void RemoveStandard(Standard standard)
        {
            try
            {
                _context.Standards.Remove(standard);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError($"{nameof(StandardService)}:\n{ex.StackTrace}\n{ex.Message}");
            }
        }

        public void RemoveStandards(IEnumerable<Standard> standards)
        {
            foreach (var standard in standards)
            {
                RemoveStandard(standard);
            }
        }

        public byte StandardsCount() => (byte)_context.Standards.Count();

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
                GC.SuppressFinalize(true);
            }
        }
    }
}
