
using AutoMapper;
using TetrisAPI.Dtos;
using TetrisAPI.Models;

namespace TetrisAPI.Profiles
{
    public class ScoreProfile : Profile
    {
        public ScoreProfile()
        {
            CreateMap<ScoreCreateDto,ScoreDetailModel>();
            CreateMap<ScoreDetailModel,ScoreReadDto>();
        }
    }
}