using System;

namespace ReadData.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DatePublish { get; set; }

        //Relation 1-1
        public Price PromotionPrice { get; set; }
    }
}