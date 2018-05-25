using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sgu.StudentTesting.DAL.Contracts;
using System.Configuration;
using System.Data.SqlClient;
using Common;
using System.Data;
using AdaptiveTesting.Entity.Enums;

namespace Sgu.StudentTesting.DAL
{
    class QuestionDataDao : IQuestionDataDao
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["StudentTestingDB"].ConnectionString;

        SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public void InsertQuestionData(QuestionData questionData)
        {
            string sqlExpression = "sp_InsertQuestionData";
            int complexity = 0;
            if (questionData.QuestionComplexity == 0)
            {
                complexity = 0;
            }
            else if (questionData.QuestionComplexity == 1)
            {
                complexity = 1;
            }
            else
            {
                complexity = 2;
            }
            
            using (var connection = GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter idUser = new SqlParameter
                {
                    ParameterName = "@IdUser",
                    Value = questionData.IdUser
                };
                command.Parameters.Add(idUser);

                SqlParameter idQuestion = new SqlParameter
                {
                    ParameterName = "@IdQuestion",
                    Value = questionData.IdQuestion
                };
                command.Parameters.Add(idQuestion);

                SqlParameter isRightAnswer = new SqlParameter
                {
                    ParameterName = "@IsRightAnswer",
                    Value = questionData.IsRightAnswer
                };
                command.Parameters.Add(isRightAnswer);

                SqlParameter answerQuestion = new SqlParameter
                {
                    ParameterName = "@AnswerQuestion",
                    Value = questionData.AnswerQuestion
                };
                command.Parameters.Add(answerQuestion);

                SqlParameter idSubject = new SqlParameter
                {
                    ParameterName = "@IdSubject",
                    Value = questionData.IdSubject
                };
                command.Parameters.Add(idSubject);

                SqlParameter questionComplexity = new SqlParameter
                {
                    ParameterName = "@QuestionComplexity",
                    Value = complexity
                };
                command.Parameters.Add(questionComplexity);

                SqlParameter correctAnswer = new SqlParameter
                {
                    ParameterName = "@CorrectAnswer",
                    Value = questionData.CorrectAnswer
                };
                command.Parameters.Add(correctAnswer);

                command.ExecuteNonQuery();
            }
        }
        public IEnumerable<int> GetListIsRightAnswer()
        {
            string sqlExpression = "sp_GetListIsRightAnswer";
            using (var connection = GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = CommandType.StoredProcedure;                
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    yield return new int();
                }
            }
        }

        public IEnumerable<QuestionData> GetQuestionData()
        {
            using (SqlConnection connection = GetConnection())
            {
                string sqlExpression = "sp_GetQuestionData";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    yield return new QuestionData()
                    {
                        IdQuestionData = (int)reader["IdQuestionData"],
                        IdQuestion = (int)reader["IdQuestion"],
                        QuestionComplexity = (int)reader["QuestionComplexity"],
                        IsRightAnswer = (int)reader["IsRightAnswer"],
                        CorrectAnswer = (int)reader["CorrectAnswer"],
                        AnswerQuestion = (int)reader["AnswerQuestion"],
                        IdSubject = (int)reader["IdSubject"],
                        IdUser = (int)reader["IdUser"],
                    };
                }
            }
        }
    }
}
