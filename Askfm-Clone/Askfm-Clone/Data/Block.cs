using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Askfm_Clone.Data
{
    public class Block
    {
        /*
            - BlockerId (FK->Users)
            - BlockedUserId (FK->Users, nullable for anonymous block)
            - IsAnonymousBlock (bool)
            - CreatedAt
         */
        public int BlockerId { get; set; }
        public AppUser Blocker { get; set; }
        public int BlockedId { get; set; }
        public AppUser Blocked { get; set; }
        public bool IsAnonymous { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
