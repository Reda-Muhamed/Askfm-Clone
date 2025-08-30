using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Askfm_Clone.Data
{
    public class Follow
    {
        /*
            - FollowerId (FK->Users)
            - FolloweeId (FK->Users)
            - CreatedAt
        */
        public int FollowerId { get; set; }
        public AppUser Follower { get; set; }
        public int FolloweeId { get; set; }
        public AppUser Followee { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
