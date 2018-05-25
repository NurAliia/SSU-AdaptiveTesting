using Common.Register;
using Sgu.StudentTesting.DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sgu.StudentTesting.DAL
{
    class RegisterDao : IRegisterDao
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["StudentTestingDB"].ConnectionString;

        SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public IEnumerable<City> GetCity()
        {
            string sqlExpression = "sp_City";
            using (var connectionString = GetConnection())
            {
                connectionString.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connectionString);
                command.CommandType = CommandType.StoredProcedure;
               
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    yield return new City()
                    {
                        IdCity = (int)reader["IdCity"],
                        NameCity = (string)reader["NameCity"]
                    };
                }
            }
        }
        public IEnumerable<University> GetUniversity()
        {
            string sqlExpression = "sp_UniversityInCity";
            using (var connectionString = GetConnection())
            {
                connectionString.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connectionString);
                command.CommandType = CommandType.StoredProcedure;

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    yield return new University()
                    {
                        IdCity = (int)reader["IdCity"],
                        IdUniversity = (int)reader["IdUniversity"],
                        NameUniversity = (string)reader["NameUniversity"]
                    };
                }
            }
        }
        public IEnumerable<Faculty> GetFaculty()
        {
            string sqlExpression = "sp_FacultyInUniversity";
            using (var connectionString = GetConnection())
            {
                connectionString.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connectionString);
                command.CommandType = CommandType.StoredProcedure;

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    yield return new Faculty()
                    {
                        IdUniversity = (int)reader["IdUniversity"],
                        IdFaculty = (int)reader["IdFaculty"],
                        NameFaculty = (string)reader["NameFaculty"]
                    };
                }
            }
        }
        public IEnumerable<Direction> GetDirection()
        {
            string sqlExpression = "sp_DirectionInFaculty";
            using (var connectionString = GetConnection())
            {
                connectionString.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connectionString);
                command.CommandType = CommandType.StoredProcedure;

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    yield return new Direction()
                    {
                        IdFaculty = (int)reader["IdFaculty"],
                        IdDirection = (int)reader["IdDirection"]
                    };
                }
            }
        }
    }
}
