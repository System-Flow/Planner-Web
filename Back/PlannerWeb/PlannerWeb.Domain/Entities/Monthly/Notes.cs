namespace PlannerWeb.Domain.Entities.Monthly
{
    public class Notes : BaseEntity
    {
        public Notes(string text, bool done)
        {
            Text = text;
            Done = done;
        }

        public string Text { get; private set; }
        public bool Done { get; private set; }

        public void MarkAsDone() => Done = true;
        public void MarkAsUnDone() => Done = false;
        public void ChangeText(string newText) => Text = newText; 

    }
}