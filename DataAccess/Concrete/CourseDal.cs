using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        private List<Course> _courses;
        public CourseDal()
        {
            _courses = new List<Course>
        {
            new Course(){CourseId = 1, Name = "C#",Description = "C# KURSU",Price = 10,CategoryId = 1,InstructorId = 1},
            new Course(){CourseId = 2, Name = "JAVA",Description = "JAVA DENEME",Price = 15,CategoryId = 1,InstructorId = 1},
            new Course(){CourseId = 3, Name = "PYHTON",Description = "PYHTON DENEME",Price = 20,CategoryId = 1,InstructorId = 2}

        };
        }
        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(Course course)
        {
            Course courseToDeleted = _courses.SingleOrDefault(c => c.CourseId == course.CourseId);
            _courses.Remove(courseToDeleted);
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public List<Course> GetAllByCategory(int categoryId)
        {
            return _courses.Where(c => c.CategoryId == categoryId).ToList();

        }

        public List<Course> GetAllByInstructor(int instructorId)
        {
            return _courses.Where(c => c.InstructorId == instructorId).ToList();
        }

        public Course GetCourse(int id)
        {
            return _courses.SingleOrDefault(c => c.CourseId == id);
        }

        public void Update(Course course)
        {
            Course courseToUpdated = _courses.SingleOrDefault(c => c.CourseId == course.CourseId);
            courseToUpdated.Name = course.Name;
            courseToUpdated.Description = course.Description;
            courseToUpdated.Price = course.Price;
            courseToUpdated.CategoryId = course.CategoryId;
            courseToUpdated.InstructorId = course.InstructorId;
        }
    }
}
