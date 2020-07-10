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

        //Relation one to one
        public Price PromotionPrice { get; set; }

        //Relation one to many
        public ICollection<Comment> ListComment { get; set; }
    }
}