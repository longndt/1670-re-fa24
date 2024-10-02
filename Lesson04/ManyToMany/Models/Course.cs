using System.Collections;
using System.Collections.Generic;

namespace ManyToMany.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
