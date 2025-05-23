namespace blood_bank.domain.Entities
{
    public class Donator : BaseEntity
    {
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public DateOnly BirthDay { get; private set; }
        public string Gender { get; private set; }
        public double Weight { get; private set; }
        //todo: can be enum?
        public string BloodType { get; private set; }
        public string RhFactor { get; private set; }
        public IEnumerable<Donation> Donations { get; private set; }
        public Address Address { get; private set; }


    }
    
}