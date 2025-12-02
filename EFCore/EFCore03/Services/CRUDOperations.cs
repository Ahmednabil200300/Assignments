using C44_G03_EFCore03.Context;
using C44_G03_EFCore03.Models;
using Microsoft.EntityFrameworkCore;

namespace C44_G03_EFCore03.Services
{
    public class CRUDOperations
    {
        private readonly itiDbContext _context;

        public CRUDOperations()
        {
            _context = new itiDbContext();
        }

        #region CreateOperations
        public void CreateStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void CreateInstructor(Instructor instructor)
        {
            _context.Instructors.Add(instructor);
            _context.SaveChanges();
        }

        public void CreateDepartment(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
        }

        public void CreateCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public void CreateTopic(Topic topic)
        {
            _context.Topics.Add(topic);
            _context.SaveChanges();
        }

        public void CreateStudCourse(StudCourse studCourse)
        {
            _context.StudCourses.Add(studCourse);
            _context.SaveChanges();
        }

        public void CreateCourse_Inst(Course_Inst course_Inst)
        {
            _context.Course_Insts.Add(course_Inst);
            _context.SaveChanges();
        }
        #endregion

        #region ReadOperations
        public Student GetStudent(int id)
        {
            return _context.Students.Find(id);
        }

        public Instructor GetInstructor(int id)
        {
            return _context.Instructors.Include(i => i.Department).FirstOrDefault(i => i.InstructorId == id);
        }

        public Department GetDepartment(int id)
        {
            return _context.Departments.Include(d => d.HeadInstructor).FirstOrDefault(d => d.DeptId == id);
        }

        public Course GetCourse(int id)
        {
            return _context.Courses.Include(c => c.Topic).FirstOrDefault(c => c.CourseId == id);
        }

        public Topic GetTopic(int id)
        {
            return _context.Topics.Find(id);
        }

        public StudCourse GetStudCourse(int studentId, int courseId)
        {
            return _context.StudCourses.Find(studentId, courseId);
        }

        public Course_Inst GetCourse_Inst(int instructorId, int courseId)
        {
            return _context.Course_Insts.Find(instructorId, courseId);
        }
        #endregion

        #region UpdateOperations
        public void UpdateStudent(Student student)
        {
            if (student != null)
            {
                _context.Students.Update(student);
                _context.SaveChanges();
            }
        }

        public void UpdateInstructor(Instructor instructor)
        {
            if (instructor != null)
            {
                _context.Instructors.Update(instructor);
                _context.SaveChanges();
            }
        }

        public void UpdateDepartment(Department department)
        {
            if (department != null)
            {
                _context.Departments.Update(department);
                _context.SaveChanges();
            }
        }

        public void UpdateCourse(Course course)
        {
            if (course != null)
            {
                _context.Courses.Update(course);
                _context.SaveChanges();
            }
        }

        public void UpdateTopic(Topic topic)
        {
            if (topic != null)
            {
                _context.Topics.Update(topic);
                _context.SaveChanges();
            }
        }

        public void UpdateStudCourse(StudCourse studCourse)
        {
            if (studCourse != null)
            {
                _context.StudCourses.Update(studCourse);
                _context.SaveChanges();
            }
        }

        public void UpdateCourse_Inst(Course_Inst course_Inst)
        {
            if (course_Inst != null)
            {
                _context.Course_Insts.Update(course_Inst);
                _context.SaveChanges();
            }
        }
        #endregion

        #region DeleteOperations
        public void DeleteStudent(int id)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
        }

        public void DeleteInstructor(int id)
        {
            var instructor = _context.Instructors.Find(id);
            if (instructor != null)
            {
                _context.Instructors.Remove(instructor);
                _context.SaveChanges();
            }
        }

        public void DeleteDepartment(int id)
        {
            var department = _context.Departments.Find(id);
            if (department != null)
            {
                _context.Departments.Remove(department);
                _context.SaveChanges();
            }
        }

        public void DeleteCourse(int id)
        {
            var course = _context.Courses.Find(id);
            if (course != null)
            {
                _context.Courses.Remove(course);
                _context.SaveChanges();
            }
        }

        public void DeleteTopic(int id)
        {
            var topic = _context.Topics.Find(id);
            if (topic != null)
            {
                _context.Topics.Remove(topic);
                _context.SaveChanges();
            }
        }

        public void DeleteStudCourse(int studentId, int courseId)
        {
            var studCourse = _context.StudCourses.Find(studentId, courseId);
            if (studCourse != null)
            {
                _context.StudCourses.Remove(studCourse);
                _context.SaveChanges();
            }
        }

        public void DeleteCourse_Inst(int instructorId, int courseId)
        {
            var course_Inst = _context.Course_Insts.Find(instructorId, courseId);
            if (course_Inst != null)
            {
                _context.Course_Insts.Remove(course_Inst);
                _context.SaveChanges();
            }
        }
        #endregion
    }
}