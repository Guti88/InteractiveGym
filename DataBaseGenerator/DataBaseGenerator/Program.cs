using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataBaseGenerator.Models;

namespace DataBaseGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            GymDb newDb = new GymDb();
            newDb.CreateDb();
        }
    }

    public class GymDb : DbContext
    {
        public DbSet<User> tabUser { get; set; }
        public DbSet<Progress> tabProgress { get; set; }
        public DbSet<Archive> tabArchive { get; set; }
        public DbSet<Trening> tabTrening { get; set; }
        public DbSet<Exercise> tabExercise { get; set; }
        public DbSet<UserProgress> tabUserProgress { get; set; }
        public DbSet<TreningExercise> tabTreningExercise { get; set; }

        public void CreateDb()
        {
            this.Database.Delete();
            System.Console.WriteLine("Tworzenie bazy\n");

            this.tabUser.Add(new Models.User() { Name = "Łuszak", Surname = "Brykaczowski", Hight = 149, Weight = 112, Role = 1, Login = "Default", Password = "123" });
            this.tabUser.Add(new Models.User() { Name = "Tomasz", Surname = "Marszczaczek", Hight = 175, Weight = 94, Role = 1, Login = "Marszczak", Password = "qwe" });
            this.tabUser.Add(new Models.User() { Id = 3, Name = "Mateusz", Surname = "Godzinski", Hight = 180, Weight = 42, Role = 1, Login = "Grubyy", Password = "Chudy" });
            this.tabUser.Add(new Models.User() { Id = 4, Name = "Koral", Surname = "Hardźwig", Hight = 179, Weight = 90, Role = 1, Login = "Hagrid", Password = "Harry123" });
            this.tabUser.Add(new Models.User() { Id = 6, Name = "Marian", Surname = "Pudzian", Hight = 196, Weight = 142, Role = 0, Login = "admin", Password = "admin" });

            this.tabProgress.Add(new Models.Progress() { Id = 1, Name = "Klatka piersiowa" });
            this.tabProgress.Add(new Models.Progress() { Id = 2, Name = "Biceps" });
            this.tabProgress.Add(new Models.Progress() { Id = 3, Name = "Triceps" });
            this.tabProgress.Add(new Models.Progress() { Id = 4, Name = "Brzuch" });
            this.tabProgress.Add(new Models.Progress() { Id = 5, Name = "Uda" });
            this.tabProgress.Add(new Models.Progress() { Id = 6, Name = "Łydki" });

            this.tabUserProgress.Add(new Models.UserProgress() { UserID = 3, ProgressID = 1, Circuit = 112, Max = 120 });
            this.tabUserProgress.Add(new Models.UserProgress() { UserID = 3, ProgressID = 2, Circuit = 45, Max = 28 });
            this.tabUserProgress.Add(new Models.UserProgress() { UserID = 2, ProgressID = 1, Circuit = 100, Max = 40 });
            this.tabUserProgress.Add(new Models.UserProgress() { UserID = 3, ProgressID = 5, Circuit = 30, Max = 150 });


            this.SaveChanges();
            System.Console.WriteLine("Stworzono bazę");
            System.Console.ReadKey();

        }
    }
}
