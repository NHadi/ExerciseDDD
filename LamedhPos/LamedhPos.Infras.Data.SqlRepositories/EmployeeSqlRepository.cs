using LamedhPos.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamedhPos.Infras.Data.SqlRepositories
{
    public class EmployeeSqlRepository : IDisposable, IEmployeeRepository
    {
        private SqlConnection connection;

        public EmployeeSqlRepository()
        {
            connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=LamedhPos;User Id=sa;Password=f4aith..;Integrated Security=SSPI");
            connection.Open();
        }

        public Employee GetByCode(string code)
        {
            var command = connection.CreateCommand();
            command.CommandText = "select * from Employees where Code = @code";
            command.Parameters.AddWithValue("code", code);
            using (command)
            using (var reader = command.ExecuteReader())
            {
                reader.Read();
                return new Employee { Id = reader.GetInt32(0), Code = reader.GetString(1), Name = reader.GetString(2), Birthdate = reader.GetDateTime(3), };
            }
        }

        public IEnumerable<Employee> GetAll()
        {
            var command = connection.CreateCommand();
            command.CommandText = "select * from Employees";
            using (command)
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var newEmployee = new Employee
                    {
                        Id = (int)reader["Id"],
                        Code = (string)reader["Code"],
                        Name = (string)reader["Name"],
                        Birthdate = (DateTime)reader["Birthdate"],
                    };
                    yield return newEmployee;
                }
            }
        }

        public IEnumerable<Employee> Search(string search)
        {
            throw new NotImplementedException();
        }

        public int GetCount()
        {
            var command = connection.CreateCommand();
            command.CommandText = "select count(*) from Employees";
            using (command)
                return (int)command.ExecuteScalar();
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Employee entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            connection.Close();
        }
    }
}
