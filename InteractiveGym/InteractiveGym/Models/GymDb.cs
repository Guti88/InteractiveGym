using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TheGym.Models
{
    public class GymDb : DbContext
    {
        public DbSet<User> tabUser { get; set; }
        public DbSet<Progress> tabProgress { get; set; }
        public DbSet<Archive> tabArchive { get; set; }
        public DbSet<Trening> tabTrening { get; set; }
        public DbSet<Exercise> tabExercise { get; set; }
        public DbSet<UserProgress> tabUserProgress { get; set; }
        public DbSet<TreningExercise> tabTreningExercise { get; set; }
    }
}