using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entity
{
    public class Type
    {
        [Key]
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public bool Status { get; set; }
        public int SituationId { get; set; }
        public virtual Situation Situation { get; set; }
        public virtual List<Advert> Adverts { get; set; }
    }
}
