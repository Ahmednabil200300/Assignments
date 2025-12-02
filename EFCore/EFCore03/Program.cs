using C44_G03_EFCore03.Context;
using C44_G03_EFCore03.Models;
using Microsoft.EntityFrameworkCore;

namespace C44_G03_EFCore03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region InitializeContext
            using (var context = new itiDbContext())
            {
                #endregion

                #region Migrations
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                #endregion

                #region CRUD_Operations
                #region Add
                var department = new Department { DepartmentName = "Technology" };
                context.Departments.Add(department);
                context.SaveChanges();

                var student01 = new Student
                {
                    FirstName = "Ahmed",
                    LastName = "Nabil",
                    StudentAge = 24,
                    DepartmentId = department.DeptId
                };
                var student02 = new Student
                {
                    FirstName = "Mohamed",
                    LastName = "Nour",
                    StudentAge = 21,
                    DepartmentId = department.DeptId
                };

                context.Students.Add(student01);
                context.Students.Add(student02);
                context.SaveChanges();

                Console.WriteLine($"Created Student 1: ID={student01.StudentId}, Name={student01.FirstName} {student01.LastName}, Age={student01.StudentAge}, DepartmentID={student01.DepartmentId}");
                Console.WriteLine($"Created Student 2: ID={student02.StudentId}, Name={student02.FirstName} {student02.LastName}, Age={student02.StudentAge}, DepartmentID={student02.DepartmentId}");

                var instructor = new Instructor
                {
                    InstructorName = "Ali Hassan",
                    InstructorSalary = 3000,
                    DepartmentId = department.DeptId
                };
                context.Instructors.Add(instructor);
                context.SaveChanges();

                Console.WriteLine($"Created Instructor: ID={instructor.InstructorId}, Name={instructor.InstructorName}, Salary={instructor.InstructorSalary}, DepartmentID={instructor.DepartmentId}");

                var topic = new Topic { TopicName = "C#" };
                context.Topics.Add(topic);
                context.SaveChanges();

                var course = new Course { CourseDuration = 40, CourseName = "Programming", CourseDescription = "Intro to Coding", TopicId = topic.TopicId };
                context.Courses.Add(course);
                context.SaveChanges();

                var studCourse = new StudCourse { StudentId = student01.StudentId, CourseId = course.CourseId, CourseGrade = 85 };
                context.StudCourses.Add(studCourse);
                context.SaveChanges();

                context.ChangeTracker.Clear();
                #endregion

                #region Select
                var result = context.Students.Where(s => s.StudentId == student01.StudentId).FirstOrDefault();

                Console.WriteLine($"Student State: {context.Entry(result).State}");
                Console.WriteLine($"Student: {result.FirstName}");
                #endregion

                #region Update
                var updateResult = context.Students.Where(s => s.StudentId == student01.StudentId).FirstOrDefault();

                if (updateResult != null)
                {
                    updateResult.StudentAge = 25;
                    context.SaveChanges();
                    Console.WriteLine($"Updated Student Age: {updateResult.StudentAge}");
                }
                #endregion

                #region Delete
                //var deleteStudCourse = context.StudCourses.Local.FirstOrDefault(sc => sc.StudentId == student01.StudentId && sc.CourseId == course.CourseId);
                //if (deleteStudCourse == null)
                //{
                //    deleteStudCourse = context.StudCourses.Find(student01.StudentId, course.CourseId);
                //}
                //if (deleteStudCourse != null)
                //{
                //    context.StudCourses.Remove(deleteStudCourse);
                //    context.SaveChanges();
                //}

                //var deleteResult = context.Students.Local.FirstOrDefault(s => s.StudentId == student01.StudentId);
                //if (deleteResult == null)
                //{
                //    deleteResult = context.Students.Find(student01.StudentId);
                //}
                //if (deleteResult != null)
                //{
                //    context.Students.Remove(deleteResult);
                //    context.SaveChanges();
                //}
                #endregion
                #endregion
            }
        }
    }
}