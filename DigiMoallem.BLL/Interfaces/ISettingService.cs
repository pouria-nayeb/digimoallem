using DigiMoallem.DAL.Entities.General;

namespace DigiMoallem.BLL.Interfaces
{
    public interface ISettingService
    {
        Setting GetSettingById(int settingId);

        Setting UpdateSetting(Setting setting);
    }
}
