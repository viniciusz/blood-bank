using blood_bank.domain.Enums;

namespace blood_bank.domain.ValueObjects
{
    public class Blood
    {
        public BloodType Type { get; private set; }
        public RhFactor RhFactor { get; private set; }
    }
}