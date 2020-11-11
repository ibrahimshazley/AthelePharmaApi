using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AthelePharmaERP_API.Models
{
    public abstract class Entity
    {
        [Key]
        public virtual long Id { get; set; }
    }


    public abstract class NoGeneratedEntity : Entity
    {
        [Key]
        public override long Id { get; set; }
    }
    
}
