namespace ReadData.Entities
{
    public class InstructorCourse
    {
        public int InstructorId { get; set; }
        public int CourseId { get; set; }

        //Anchor
        public Course Course { get; set; }
        public Instructor Instructor { get; set; }
    }
}