using Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Repositories
{
    public interface IScheduleRepository
    {
        // CURD
        Task<Schedule> AddScheduleAsync(Schedule schedule);
        Task<Schedule> UpdateScheduleAsync(Schedule schedule);
        Task<bool> DeleteScheduleAsync(int id);

        // Get 
        Task<IEnumerable<Schedule>> GetAllSchedulesAsync();
        Task<Schedule?> GetScheduleByIdAsync(int id);
        Task<IEnumerable<Schedule>> GetSchedulesByDoctorAsync(int doctorId);
    }
}