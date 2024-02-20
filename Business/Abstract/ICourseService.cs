using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseService
    {
        List<Course> GetAll();
        Course GetCourse(int id);
        void Add(Course course);
        void Update(Course course);
        void Delete(Course course);
        List<Course> GetAllByCategory(int categoryId);
        List<Course> GetAllByInstructor(int instructorId);
    }
}
