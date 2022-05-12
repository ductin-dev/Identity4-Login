using APISV.Models;

namespace APISV.Services
{
    public interface IStudentService
    {
        Task<List<StudentModel>> List();
    }
}
