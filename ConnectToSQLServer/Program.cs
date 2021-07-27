using System;
using System.Data;
using System.Data.SqlClient;

namespace ConnectToSQLServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Connect to SQL Server-------------

            //The SqlConnection Object is used to handle the part of physical communication
            //between the C# application and the SQL Server Database.

            Console.WriteLine("Getting Connection ...");

            //Connection string in DB properties
            var connection = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Fundamentals; Integrated Security = True; 
            Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            //Create an instance of SQL Connection and pass a connection string
            //Install SQL package
            //The SqlConnection Object is used to handle the part of physical communication
            //between the C# application and the SQL Server Database.
            SqlConnection conn = new SqlConnection(connection);
            
            //Open connection
            try
            {
                Console.WriteLine("Openning Connection ...");

                //open connection
                conn.Open();

                Console.WriteLine("Connection successful!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            //When the connection is established, SQL Commands will execute with the help of the Connection Object and
            //retrieve or manipulate the data in the database. Once the Database activities is over ,
            //Connection should be closed and release the Data Source resources

            //Create an SQL table in Microsoft 

            //Parameterized Queries

            //Insert Data
            //Create SQL command to connection
            SqlCommand cmd = new SqlCommand(null, conn);

            //Write command text query 
            cmd.CommandText = "INSERT INTO dbo.SqlTable2(Name) VALUES (@Name)";

            //Create variable name @Name with text length of 50
            //Fill value of that parameter 
            var NameParam = new SqlParameter("@Name", SqlDbType.Text, 50);
            NameParam.Value = "Fifth";

            cmd.Parameters.Add(NameParam);

            cmd.Prepare();
            cmd.ExecuteNonQuery();

            //Update Table
            //cmd = new SqlCommand("UPDATE dbo.SqlTable2 SET Name = @Name WHERE Id = @id",conn);

            //var idParameter = new SqlParameter("@id", SqlDbType.Int, 1);
            //idParameter.Value = 3;

            //var NameParam2 = new SqlParameter("@Name", SqlDbType.Text, 50);
            //NameParam2.Value = "Changed";

            //cmd.Parameters.Add(idParameter);
            //cmd.Parameters.Add(NameParam2);

            //cmd.Prepare();
            //cmd.ExecuteNonQuery();


            //Delete Table
            //cmd = new SqlCommand("DELETE from dbo.SqlTable2 WHERE Id = @id", conn);

            //var idParameter2 = new SqlParameter("@id", SqlDbType.Int, 1);
            //idParameter2.Value = 3;

            //cmd.Parameters.Add(idParameter2);


            //cmd.Prepare();
            //cmd.ExecuteNonQuery();

            //Read All records

            cmd = new SqlCommand("SELECT Name, Id FROM dbo.SqlTable2; ", conn);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow((IDataRecord)reader);
            }
            reader.Close();

            ////Read single record
            //cmd = new SqlCommand("SELECT Name, Id FROM dbo.SqlTable2 WHERE Id = 2; ", conn);

            //SqlDataReader reader2 = cmd.ExecuteReader();

            //reader2.Read();
            
            //    ReadSingleRow((IDataRecord)reader2);
            
            //reader2.Close();

            
        }
        private static void ReadSingleRow(IDataRecord record)
        {
            Console.WriteLine(String.Format("{0}, {1}", record[0], record[1]));
        }
    }
}
