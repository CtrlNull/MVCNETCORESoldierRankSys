using Microsoft.EntityFrameworkCore;
using InterviewExercise.Models;

namespace InterviewExercise.Data
{
    public class MvcSoldierContext : DbContext
    {
        public MvcSoldierContext (DbContextOptions<MvcSoldierContext> options) :base (options) {

        }

        public DbSet<SoldierList> SoldierLists {get; set;} 
    }
}