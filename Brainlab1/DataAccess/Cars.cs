using Brainlab1.Entities;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brainlab1.DataAccess
{

    [Table("Cars")]
    public class Cars
    {
        [Key]
        [Column("carLicenseNumber")]
        [Required]
        [StringLength(10)]
        public string carLicenseNumber { get; set; }

        [Column("carType")]
        [Required]
        [StringLength(10)]
        public string carType { get; set; }

        [Column("carModel")]
        [Required]
        [StringLength(100)]
        public string carModel { get; set; }

        [Column("customer")]
        [StringLength(4000)]
        public string customer { get; set; }

        [NotMapped]
        private Customer Customer
        {
            get { return customer == null ? null : JsonConvert.DeserializeObject<Customer>(customer); }
            set { customer = JsonConvert.SerializeObject(value); }
        }


    }

}
