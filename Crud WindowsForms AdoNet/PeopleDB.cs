using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Crud_WindowsForms_AdoNet
{
    public class PeopleDB
    {
        private string connectionString =
        
        "Data Source=localhost\\SQLEXPRESS;Initial Catalog=CrudWindowsForm;Integrated Security=True;TrustServerCertificate=True;";


        public bool Ok()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    return connection.State == System.Data.ConnectionState.Open;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
                return false;
            }
        }

        public List<People> Get()
        {
            List <People> people = new List<People>();

            string query = "select id,name,age from People";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        People oPeople = new People();
                        oPeople.Id = reader.GetInt32(0);
                        oPeople.Name = reader.GetString(1);
                        oPeople.Age = reader.GetInt32(2);
                        people.Add(oPeople);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch(Exception ex)
                {
                    throw new Exception("Error :" + ex.Message );
                }
            }

                return people;
        } 
    }

    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
