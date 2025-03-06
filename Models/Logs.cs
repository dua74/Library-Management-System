using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    internal class Logs
    {
        [Key]
        public int LogID { get; set; }

        [Required]
        [StringLength(50)]
        public string ActionType { get; set; }

        [Required]
        public DateTime ActionDate { get; set; }= DateTime.Now;

        [ForeignKey("User")]
        public int UserID { get; set; }
        public virtual User User { get; set; }
    }
}
