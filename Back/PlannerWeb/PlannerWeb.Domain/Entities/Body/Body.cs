namespace PlannerWeb.Domain.Entities.Body
{
    public class Body : BaseEntity
    {
        public Body(Measures measures, double waterLitersPerDay, string food, int frequencyOfFood, string exercises, int frequencyOfExercises, string massage, int frequencyOfMassage, string beautyRitual, int frequencyOfBeautyRitual)
        {
            Measures = measures;
            WaterLitersPerDay = waterLitersPerDay;
            Food = food;
            FrequencyOfFood = frequencyOfFood;
            Exercises = exercises;
            FrequencyOfExercises = frequencyOfExercises;
            Massage = massage;
            FrequencyOfMassage = frequencyOfMassage;
            BeautyRitual = beautyRitual;
            FrequencyOfBeautyRitual = frequencyOfBeautyRitual;
        }
        
        public Measures Measures { get; private set; }
        public double WaterLitersPerDay { get; private set; }
        public string Food { get; private set; }
        //TODO: Ver a possibilidade de levar para um enum
        public int FrequencyOfFood { get; private set; }
        public string Exercises { get; private set; }
        public int FrequencyOfExercises { get; private set; }
        public string Massage { get; private set; }
        public int FrequencyOfMassage { get; private set; }
        public string BeautyRitual { get; private set; }
        public int FrequencyOfBeautyRitual { get; private set; }

    }
}