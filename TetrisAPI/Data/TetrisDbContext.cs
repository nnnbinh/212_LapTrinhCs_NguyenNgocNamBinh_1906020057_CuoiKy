using TetrisAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace TetrisAPI.Data{
    public class TetrisDbContext: DbContext{
        public TetrisDbContext(DbContextOptions<TetrisDbContext> opt):base(opt){
            
        }
        public DbSet<ScoreDetailModel> Scores{get;set;}

    }
}