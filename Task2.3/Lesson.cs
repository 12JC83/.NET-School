

namespace TMS
{
    public abstract class Lesson

    {
        public string Description{  get; set; }

        public Lesson(string description) 
        {
        Description = description;

        }
        public abstract Lesson Clone();
        
    }
}
