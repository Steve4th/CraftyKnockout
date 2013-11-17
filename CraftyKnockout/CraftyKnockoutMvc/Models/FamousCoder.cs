namespace CraftyKnockoutMvc.Models
{
    using System.ComponentModel.DataAnnotations;

    public class FamousCoder
    {
        [Required]
        [StringLength(30)]
        public string CoderName { get; set; }

        [Range(0, 100)]
        public int FameScore { get; set; }

        [StringLength(100)]
        public string FamousFor { get; set; }
    }
}