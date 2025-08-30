namespace Askfm_Clone.Data
{
    public class Like
    {
        public int UserId { get; set; }
        public AppUser User { get; set; }
        public int AnswerId { get; set; }
        public Answer Answer { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
