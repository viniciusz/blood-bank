namespace blood_bank.domain.Entities
{
    public class Address : BaseEntity
    {
        public string Place { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public Donator Donator { get; set; }

    }
}