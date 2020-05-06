using DigiMoallem.DAL.Entities.General;
using System;
using System.Collections.Generic;

namespace DigiMoallem.BLL.Interfaces
{
    public interface IStandardService : IDisposable
    {
        List<Standard> GetStandards();

        Standard GetStandardById(int standardId);

        Standard AddStandard(Standard standard);

        Standard UpdateStandard(Standard standard);

        void RemoveStandard(int standardId);

        void RemoveStandard(Standard standard);

        void RemoveStandards(IEnumerable<Standard> standards);

        byte StandardsCount();
    }
}
