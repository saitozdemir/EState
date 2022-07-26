using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entity
{
    public class Images
    {
        [Key]
        public int ImageId { get; set; }
        public string ImageName { get; set; }
        public bool Status { get; set; }
        public int AdvertId { get; set; }
        public virtual Advert Advert { get; set; }
    }
}
