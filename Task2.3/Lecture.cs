
namespace TMS
{
    public class Lecture
    {
        public string Description { get; set; }
        public string Topic { get; set; }

        public Lecture(string description, string topic)
        {
            Description = description;
            Topic = topic;
        }
        public Lecture Clone()
        {
            return new Lecture(Description,Topic);
        }
    }
}

