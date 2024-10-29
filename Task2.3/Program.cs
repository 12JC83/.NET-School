
using System;
using TMS;

class Program {
    static void Main(string[] args) { 
    
        Training training = new Training();

        training.Add(new Lecture("Lecture NR.1", "Concept of C#"));
        training.Add(new PracticalLesson("Practical Exercise 1", "https://example.com/task1", "https://example.com/solution1"));

        Console.WriteLine($"Is Practical only: {training.IsPractical()} ");

    }

}

