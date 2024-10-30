
namespace TMS
{
    public class PracticalLesson:Lesson
    {
       
        public string LinkTCondition { get; set; }
        public string LinkTSolution { get; set; }
        public PracticalLesson(string description, string linkTCondition, string linkTSolution):base(description)
        {
            LinkTCondition = linkTCondition;
            LinkTSolution = linkTSolution;
        }
        public override Lesson Clone()
        {
            return new PracticalLesson(Description,LinkTCondition, LinkTSolution);

        }
    }
}

