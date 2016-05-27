using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MissWish.Models
{
    [Table("Contacts")]
    public class Contact
    {
        public long ContactId { get; set; }

        public string FullName { get; set; }

        public string MobileNumber { get; set; }

        public long UserId { get; set; }

        public virtual User User { get; set; }
    }
}