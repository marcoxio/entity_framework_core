using System;
using System.Collections.Generic;

namespace ReadData.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DatePublish { get; set; }
        public byte[] CoverPhoto { get; set; }

        //Relation one to one
        public Price PromotionPrice { get; set; }

        //Relation one to many
        public ICollection<Comment> ListComment { get; set; }

        //Relation many to many
        public ICollection<InstructorCourse> InstructorLink { get; set; }
    }
}