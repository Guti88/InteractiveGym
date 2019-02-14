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
        public DbSet<Archive> tabArchive { get; set; }
        public DbSet<Dimensions> tabDimensions { get; set; }
        public DbSet<Exercise> tabExercise { get; set; }
        public DbSet<History> tabHistory { get; set; }
        public DbSet<Trening> tabTrening { get; set; }
        public DbSet<TreningExercise> tabTreningExercise { get; set; }
        public DbSet<User> tabUser { get; set; }
        public DbSet<UserPerformance> tabUserPerformance { get; set; }
        

        public void CreateDb()
        {
            this.Database.Delete();
            System.Console.WriteLine("Tworzenie bazy\n");
            //Users
            this.tabUser.Add(new Models.User() { Id = 1, Name = "Marian", Surname = "Pudzian", Hight = 196, Weight = 142, Role = 0, Login = "admin", Password = "admin" });
            this.tabUser.Add(new Models.User() { Id = 2, Name = "Axel", Surname = "Rombowicz", Hight = 178, Weight = 65, Role = 0, Login = "trenerson", Password = "Gunar" });
            this.tabUser.Add(new Models.User() { Id = 101, Name = "Łuszak", Surname = "Brykaczowski", Hight = 149, Weight = 112, Role = 1, Login = "Default", Password = "123" });
            this.tabUser.Add(new Models.User() { Id = 102, Name = "Tomasz", Surname = "Marszczaczek", Hight = 175, Weight = 94, Role = 1, Login = "Marszczak", Password = "qwe" });
            this.tabUser.Add(new Models.User() { Id = 103, Name = "Mateusz", Surname = "Godzinski", Hight = 180, Weight = 42, Role = 1, Login = "Grubyy", Password = "Chudy" });
            this.tabUser.Add(new Models.User() { Id = 104, Name = "Koral", Surname = "Hardźwig", Hight = 179, Weight = 90, Role = 1, Login = "Hagrid", Password = "Harry123" });

            this.SaveChanges();
            System.Console.WriteLine("Zapisano użytkowników");
            //Exercises
            this.tabExercise.Add(new Models.Exercise() { Id=10, Name = "Bench press", Description = "Wyciskanie sztangi leżąc na lawce prostej" });
            this.tabExercise.Add(new Models.Exercise() { Id = 11, Name = "Dumbbell flys", Description = "Rozpiętki ze sztangielkami leżąc na ławce prostej" });
            this.tabExercise.Add(new Models.Exercise() { Id = 12, Name = "Dip", Description = "pompki na poręczach" });
            this.tabExercise.Add(new Models.Exercise() { Id = 20, Name = "Pull up", Description = "Podciąganie na drążku nachwytem" });
            this.tabExercise.Add(new Models.Exercise() { Id = 21, Name = "Wiosłowanie", Description = "Podciąganie sztangi/hantli w opadzie" });
            this.tabExercise.Add(new Models.Exercise() { Id = 22, Name = "Martwy ciąg", Description = "" });
            this.tabExercise.Add(new Models.Exercise() { Id = 30, Name = "Unoszenie hantli bokiem", Description = "" });
            this.tabExercise.Add(new Models.Exercise() { Id = 31, Name = "Barbell press", Description = "wyciskanie sztangi sprzed glwy" });
            this.tabExercise.Add(new Models.Exercise() { Id = 40, Name = "Przysiady", Description = "Przysiady ze sztangą na barkach" });
            this.tabExercise.Add(new Models.Exercise() { Id = 50, Name = "Uginanie ramin", Description = "Uginanie ramion ze sztangą stojąc podchwytem" });
            this.tabExercise.Add(new Models.Exercise() { Id = 60, Name = "Prostowanie ramion", Description = "Prostowanie ramion na wyciągu stojąc" });

            this.SaveChanges();
            System.Console.WriteLine("Zapisano ćwiczenia");
            //Trenings
            this.tabTrening.Add(new Models.Trening() { Name = "Low impact upper body", Type = TreningType.Ogólnorozwojowy });
            this.tabTrening.Add(new Models.Trening() { Name = "Low impact lower body", Type = TreningType.Ogólnorozwojowy });
            this.tabTrening.Add(new Models.Trening() { Name = "Fat burning", Type = TreningType.Kardio });
            this.tabTrening.Add(new Models.Trening() { Name = "Chest Pump", Type = TreningType.Klatka });

            this.SaveChanges();
            System.Console.WriteLine("Zapisano treningi");
            //TreningExercises
            this.tabTreningExercise.Add(new Models.TreningExercise() { TreningID = 0, ExerciseID = 10, Series = 3, Reps = 10, Break = 60 });
            this.tabTreningExercise.Add(new Models.TreningExercise() { TreningID = 0, ExerciseID = 30, Series = 4, Reps = 12, Break = 60 });
            this.tabTreningExercise.Add(new Models.TreningExercise() { TreningID = 0, ExerciseID = 21, Series = 3, Reps = 10, Break = 60 });
            this.tabTreningExercise.Add(new Models.TreningExercise() { TreningID = 0, ExerciseID = 50, Series = 4, Reps = 12, Break = 60 });
            this.tabTreningExercise.Add(new Models.TreningExercise() { TreningID = 0, ExerciseID = 60, Series = 4, Reps = 12, Break = 60 });

            this.tabTreningExercise.Add(new Models.TreningExercise() { TreningID = 1, ExerciseID = 22, Series = 3, Reps = 6, Break = 45 });
            this.tabTreningExercise.Add(new Models.TreningExercise() { TreningID = 1, ExerciseID = 40, Series = 4, Reps = 8, Break = 60 });

            this.tabTreningExercise.Add(new Models.TreningExercise() { TreningID = 3, ExerciseID = 10, Series = 5, Reps = 5, Break = 60 });
            this.tabTreningExercise.Add(new Models.TreningExercise() { TreningID = 3, ExerciseID = 11, Series = 5, Reps = 5, Break = 60 });
            this.tabTreningExercise.Add(new Models.TreningExercise() { TreningID = 3, ExerciseID = 12, Series = 5, Reps = 10, Break = 60 });
            this.tabTreningExercise.Add(new Models.TreningExercise() { TreningID = 3, ExerciseID = 31, Series = 5, Reps = 5, Break = 60 });
            this.tabTreningExercise.Add(new Models.TreningExercise() { TreningID = 3, ExerciseID = 50, Series = 3, Reps = 12, Break = 60 });

            this.SaveChanges();
            System.Console.WriteLine("/przypisano ćwiczenia do treningów");
            //Archives
            this.tabArchive.Add(new Models.Archive() { UserID = 101, TreningID = 2, DateStart = new DateTime(2018, 11, 1), DateFinish = new DateTime(2018, 12, 12) });
            this.tabArchive.Add(new Models.Archive() { UserID = 101, TreningID = 1, DateStart = new DateTime(2018, 11, 1), DateFinish = new DateTime(2018, 12, 12) });
            this.tabArchive.Add(new Models.Archive() { UserID = 101, TreningID = 0, DateStart = new DateTime(2018, 11, 1), DateFinish = new DateTime(2018, 12, 12) });

            this.tabArchive.Add(new Models.Archive() { UserID = 104, TreningID = 0, DateStart = new DateTime(2018, 06, 13), DateFinish = new DateTime(2019, 01, 01) });

            this.tabArchive.Add(new Models.Archive() { UserID = 1, TreningID = 0, DateStart = new DateTime(2018, 01, 24), DateFinish = new DateTime(2018, 07, 10) });
            this.tabArchive.Add(new Models.Archive() { UserID = 1, TreningID = 3, DateStart = new DateTime(2018, 08, 1), DateFinish = new DateTime(2019, 1, 14) });

            this.SaveChanges();
            System.Console.WriteLine("Zapisano archiwa");
            //Dimensions
            this.tabDimensions.Add(new Models.Dimensions() { UserID = 1, Chest = 135, Arm = 52, Shoulder = 182, Waist = 100, Hip = 110, Thigh = 92, Calf = 50 });
            this.tabDimensions.Add(new Models.Dimensions() { UserID = 2, Chest = 90, Arm = 35, Shoulder = 120, Waist = 70, Hip = 80, Thigh = 60, Calf = 30 });
            this.tabDimensions.Add(new Models.Dimensions() { UserID = 103, Chest = 100, Arm = 38, Shoulder = 130, Waist = 70, Hip = 80, Thigh = 58, Calf = 30 });
            this.tabDimensions.Add(new Models.Dimensions() { UserID = 104, Chest = 101, Arm = 40, Shoulder = 129, Waist = 80, Hip = 94, Thigh = 62, Calf = 40 });

            this.SaveChanges();
            System.Console.WriteLine("Zapisano wymiary użytkowników");
            //UserPerformances
            this.tabUserPerformance.Add(new Models.UserPerformance() { UserID = 1, ExerciseID = 10, Max = 150, Reps = 3 });
            this.tabUserPerformance.Add(new Models.UserPerformance() { UserID = 1, ExerciseID = 22, Max = 250, Reps = 4 });
            this.tabUserPerformance.Add(new Models.UserPerformance() { UserID = 1, ExerciseID = 40, Max = 220, Reps = 3 });
            this.tabUserPerformance.Add(new Models.UserPerformance() { UserID = 1, ExerciseID = 20, Max = 60, Reps = 12 });

            this.tabUserPerformance.Add(new Models.UserPerformance() { UserID = 104, ExerciseID = 10, Max = 100, Reps = 2 });
            this.tabUserPerformance.Add(new Models.UserPerformance() { UserID = 104, ExerciseID = 20, Max = 130, Reps = 4 });
            this.tabUserPerformance.Add(new Models.UserPerformance() { UserID = 102, ExerciseID = 40, Max = 125, Reps = 5 });
            this.tabUserPerformance.Add(new Models.UserPerformance() { UserID = 102, ExerciseID = 50, Max = 60, Reps = 8 });

            this.SaveChanges();
            System.Console.WriteLine("Zapisano osiągnięcia");
            
            //History
            this.tabHistory.Add(new Models.History()
            {
                UserID = 1,
                dimensions = new Models.Dimensions() { UserID = 1, Chest = 132, Arm = 51, Shoulder = 178, Waist = 101, Hip = 110, Thigh = 89, Calf = 50 },
                performance = new Models.UserPerformance() { UserID = 1, ExerciseID = 10, Max = 145, Reps = 4 },
                weigth = 140,
                date = new DateTime(2018, 11, 1)
            });
            this.tabHistory.Add(new Models.History()
            {
                UserID = 1,
                dimensions = new Models.Dimensions() { UserID = 1, Chest = 132, Arm = 51, Shoulder = 178, Waist = 101, Hip = 110, Thigh = 89, Calf = 50 },
                performance = new Models.UserPerformance() { UserID = 1, ExerciseID = 10, Max = 150, Reps = 1 },
                weigth = 146,
                date = new DateTime(2018, 12, 1)
            });
            this.tabHistory.Add(new Models.History()
            {
                UserID = 1,
                dimensions = new Models.Dimensions() { UserID = 1, Chest = 134, Arm = 52, Shoulder = 180, Waist = 1100, Hip = 110, Thigh = 91, Calf = 50 },
                performance = new Models.UserPerformance() { UserID = 1, ExerciseID = 10, Max = 150, Reps = 1 },
                weigth = 142,
                date = new DateTime(2019, 1, 1)
            });
            
            try
            {
                this.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
            System.Console.WriteLine("Stworzono bazę");
            System.Console.ReadKey();

        }
    }
}
