namespace PlannerWeb.Domain.Entities.Monthly
{
    public class Monthly : BaseEntity
    {
        public Monthly(MonthlyHabitControl monthlyHabitControl,
                       StrategicMapsMonth strategicMapsMonth,
                       AmazingWeek amazingWeek,
                       Finances finances,
                       CalibrationSheet calibrationSheet,
                       PersonalChecklist personalChecklist)
        {
            MonthlyHabitControl = monthlyHabitControl;
            StrategicMapsMonth = strategicMapsMonth;
            AmazingWeek = amazingWeek;
            Finances = finances;
            CalibrationSheet = calibrationSheet;
            PersonalChecklist = personalChecklist;
        }

        public MonthlyHabitControl MonthlyHabitControl { get; private set; }
        public StrategicMapsMonth StrategicMapsMonth { get; private set; }
        public AmazingWeek AmazingWeek { get; private set; }
        public Finances Finances { get; private set; }
        public CalibrationSheet CalibrationSheet { get; private set; }
        public PersonalChecklist PersonalChecklist { get; private set; }
    }
}