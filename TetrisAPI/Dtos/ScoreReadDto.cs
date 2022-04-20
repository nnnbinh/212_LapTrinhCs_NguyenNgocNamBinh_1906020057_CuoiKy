using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace TetrisAPI.Dtos
{
    public class ScoreReadDto
    {
        public string Name { get; set; }

        public int Score { get; set; }

        public DateTime Times{get;set;}
    }
}