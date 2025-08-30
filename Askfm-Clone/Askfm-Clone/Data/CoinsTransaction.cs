using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Askfm_Clone.Data
{
    public class CoinsTransaction
    {
        /*
               Id,
               UserId (FK),
               Amount (int),           // positive = earn, negative = spend
               Type (enum/string),     // e.g. Reward, Purchase, Gift, AdminAdjustment
               CreatedAt (DateTime)
        */
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ReceiverId { get; set; }
        public AppUser Receiver { get; set; }
        public int Amount { get; set; }
        public string Type { get; set; } // Reward - Purchase - Gift - AdminAdjustment
        public DateTime CreatedAt { get; set; }
    }
}
