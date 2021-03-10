using System;

namespace CompositionAndAggrigationDemoApp
{
    class Composition
    {
        static void Main(string[] args)
        {
            Question question = new Question("What is your favorite color", "Red","Green");
            PrintInfo(question);
        }
        public static void PrintInfo(Question question)
        {
            Console.WriteLine("Question : " + question.GetQuestion);
            Console.WriteLine("1) " + question.GetFirstOption.GetOption);
            Console.WriteLine("2) " + question.GetSecondOption.GetOption);
        }
    }
    class Options
    {
        private string opt;
        public Options(string opt)
        {
            this.opt = opt;
        }

        public string GetOption
        {
            get { return opt; }
        }
    }

    class Question
    {
        private string question;
        private Options o1, o2;

        public Question(string question, string op1,string op2)
        {
            this.question = question;
            o1 = new Options(op1);
            o2 = new Options(op2);
        }
        public string GetQuestion
        {
            get { return question; }
        }
        public Options GetFirstOption
        {
            get { return o1; }
        }
        public Options GetSecondOption
        {
            get { return o2; }
        }

    }
}
