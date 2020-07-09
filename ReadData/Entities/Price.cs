namespace ReadData.Entities
{
    public class Price
    {
        public int PriceId { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal Promotion { get; set; }
        public int CourseId { get; set; }

        //Relation 1-1
        public Course Course { get; set; }
    }
}