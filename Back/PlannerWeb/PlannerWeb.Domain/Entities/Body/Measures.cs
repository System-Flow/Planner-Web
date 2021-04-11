namespace PlannerWeb.Domain.Entities.Body
{
    public class Measures : BaseEntity
    {
        public Measures(double bust, double arm, double waist, double hip, double thigh, double calf, double weigth, double height)
        {
            Bust = bust;
            Arm = arm;
            Waist = waist;
            Hip = hip;
            Thigh = thigh;
            Calf = calf;
            Weigth = weigth;
            Height = height;
        }

        public double Bust { get; private set; }
        public double Arm { get; private set; }
        public double Waist { get; private set; }
        public double Hip { get; private set; }
        public double Thigh { get; private set; }
        public double Calf { get; private set; }
        public double Weigth { get; private set; }
        public double Height { get; private set; }

        //IMC fazer pela interface
    }
}