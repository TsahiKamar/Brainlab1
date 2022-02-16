using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brainlab1.DataAccess
{


    [Table("Employees")]
    public class Employees
    {
        [Key]
        [Column("nmbr")]
        [Required]
        public int nmbr { get; set; }

        [Column("name")]
        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [Column("profession")]
        [Required]
        [StringLength(50)]
        public string profession { get; set; }

        [Column("salary")]
        [Required]
        public float salary { get; set; }

        [Column("isSupervisor")]
        public Boolean isSupervisor { get; set; }

    }

}
