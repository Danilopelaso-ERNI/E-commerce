using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.Entities
{
    [PrimaryKey("Id")]
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual CustomerProfile Profile { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}