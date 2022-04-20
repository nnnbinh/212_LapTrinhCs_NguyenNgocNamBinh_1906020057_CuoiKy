using System.ComponentModel.DataAnnotations;
namespace TetrisAPI.Models
{
    public class ScoreDetailModel{
        [Key]
        [Required]        
        public int Id {get;set;}
        [Required]   
        public string Name { get; set; }
        [Required]
        public int Score { get; set; }

        [Required]
        public DateTime Times {get;set;}
    }
}