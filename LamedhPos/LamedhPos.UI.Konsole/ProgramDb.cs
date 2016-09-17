using LamedhPos.Domain;
using LamedhPos.Infras.Data.SqlRepositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamedhPos.UI.Konsole
{
    class ProgramDatabase
    {
        static void MainLogin(string[] args)
        {
            Console.Write("User: ");
            string name = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            var connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=LamedhPos;Integrated Security=SSPI");
            var command = connection.CreateCommand();
            
            //command.CommandText = "insert into Employees (Code, Name, Birthdate) values ('E10', 'David Buchanan', '10 Jan 1950')";
            //command.CommandText = "select * from Employees";
            //command.CommandText = string.Format("select Code, Name from Employees where Code = '{0}' and Name = '{1}'", name, password);
            command.CommandText = "select Code, Name from Employees where Code = @code and Name = @name";

            connection.Open();
            //command.ExecuteNonQuery();
            
            //var reader = command.ExecuteReader();
            //while (reader.Read())
            //    Console.WriteLine(reader["Name"]);

            command.Parameters.AddWithValue("Code", name);
            command.Parameters.AddWithValue("Name", password);

            var reader = command.ExecuteReader();
            if (reader.HasRows)
                Console.WriteLine("Login succeed");
            else
                Console.WriteLine("Login failed");
            
            connection.Close();
        }

        static void MainRepo(string[] args)
        {
            using (var empRepo = new EmployeeSqlRepository())
            {
                //Employee employee = GetEmployeeByCode("E01");
                var employee = empRepo.GetByCode("E01");
                Console.WriteLine("{0} {1}", employee.Name, employee.Birthdate);

                //var emps = GetAllEmployee();
                var emps = empRepo.GetAll();
                foreach (var e in emps)
                    Console.WriteLine(e.Name);
            }
        }

        static IEnumerable<Employee> GetAllEmployee()
        {
            var connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=LamedhPos;Integrated Security=SSPI");
            var command = connection.CreateCommand();
            command.CommandText = "select * from Employees";
            connection.Open();
            var reader = command.ExecuteReader();

            //var result = new List<Employee>();
            while (reader.Read())
            {
                var newEmployee = new Employee
                {
                    Id = (int)reader["Id"],
                    Code = (string)reader["Code"],
                    Name = (string)reader["Name"],
                    Birthdate = (DateTime)reader["Birthdate"],
                };
                //result.Add(newEmployee);
                yield return newEmployee;
            }
            //return result;
        }

        static Employee GetEmployeeByCode(string code)
        {
            var connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=LamedhPos;Integrated Security=SSPI");
            var command = connection.CreateCommand();
            command.CommandText = "select * from Employees where Code = @code";
            command.Parameters.AddWithValue("code", code);
            connection.Open();
            var reader = command.ExecuteReader();
            reader.Read();
            return new Employee { Id = reader.GetInt32(0), Code = reader.GetString(1), Name = reader.GetString(2), Birthdate = reader.GetDateTime(3), };
        }
    }
}
