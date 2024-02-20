using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        private List<Instructor> _instructor;

        public InstructorDal()
        {
            _instructor = new List<Instructor>
        {
            new Instructor(){InstructorId = 1,FirstName = "Engin",LastName = "Demirog"},
            new Instructor(){InstructorId = 2,FirstName = "Ahmet Furkan",LastName = "Çelik"}
        };
        }
        public void Add(Instructor instructor)
        {
            _instructor.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            Instructor instructorToDelete = _instructor.SingleOrDefault(t => t.InstructorId == instructor.InstructorId);
            _instructor.Remove(instructorToDelete);
        }

        public List<Instructor> GetAll()
        {
            return _instructor;
        }

        public Instructor GetInstructor(int id)
        {
            return _instructor.Find(t => t.InstructorId == id);
        }

        public void Update(Instructor instructor)
        {
            Instructor instructorToUpdate = _instructor.SingleOrDefault(t => t.InstructorId == instructor.InstructorId);
            instructorToUpdate.FirstName = instructor.FirstName;
            instructorToUpdate.LastName = instructor.LastName;
        }
    }
}
