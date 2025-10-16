using System;
using System.Collections.Generic;
using System.IO;

namespace QuizApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Quiz quiz = new Quiz();
            quiz.Start();
        }
    }

    public class Question
        public int CorrectAnswerIndex { get; private set; }

        public Question(string text, string[] options, int correctAnswerI
    {
        public string Text { get; private set; }
        public string[] Options { get; private set; }ndex)
        {
            Text = text;
            Options = options;
            CorrectAnswerIndex = correctAnswerIndex;
        }

        public bool IsCorrect(int userAnswer)
        {
            return userAnswer == CorrectAnswerIndex;
        }
    }

    public class Quiz
    {
        private List<Question> _questions;
        private int _score;

        public Quiz()
        {
            _questions = new List<Question>();
            _score = 0;
            InitializeQuestions();
        }

        private void InitializeQuestions()
        {
            // Sample questions
            _questions.Add(new Question(
                "What is the capital of France?",
                new[] { "1. London", "2. Paris", "3. Berlin", "4. Madrid" },
                1
            ));
            _questions.Add(new Question(
                "Which keyword is used to define a class in C#?",
                new[] { "1. struct", "2. class", "3. interface", "4. enum" },
                1
            ));
            _questions.Add(new Question(
                "What is 2 + 2?",
                new[] { "1. 3", "2. 4", "3. 5", "4. 6" },
                1
            ));
        }

        public void Start()
        {
            Console.WriteLine("=== Welcome to the Quiz ===");
            Console.WriteLine("Answer each question by entering the number of your choice.\n");

            for (int i = 0; i < _questions.Count; i++)
            {
                DisplayQuestion(i);
                int userAnswer = GetUserAnswer();

                if (_questions[i].IsCorrect(userAnswer))
                {
                    Console.WriteLine("Correct!");
                    _score++;
                }
                else
                {
                    Console.WriteLine($"Wrong! The correct answer was {_questions[i].CorrectAnswerIndex + 1}");
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }

            DisplayResults();
            SaveScore();
        }

        private void DisplayQuestion(int index)
        {
            Console.Clear();
            Console.WriteLine($"Question {index + 1}/{_questions.Count}");
            Console.WriteLine(_questions[index].Text);
            foreach (var option in _questions[index].Options)
            {
                Console.WriteLine(option);
            }
            Console.Write("Your answer: ");
        }

        private int GetUserAnswer()
        {
            int answer;
            while (!int.TryParse(Console.ReadLine(), out answer) || answer < 1 || answer > 4)
            {
                Console.Write("Please enter a valid number (1-4): ");
            }
            return answer - 1; // Adjust to 0-based index
        }

        private void DisplayResults()
        {
            Console.Clear();
            Console.WriteLine("=== Quiz Complete ===");
            Console.WriteLine($"Your score: {_score}/{_questions.Count}");
            Console.WriteLine($"Percentage: {(_score * 100) / _questions.Count}%");
            Console.WriteLine("Thanks for playing!");
        }

        private void SaveScore()
        {
            
            string filePath = "quiz_scores.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"Score: {_score}/{_questions.Count} - {DateTime.Now}");
            }
            Console.WriteLine("Your score has been saved.");
        }
    }
}
}