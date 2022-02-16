using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brainlab1.DataAccess
{
 
        [Table("GeneralInfo")]
        public class GeneralInfo
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
   

        [Column("phones")]
        [StringLength(4000)]
        public string phones { get; set; }

     
        [NotMapped]
        private string[] Phones
        {
            get { return phones == null ? null : JsonConvert.DeserializeObject<string[]>(phones); }
            set { phones = JsonConvert.SerializeObject(value); }
        }

        [Column("address")]
        [Required]
        [StringLength(200)]
        public string address { get; set; }

        [Column("manager")]
        [Required]
        [StringLength(50)]
        public string manager { get; set; }

        }

}
