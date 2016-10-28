using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace RAD301S00151925Clubs.Models.ClubModel
{
  [Table("ClubEvent")]
    public class ClubEvent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventID { get; set; }
        public string Venue { get; set; }
        public string Location { get; set; }
        [ForeignKey("associatedClub")]
        public int ClubId { get; set; }
        public virtual Club associatedClub { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public virtual ICollection<Member> attendees { get; set; }

    }
}