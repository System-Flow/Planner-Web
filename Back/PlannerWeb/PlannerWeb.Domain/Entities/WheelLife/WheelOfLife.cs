namespace PlannerWeb.Domain.Entities.WheelLife
{
    public class WheelOfLife : BaseEntity
    {
        public WheelOfLife(int spiritualPurpose, int moneyAndFinance, int careerAndMission, int healthAndMood, int environmentAndGroups, int contributionAndDonation, int familyAndFriends, int lovingConjugal, int intellectualRational)
        {
            SpiritualPurpose = spiritualPurpose;
            MoneyAndFinance = moneyAndFinance;
            CareerAndMission = careerAndMission;
            HealthAndMood = healthAndMood;
            EnvironmentAndGroups = environmentAndGroups;
            ContributionAndDonation = contributionAndDonation;
            FamilyAndFriends = familyAndFriends;
            LovingConjugal = lovingConjugal;
            IntellectualRational = intellectualRational;
        }

        // AS VARIAVES DESSA CLASSE VARIAM DE VALORES DE 1-10
        public int SpiritualPurpose { get; private set; }
        public int MoneyAndFinance { get; private set; }
        public int CareerAndMission { get; private set; }
        public int HealthAndMood { get; private set; }
        public int EnvironmentAndGroups { get; private set; }
        public int ContributionAndDonation { get; private set; }
        public int FamilyAndFriends { get; private set; }
        public int LovingConjugal { get; private set; }
        public int IntellectualRational { get; private set; }

    }
}