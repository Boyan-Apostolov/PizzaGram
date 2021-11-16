namespace PizzaGram.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;
    using static DataCostants.User;

    public class User : IdentityUser
    {
        [Required]
        [MaxLength(MaxFullNameLength)]
        public string FullName { get; set; }
    }
}
