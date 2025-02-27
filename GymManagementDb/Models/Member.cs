namespace GymManagementDb.Models
{
    public class Member
    {
        public int MemberID { get; set; }

        public string First_Name { get; set; }
        
        public string Last_Name { get; set; }

        public DateTime Join_Date { get; set; }

        public Location Location { get; set; }

        public MemberShipType MemberShipType { get; set; }

        public Contact Contact { get; set; }

        public string Phone_Number { get; set; }

        public ICollection<Workouts> Workouts { get; set; }

        public ICollection<Payments> Payments { get; set; }


    }
}
