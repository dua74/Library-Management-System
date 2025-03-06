using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    internal class Member
    {
        public int MemberID{ get; set; }

        [Required]
        [StringLength(50)]

        public string MemberName { get; set; }

        [Required]
        [EmailAddress]


        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        [Phone]
        public string Phone { get; set; }

        [Required]
        [StringLength(50)]
        public string Membership { get; set; }

       
        public virtual List<Borrowing> Borrowings{ get; set; } = new List<Borrowing>();

        [ForeignKey("User")]
        public int? UserID { get; set; }
        public virtual User? User { get; set; }



    }
}
