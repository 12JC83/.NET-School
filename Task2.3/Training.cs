
namespace TMS
{
    public class Training
    {
        private Lesson[] LectureLesson;
        private int count;


        public Training()
        {
            LectureLesson = new Lesson[10];
            count = 0;
        }


        public void Add(Lesson lesson)
        {
            if (count >= LectureLesson.Length)
            {
                Array.Resize(ref LectureLesson, LectureLesson.Length * 2);
            }
            LectureLesson[count] = lesson;
            count++;
        }
        public bool IsPractical()
        {
            for (int i = 0; i < count; i++)
            {
                if (LectureLesson[i] is not PracticalLesson)
                {
                    return false;
                }
            }
            return true;
        }
        public Training Clone()
        {
            Training clonedTraining = new Training();
            for (int i = 0; i < count; i++)
            {
                clonedTraining.Add(LectureLesson[i].Clone());
            }
            return clonedTraining;

        }
       
    }
}

        

        

    

 

