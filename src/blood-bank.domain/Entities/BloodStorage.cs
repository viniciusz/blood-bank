namespace blood_bank.domain.Entities
{
    public class BloodStorage : BaseEntity
    {
        public string BloodType { get; private set; }
        public string RhFactor { get; private set; }
        public double Quantity { get; set; }
    }
}