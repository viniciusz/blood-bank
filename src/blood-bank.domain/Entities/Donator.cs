using blood_bank.domain.Enums;

namespace blood_bank.domain.Entities
{
    public class Donator : BaseEntity
    {
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public DateOnly BirthDay { get; private set; }
        public string Gender { get; private set; }
        public double Weight { get; private set; }
        public BloodType BloodType { get; private set; }
        public RhFactor RhFactor { get; private set; }
        public IEnumerable<Donation> Donations { get; private set; }
        public int AddressId { get; private set; }
        public Address Address { get; private set; }
    }
    
}