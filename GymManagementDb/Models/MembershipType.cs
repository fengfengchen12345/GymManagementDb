namespace GymManagementDb.Models
{
    public class MembershipType
    {
        public int MembershipTypeID { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public decimal Duration { get; set; }

        public ICollection<Member> Members { get; set; }
    }
}
