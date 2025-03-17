using System;
using GymManagementDb.Models;

using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace GymManagementDb.Data
{
    public static class DbInitializer
    {
        public static void Initialize(GymManagementDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Member.Any() || context.Trainers.Any() || context.Workouts.Any() || context.MembershipType.Any() || context.TrainerSpecialty.Any())
            {
                return;   // DB has been seeded
            }
            var members = new Member[]
            {
             new Member { First_Name = "Bob", Last_Name = "Brown", Join_Date = DateTime.Parse("2003-09-01"), MemberShipType = "Premium", Email = "bob.brown@example.com", Phone_Number = "0987654321", WorkoutID = 2 },
             new Member { First_Name = "Alice", Last_Name = "Green", Join_Date = DateTime.Parse("2003-09-01"), MemberShipType = "Basic", Email = "alice.green@example.com", Phone_Number = "1234567890", WorkoutID = 1 },
             new Member { First_Name = "Charlie", Last_Name = "Black", Join_Date = DateTime.Parse("2003-09-01"), MemberShipType = "VIP", Email = "charlie.black@example.com", Phone_Number = "1122334455", WorkoutID = 3 },
             new Member { First_Name = "David", Last_Name = "White", Join_Date = DateTime.Parse("2004-05-15"), MemberShipType = "Premium", Email = "david.white@example.com", Phone_Number = "2233445566", WorkoutID = 2 },
             new Member { First_Name = "Emma", Last_Name = "Brown", Join_Date = DateTime.Parse("2005-11-20"), MemberShipType = "Basic", Email = "emma.brown@example.com", Phone_Number = "3344556677", WorkoutID = 1 },
             new Member { First_Name = "Frank", Last_Name = "Wilson", Join_Date = DateTime.Parse("2006-07-10"), MemberShipType = "VIP", Email = "frank.wilson@example.com", Phone_Number = "4455667788", WorkoutID = 3 },
             new Member { First_Name = "Grace", Last_Name = "Davis", Join_Date = DateTime.Parse("2007-02-18"), MemberShipType = "Premium", Email = "grace.davis@example.com", Phone_Number = "5566778899", WorkoutID = 2 },
             new Member { First_Name = "Henry", Last_Name = "Miller", Join_Date = DateTime.Parse("2008-12-05"), MemberShipType = "Basic", Email = "henry.miller@example.com", Phone_Number = "6677889900", WorkoutID = 1 },
             new Member { First_Name = "Isla", Last_Name = "Taylor", Join_Date = DateTime.Parse("2009-03-30"), MemberShipType = "VIP", Email = "isla.taylor@example.com", Phone_Number = "7788990011", WorkoutID = 3 },
             new Member { First_Name = "Jack", Last_Name = "Anderson", Join_Date = DateTime.Parse("2010-08-12"), MemberShipType = "Premium", Email = "jack.anderson@example.com", Phone_Number = "8899001122", WorkoutID = 2 },
             new Member { First_Name = "Katherine", Last_Name = "Thomas", Join_Date = DateTime.Parse("2011-04-23"), MemberShipType = "Basic", Email = "katherine.thomas@example.com", Phone_Number = "9900112233", WorkoutID = 1 },
             new Member { First_Name = "Liam", Last_Name = "Moore", Join_Date = DateTime.Parse("2012-10-17"), MemberShipType = "VIP", Email = "liam.moore@example.com", Phone_Number = "1011121314", WorkoutID = 3 },
             new Member { First_Name = "Mia", Last_Name = "Jackson", Join_Date = DateTime.Parse("2013-06-02"), MemberShipType = "Premium", Email = "mia.jackson@example.com", Phone_Number = "2122232435", WorkoutID = 2 },
             new Member { First_Name = "Nathan", Last_Name = "Martin", Join_Date = DateTime.Parse("2014-01-09"), MemberShipType = "Basic", Email = "nathan.martin@example.com", Phone_Number = "3233344456", WorkoutID = 1 },
             new Member { First_Name = "Olivia", Last_Name = "Lee", Join_Date = DateTime.Parse("2015-07-27"), MemberShipType = "VIP", Email = "olivia.lee@example.com", Phone_Number = "4344455567", WorkoutID = 3 },
             new Member { First_Name = "Paul", Last_Name = "Gonzalez", Join_Date = DateTime.Parse("2016-09-12"), MemberShipType = "Premium", Email = "paul.gonzalez@example.com", Phone_Number = "5455566678", WorkoutID = 2 },
             new Member { First_Name = "Quinn", Last_Name = "Perez", Join_Date = DateTime.Parse("2017-11-28"), MemberShipType = "Basic", Email = "quinn.perez@example.com", Phone_Number = "6566677789", WorkoutID = 1 },
             new Member { First_Name = "Rachel", Last_Name = "Roberts", Join_Date = DateTime.Parse("2018-03-16"), MemberShipType = "VIP", Email = "rachel.roberts@example.com", Phone_Number = "7677788890", WorkoutID = 3 },
             new Member { First_Name = "Samuel", Last_Name = "Harris", Join_Date = DateTime.Parse("2019-05-04"), MemberShipType = "Premium", Email = "samuel.harris@example.com", Phone_Number = "8788899901", WorkoutID = 2 },
             new Member { First_Name = "Tina", Last_Name = "Clark", Join_Date = DateTime.Parse("2020-07-21"), MemberShipType = "Basic", Email = "tina.clark@example.com", Phone_Number = "9899001122", WorkoutID = 1 }
            };

            foreach (Member m in members)
            {
                context.Members.Add(m);
            }
            context.SaveChanges();
            var Trainers = new Trainers[]
            {
            
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}