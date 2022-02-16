using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brainlab1.DataAccess
{

    [Table("PriceList")]
    public class PriceList
    {
        [Column("carType")]
        [Required]
        [StringLength(10)]
        public string carType { get; set; }

        [Column("carModel")]
        [Required]
        [StringLength(100)]
        public string carModel { get; set; }

        [Column("hourWorkPrice")]
        [Required]
        public float hourWorkPrice { get; set; }

    }

}
