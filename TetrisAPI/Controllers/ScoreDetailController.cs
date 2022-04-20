using System;
using System.Linq;
using TetrisAPI.Data;
using TetrisAPI.Dtos;
using TetrisAPI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;
using System.Text;

namespace TetrisAPI.Controllers
{           
    [Route("api/[controller]")]
    [ApiController]
    public class ScoreDetailController : ControllerBase
    {
        private readonly TetrisDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        static readonly HttpClient client = new HttpClient();

        public ScoreDetailController(TetrisDbContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }
        [HttpPost]
        public ActionResult<ScoreReadDto> CreateScore(ScoreCreateDto scoreSendDto)
        {
            var subscription = _context.Scores.FirstOrDefault(s => s.Name == scoreSendDto.Name && s.Score==scoreSendDto.Score);
            Console.WriteLine(subscription);
            if(subscription == null){
                subscription = _mapper.Map<ScoreDetailModel>(scoreSendDto);
                try
                {
                    _context.Scores.Add(subscription);
                    _context.SaveChanges();
                }
                catch(Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            return Ok();
        }

        [HttpGet]
        public ActionResult GetHighScore()
        {
            var HighScore = _context.Scores.OrderByDescending(s=>s.Score).Take(5);
            //This mapping won't work as I have not done the Profiles section Duh!!!
            return Ok(HighScore);
        }

    }
}