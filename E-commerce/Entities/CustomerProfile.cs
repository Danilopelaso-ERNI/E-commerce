using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.Entities
{
    [PrimaryKey("CustomerId")]
    public class CustomerProfile
    {
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public virtual Customer Customer { get; set; }
    }
}