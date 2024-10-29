
namespace TMS
{
    public class PracticalLesson
    {
        public string Description {  get; set; }
        public string LinkTCondition { get; set; }
        public string LinkTSolution { get; set; }
        public PracticalLesson(string description, string linkTCondition, string linkTSolution)
        {
            Description = description;
            LinkTCondition = linkTCondition;
            LinkTSolution = linkTSolution;
        }
        public PracticalLesson Clone()
        {
            return new PracticalLesson(Description,LinkTCondition, LinkTSolution);

        }
    }
}

