﻿
namespace TMS
{
    public class Lecture: Lesson
    {
        public string Topic { get; set; }

        public Lecture(string description, string topic) :base(description)
        {
            Topic = topic;
        }
        public override Lesson Clone()
        {
            return new Lecture(Description,Topic);
        }
    }
}

