using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Core.Entities
{
    public class Base
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public long Id { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CreatedOn { get; set; }
        [Required]
        public long CreatedBy { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime UpdatedOn { get; set; }
        public long UpdatedBy { get; set; }

    }
}
