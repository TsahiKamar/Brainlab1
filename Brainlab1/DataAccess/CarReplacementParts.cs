using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brainlab1.DataAccess
{


    [Table("CarReplacementParts")]
    public class CarReplacementParts
    {
        [Key]
        [Column("partNumber")]
        [Required]
        public int partNumber { get; set; }

        [Column("name")]
        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [Column("carType")]
        [Required]
        [StringLength(10)]
        public string carType { get; set; }

        [Column("carModel")]
        [Required]
        [StringLength(100)]
        public string carModel { get; set; }

        [Column("price")]
        [Required]
        public float price { get; set; }

    }


}
