using System.Collections.Generic;
using System.Threading.Tasks;
using Week10Day1Demo.Models;

namespace Week10Day1Demo.Services.Students
{
    public interface IStudentsService
    {
        List<Student> GetAllStudents();
        void Insert(Student student);
        void Update(Student student);
        void Delete(Student student);
        
        Task<List<Student>> GetAllStudentsAsync();
        Task InsertAsync(Student student);
        Task UpdateAsync(Student student);
        Task DeleteAsync(int rollNo);
        Task<Student> Find(int rollNo);
    }
}