using System.Collections.Generic;

namespace ReadData.Entities
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Degree { get; set; }
        public byte[] CoverPhoto { get; set; }

        //Relation many to many
        public ICollection<InstructorCourse> CourseLink { get; set; }
    }
}