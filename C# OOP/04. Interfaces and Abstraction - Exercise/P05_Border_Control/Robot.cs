namespace P05_Border_Control
{
    public class Robot : IIdentifiable
    {
        private string model;
        private string id;

        public Robot(string model, string id)
        {
            this.model = model;
            this.id = id;
        }

        public string Id
        {
            get => this.id;
        }
    }
}
