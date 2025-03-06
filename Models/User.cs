using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library.Models
{
    internal class User
    {
        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }


        private string _passwordHash;
        [Required]
        [StringLength(50)]
        public string Password{
            get => _passwordHash;
            set => _passwordHash = BCrypt.Net.BCrypt.HashPassword(value);
        }

        [NotMapped]
        public string ConfirmEmail { get; set; }

        [Required]
        [StringLength(50)]
        public string Role{ get; set; }


        [ForeignKey("Member")]
        public int? MemberID { get; set; }
        public virtual Member? Member { get; set; }



        public virtual List<Logs> logs { get; set; } = new List<Logs>();

        public bool VerifyPassword(string password)
        {
            return BCrypt.Net.BCrypt.Verify(password, _passwordHash);
        }

    }
}
