using Brainlab1.Entities;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brainlab1.DataAccess
{

    [Table("CarService")]
    public class CarService
    {

        [Column("carLicenseNumber")]
        [Required]
        [StringLength(10)]
        public string carLicenseNumber { get; set; }

     
        [Column("startTime")]
        public DateTime startTime { get; set; }

        [Column("finishTime")]
        public DateTime? finishTime { get; set; }

        [Column("status")]
        [Required]
        public int status { get; set; }


        [Column("assignEmployees")]
        [StringLength(4000)]
        public string assignEmployees { get; set; }

        [NotMapped]
        private Employee[] AssignEmployees
        {
            get { return assignEmployees == null ? null : JsonConvert.DeserializeObject<Employee[]>(assignEmployees); }
            set { assignEmployees = JsonConvert.SerializeObject(value); }
        }

        [Column("partsUsed")]
        [StringLength(4000)]
        public string partsUsed { get; set; }


        [NotMapped]
        private Part[] PartsUsed
        {
            get { return partsUsed == null ? null : JsonConvert.DeserializeObject<Part[]>(partsUsed); }
            set { partsUsed = JsonConvert.SerializeObject(value); }
        }


    }

}
