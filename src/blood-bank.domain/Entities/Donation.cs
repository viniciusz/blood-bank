namespace blood_bank.domain.Entities
{
    public class Donation : BaseEntity
    {
        public int DonatorId { get; private set; }
        public DateTime DonationDate { get; private set; }
        public double Quantity { get; private set; }
        public Donator Donator { get; private set; }
    }
}