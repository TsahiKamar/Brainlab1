using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brainlab1.DataAccess
{

    [Table("Customers")]
    public class Customers
    {
        [Key]
        [Column("id")]
        [Required]
        [StringLength(10)]
        public string id { get; set; }

        [Column("name")]
        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [Column("tel")]
        [Required]
        [StringLength(10)]
        public string tel { get; set; }

    }

}
