namespace HospitalManagement.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string HospitalId { get; set; }
        public HospitalInfo HospitalInfo { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}