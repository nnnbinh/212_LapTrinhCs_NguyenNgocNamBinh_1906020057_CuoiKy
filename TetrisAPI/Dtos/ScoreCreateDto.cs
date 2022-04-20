using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace TetrisAPI.Dtos
{
    public class ScoreCreateDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int Score { get; set; }
        [Required]
        public DateTime Times{get;set;}
    }
}