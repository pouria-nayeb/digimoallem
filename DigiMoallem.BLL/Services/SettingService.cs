using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Context;
using DigiMoallem.DAL.Entities.General;
using Microsoft.Extensions.Logging;
using System;

namespace DigiMoallem.BLL.Services
{
    public class SettingService : ISettingService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<SettingService> _logger;

        public SettingService(ApplicationDbContext context,
            ILogger<SettingService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public Setting GetSettingById(int settingId) => _context.Settings.Find(settingId);

        public Setting UpdateSetting(Setting setting)
        {
            try
            {
                _context.Settings.Update(setting);
                _context.SaveChanges();

                return setting;
            }
            catch (Exception ex)
            {
                #if DEBUG
                _logger.LogError($"{ex.StackTrace}\n{ex.Message}");
                #endif

                return null;
            }
        }
    }
}
