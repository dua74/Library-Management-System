using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    internal class Book 
    {
        public int BookID { get; set; }

        [Required]
        [StringLength(50)]
        public string Author { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        [StringLength(50)]
        public string ISBN { get; set; }
        [Required]
        [StringLength(50)]
        public string Category { get; set; }
        [Required]
        public int PublishYear { get; set; }

        [Required]
        public int Quantity { get; set; }

       
        public virtual List<Borrowing> Borrowings { get; set; } = new List<Borrowing>();



    }
}
