using System;
using GymManagementDb.Models;

using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.FileSystemGlobbing;
using GymManagementDb.Migrations;

namespace GymManagementDb.Data
{
    public static class DummyData
    {
        public static void AddData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var GymManagementDb = serviceScope.ServiceProvider.GetRequiredService<GymManagementDbContext>();


                if (GymManagementDb.Member.Any())
                {

                    return;
                }
                if (GymManagementDb.Trainers.Any())
                {

                    return;
                }

                if (GymManagementDb.Workouts.Any())
                {

                    return;
                }
                if (GymManagementDb.MembershipType.Any())
                {
                    return;
                }
                if (GymManagementDb.TrainerSpecialty.Any())
                {

                    return;
                }



                var members = new Member[]
                {
             new Member { First_Name = "Bob", Last_Name = "Brown", Join_Date = DateTime.Parse("2003-09-01"), Email = "bob.brown@example.com", Phone_Number = "0987654321", WorkoutID = 2 },
             new Member { First_Name = "Alice", Last_Name = "Green", Join_Date = DateTime.Parse("2003-09-01"), Email = "alice.green@example.com", Phone_Number = "1234567890", WorkoutID = 1 },
             new Member { First_Name = "Charlie", Last_Name = "Black", Join_Date = DateTime.Parse("2003-09-01"), Email = "charlie.black@example.com", Phone_Number = "1122334455", WorkoutID = 3 },
             new Member { First_Name = "David", Last_Name = "White", Join_Date = DateTime.Parse("2004-05-15"), Email = "david.white@example.com", Phone_Number = "2233445566", WorkoutID = 2 },
             new Member { First_Name = "Emma", Last_Name = "Brown", Join_Date = DateTime.Parse("2005-11-20"), Email = "emma.brown@example.com", Phone_Number = "3344556677", WorkoutID = 1 },
             new Member { First_Name = "Frank", Last_Name = "Wilson", Join_Date = DateTime.Parse("2006-07-10"), Email = "frank.wilson@example.com", Phone_Number = "4455667788", WorkoutID = 3 },
             new Member { First_Name = "Grace", Last_Name = "Davis", Join_Date = DateTime.Parse("2007-02-18"), Email = "grace.davis@example.com", Phone_Number = "5566778899", WorkoutID = 2 },
             new Member { First_Name = "Henry", Last_Name = "Miller", Join_Date = DateTime.Parse("2008-12-05"), Email = "henry.miller@example.com", Phone_Number = "6677889900", WorkoutID = 1 },
             new Member { First_Name = "Isla", Last_Name = "Taylor", Join_Date = DateTime.Parse("2009-03-30"), Email = "isla.taylor@example.com", Phone_Number = "7788990011", WorkoutID = 3 },
             new Member { First_Name = "Jack", Last_Name = "Anderson", Join_Date = DateTime.Parse("2010-08-12"), Email = "jack.anderson@example.com", Phone_Number = "8899001122", WorkoutID = 2 },
             new Member { First_Name = "Katherine", Last_Name = "Thomas", Join_Date = DateTime.Parse("2011-04-23"), Email = "katherine.thomas@example.com", Phone_Number = "9900112233", WorkoutID = 1 },
             new Member { First_Name = "Liam", Last_Name = "Moore", Join_Date = DateTime.Parse("2012-10-17"), Email = "liam.moore@example.com", Phone_Number = "1011121314", WorkoutID = 3 },
             new Member { First_Name = "Mia", Last_Name = "Jackson", Join_Date = DateTime.Parse("2013-06-02"), Email = "mia.jackson@example.com", Phone_Number = "2122232435", WorkoutID = 2 },
             new Member { First_Name = "Nathan", Last_Name = "Martin", Join_Date = DateTime.Parse("2014-01-09"), Email = "nathan.martin@example.com", Phone_Number = "3233344456", WorkoutID = 1 },
             new Member { First_Name = "Olivia", Last_Name = "Lee", Join_Date = DateTime.Parse("2015-07-27"), Email = "olivia.lee@example.com", Phone_Number = "4344455567", WorkoutID = 3 },
             new Member { First_Name = "Paul", Last_Name = "Gonzalez", Join_Date = DateTime.Parse("2016-09-12"), Email = "paul.gonzalez@example.com", Phone_Number = "5455566678", WorkoutID = 2 },
             new Member { First_Name = "Quinn", Last_Name = "Perez", Join_Date = DateTime.Parse("2017-11-28"), Email = "quinn.perez@example.com", Phone_Number = "6566677789", WorkoutID = 1 },
             new Member { First_Name = "Rachel", Last_Name = "Roberts", Join_Date = DateTime.Parse("2018-03-16"), Email = "rachel.roberts@example.com", Phone_Number = "7677788890", WorkoutID = 3 },
             new Member { First_Name = "Samuel", Last_Name = "Harris", Join_Date = DateTime.Parse("2019-05-04"), Email = "samuel.harris@example.com", Phone_Number = "8788899901", WorkoutID = 2 },
             new Member { First_Name = "Tina", Last_Name = "Clark", Join_Date = DateTime.Parse("2020-07-21"), Email = "tina.clark@example.com", Phone_Number = "9899001122", WorkoutID = 1 }
                };

                var Trainers = new Trainers[]
                {
                new Trainers { Name = "John Doe", YearsOfExperience = 5, TrainerID=1},
                new Trainers { Name = "Jane Smith", YearsOfExperience = 6, TrainerID=2 },
                new Trainers { Name = "Chris Johnson", YearsOfExperience = 7, TrainerID=4 },
                new Trainers { Name = "Emily Davis", YearsOfExperience = 8, TrainerID=5},
                new Trainers { Name = "Michael Brown", YearsOfExperience = 9, TrainerID=6 },
                new Trainers { Name = "Sara Wilson", YearsOfExperience = 10, TrainerID=7 },
                new Trainers { Name = "David Lee", YearsOfExperience = 11, TrainerID=8},
                new Trainers { Name = "Rachel Green", YearsOfExperience = 12, TrainerID=9 },
                new Trainers { Name = "Daniel Harris", YearsOfExperience = 13, TrainerID=10 },
                new Trainers { Name = "Olivia Martinez", YearsOfExperience = 14, TrainerID=11 },
                new Trainers { Name = "James Clark", YearsOfExperience = 15, TrainerID=12 },
                new Trainers { Name = "Sophia Lopez", YearsOfExperience = 16, TrainerID=13},
                new Trainers { Name = "Ethan Walker", YearsOfExperience = 17, TrainerID=14 },
                new Trainers { Name = "Megan Lewis", YearsOfExperience = 18, TrainerID=15 },
                new Trainers { Name = "Liam Scott", YearsOfExperience = 19, TrainerID=16 },
                new Trainers { Name = "Ava Young", YearsOfExperience = 20, TrainerID=17 },
                new Trainers { Name = "Lucas Adams", YearsOfExperience = 21, TrainerID=18 },
                new Trainers { Name = "Charlotte Baker", YearsOfExperience = 22, TrainerID=19 },
                new Trainers { Name = "Jack Evans", YearsOfExperience = 23, TrainerID=20 }
                };



                var MembershipTypes = new MembershipType[]
                {
                new MembershipType { MembershipTypeID = 1, Name = "Basic", Price = 29.99m, Duration = 1 },
                new MembershipType { MembershipTypeID = 2, Name = "Premium", Price = 49.99m, Duration = 1 },
                new MembershipType { MembershipTypeID = 3, Name = "VIP", Price = 99.99m, Duration = 1 },
                new MembershipType { MembershipTypeID = 4, Name = "Basic", Price = 149.99m, Duration = 6 },
                new MembershipType { MembershipTypeID = 5, Name = "Premium", Price = 249.99m, Duration = 6 },
                new MembershipType { MembershipTypeID = 6, Name  = "VIP", Price = 499.99m, Duration = 6 },
                new MembershipType { MembershipTypeID = 7, Name  = "Basic", Price = 499.99m, Duration = 12 },
                new MembershipType { MembershipTypeID = 8, Name = "Premium", Price = 799.99m, Duration = 12 },
                new MembershipType { MembershipTypeID = 9, Name = "VIP", Price = 1499.99m, Duration = 12 }
                };


                var TrainerSpecialty = new TrainerSpecialty[]
                {
                new TrainerSpecialty { SpecialtyName = "Weight Training" },
                new TrainerSpecialty { SpecialtyName = "Cardio Fitness" },
                new TrainerSpecialty { SpecialtyName = "Yoga" },
                new TrainerSpecialty { SpecialtyName = "CrossFit" },
                new TrainerSpecialty { SpecialtyName = "Pilates" }
                };

                var Workout = new Workouts[]
                {
                new Workouts { Name = "Morning Cardio", Type = "Cardio", Duration = 60, TrainerID = 1 },
                new Workouts { Name = "Strength Training", Type = "Strength", Duration = 60, TrainerID = 2 },
                new Workouts { Name = "Yoga for Flexibility", Type = "Yoga", Duration = 60, TrainerID = 3 },
                new Workouts { Name = "CrossFit Bootcamp", Type = "CrossFit", Duration = 60, TrainerID = 4 },
                new Workouts { Name = "HIIT Workout", Type = "HIIT", Duration = 40, TrainerID = 5 },
                new Workouts { Name = "Pilates for Core", Type = "Pilates", Duration = 60, TrainerID = 6 },
                new Workouts { Name = "Zumba Dance", Type = "Cardio", Duration = 60, TrainerID = 7 },
                new Workouts { Name = "Strength & Conditioning", Type = "Strength", Duration = 75, TrainerID = 8 },
                new Workouts { Name = "Cycling for Endurance", Type = "Cardio", Duration = 90, TrainerID =9 },
                new Workouts { Name = "Boxing Training", Type = "Strength", Duration = 60, TrainerID = 10 }
                };



                GymManagementDb.Member.AddRange(members);
                GymManagementDb.SaveChanges();
                GymManagementDb.MembershipType.AddRange(MembershipTypes);
                GymManagementDb.SaveChanges();

                GymManagementDb.Trainers.AddRange(Trainers);
                GymManagementDb.SaveChanges();
                GymManagementDb.TrainerSpecialty.AddRange(TrainerSpecialty);
                GymManagementDb.SaveChanges();
                GymManagementDb.Workouts.AddRange(Workout);
                GymManagementDb.SaveChanges();


            }
        }
    }
}