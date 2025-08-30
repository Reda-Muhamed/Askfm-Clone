using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Askfm_Clone.Data
{
    public class Question
    {
        /*
            - Id (PK)
            - FromUserId (FK->Users, nullable for anonymous)
            - ToUserId (FK->Users)
            - Content (text)
            - CreatedAt
            - IsAnonymous (bool)
            - IsBlocked (bool)
         */
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int FromUserId { get; set; }
        public AppUser Sender { get; set; }
        public int ToUserId { get; set; }
        public AppUser Receiver { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsAnonymous { get; set; }
        public bool IsBlocked { get; set; }
    }
}
