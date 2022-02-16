using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brainlab1.DataAccess
{

    [Table("Invoices")]
    public class Invoices
    {
        [Column("customerId")]
        [Required]
        [StringLength(10)]
        public string customerId { get; set; }

        [Column("customerName")]
        [Required]
        [StringLength(100)]
        public string customerName { get; set; }

        [Column("date")]
        [Required]
        public DateTime date { get; set; }

        [Column("amount")]
        [Required]
        public float amount { get; set; }

        [Column("details")]
        [Required]
        [StringLength(500)]
        public string details { get; set; }

    }

}
