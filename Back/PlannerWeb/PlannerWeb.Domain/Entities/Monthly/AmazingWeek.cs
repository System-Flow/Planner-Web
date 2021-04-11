namespace PlannerWeb.Domain.Entities.Monthly
{
    public class AmazingWeek : BaseEntity
    {
        public AmazingWeek(Week myWeek, PostIt myPostIt)
        {
            MyWeek = myWeek;
            MyPostIt = myPostIt;
        }

        public Week MyWeek { get; private set; }
        public PostIt MyPostIt { get; private set; }
    }
}