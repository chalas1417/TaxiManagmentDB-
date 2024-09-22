using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManagment.Domia.Base;

namespace TaxiManagment.Domia.Entities
{
    [Table("Users", Schema ="dbo")]
    public class User : AuditEntity<int>
    {
        [Key]
        [Column("Users")]
        public override int Id {  get; set; }
        public int TaxiId {  get; set; }
        public decimal Document {  get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
