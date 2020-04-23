using DigiMoallem.BLL.DTOs.Works;
using DigiMoallem.DAL.Entities.General;
using System.Threading.Tasks;

namespace DigiMoallem.BLL.Interfaces
{
    public interface IWorkService
    {
        Work AddWork(Work work);
        Task<Work> AddWorkAsync(Work work);

        WorkPagingViewModel GetWorks(int pageNumber, int pageSize);
        Task<WorkPagingViewModel> GetWorksAsync(int pageNumber, int pageSize);

        Work GetWorkById(int workId);
        Task<Work> GetWorkByIdAsync(int workId);

        Work UpdateWork(Work work);
        Task<Work> UpdateWorkAsync(Work work);

        void RemoveWork(int workId);
        Task RemoveWorkAsync(int workId);

        int WorksCount();
        Task<int> WorksCountAsync();
    }
}
