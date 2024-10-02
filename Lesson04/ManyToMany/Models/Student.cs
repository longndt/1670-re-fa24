using System.Collections;
using System.Collections.Generic;

namespace ManyToMany.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
