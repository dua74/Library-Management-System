using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    internal class Borrowing
    {
        public int BorrowingID { get; set; }

        [Required]
        public DateTime BorrowDate { get; set; } 
        [Required]
        public DateTime DueDate { get; set; } 
        public DateTime? ReturnDate { get; set; } 


        [ForeignKey("Book")]
        public int BookID { get; set; }
        public virtual Book Book { get; set; }

        [ForeignKey("Member")]
        public int MemberID { get; set; }
        public virtual Member Member { get; set; }


        public Borrowing()
        {
            BorrowDate = DateTime.Now;
            DueDate = BorrowDate.AddDays(14);
        }
    }
}
