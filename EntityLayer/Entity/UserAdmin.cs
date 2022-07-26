using Microsoft.AspNetCore.Identity;

namespace EntityLayer.Entity
{
    public class UserAdmin:IdentityUser
    {
        public string FullName { get; set; }
        public virtual List<Advert> Adverts { get; set; }
    }
}
