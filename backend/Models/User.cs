

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.models ;

public class User
    {
        [Key]
        public int UserID { get; set; }
        
        [Required]
        public string UserName { get; set; }
        
        [Required]
        public string Password { get; set; }
        
        [Required]
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public bool IsLoggedIn { get; set; }

        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

        public ICollection<Item> Items { get; set; } = new List<Item>();
    }