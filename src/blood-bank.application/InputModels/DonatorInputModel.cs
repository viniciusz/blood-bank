namespace blood_bank.application.InputModels
{
    public class DonatorInputModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateOnly BirthDay { get; set; }
        public string Gender { get; set; }
        public double Weight { get; set; }
        public string BloodType { get; set; }
        public string RhFactor { get; set; }

        public AddressInputModel Address { get; set; }
        

    }


}