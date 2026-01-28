using BgutuGrades.Data;
using Grades.Entities;
using Microsoft.EntityFrameworkCore;

namespace BgutuGrades.Repositories
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAllStudentsAsync();
        Task<IEnumerable<Student>> GetStudentsByGroupAsync(int groupId);
        Task<Student> CreateStudentAsync(Student entity);
        Task<Student?> GetByIdAsync(int id);
        Task<bool> UpdateStudentAsync(Student entity);
        Task<bool> DeleteStudentAsync(int id);
    }

    public class StudentRepository(AppDbContext dbContext) : IStudentRepository
    {
        private readonly AppDbContext _dbContext = dbContext;

        public async Task<Student> CreateStudentAsync(Student entity)
        {
            await _dbContext.Students.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteStudentAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            _dbContext.Students.Remove(entity);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Student?> GetByIdAsync(int id)
        {
            var entity = await _dbContext.Students.FindAsync(id);
            return entity;
        }

        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            var entities = await _dbContext.Students
                .AsNoTracking()
                .ToListAsync();
            return entities;
        }

        public async Task<IEnumerable<Student>> GetStudentsByGroupAsync(int groupId)
        {
            var entities = await _dbContext.Students
                .Where(s => s.GroupId == groupId)
                .AsNoTracking()
                .ToListAsync();
            return entities;
        }

        public async Task<bool> UpdateStudentAsync(Student entity)
        {
            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
