using AdaptiveTesting.Entity.Enums;

namespace Common
{
    public class QuestionData
    {
        public int IdQuestionData { get; set; }
        public int IdUser { get; set; }
        public int IdQuestion { get; set; }
        public int QuestionComplexity { get; set; }
        public int IsRightAnswer { get; set; }
        public int CorrectAnswer { get; set; }
        public int AnswerQuestion { get; set; }
        public int IdSubject { get; set; }
    }
}