
namespace TMS
{
    public class Training
    {
        private object[] LectureLesson;
        private int count;


        public Training()
        {
            LectureLesson = new object[10];
            count = 0;
        }


        public void Add(object subject)
        {
            if (count >= LectureLesson.Length)
            {
                Array.Resize(ref LectureLesson, LectureLesson.Length * 2);
            }
            LectureLesson[count] = subject;
            count++;
        }
        public bool IsPractical()
        {
            for (int i = 0; i < count; i++)
            {
                if (LectureLesson[i] is Lecture)
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
                if (LectureLesson[i] is Lecture)
                {
                    clonedTraining.Add(((Lecture)LectureLesson[i]).Clone());
                }
                else if (LectureLesson[i] is PracticalLesson)
                {
                    clonedTraining.Add(((PracticalLesson)LectureLesson[i]).Clone());
                }
            }
            return clonedTraining;

        }
       
    }
}

        

        

    

 

