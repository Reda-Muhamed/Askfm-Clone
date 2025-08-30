using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Askfm_Clone.Data
{
    public class Answer
    {
        /*
            - Id (PK)
            - QuestionId (FK->Questions)
            - Content (text)
            - CreatedAt
        */
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public int CreatorId { get; set; }
        public AppUser Creator { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<Like> Likes { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
