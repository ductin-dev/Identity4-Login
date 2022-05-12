using APISV.Models;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace APISV.Services
{
    public class StudentService : IStudentService
    {
        private readonly ApplicationDbContext dbContext;

        public StudentService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<StudentModel>> List()
        {
            var students = await (from student in dbContext.Students
                                  select new StudentModel()
                                  {
                                      Id = student.Id,
                                      Name = student.Name,
                                      Gender = student.Gender,
                                      Description = student.Description,
                                  }).ToListAsync();
            return students;
        }
    }
}
