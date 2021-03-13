using System;
using System.Data.Odbc;
 
namespace ODBC
{
    public class DataDirectODBCConnect
    {
        public void Main()
        {
            using (OdbcConnection connection = new OdbcConnection("DSN=SycamoreWestDS"))
            {
                string sqlQuery = "SELECT * FROM emails limit 100";
                OdbcCommand command = new OdbcCommand(sqlQuery, connection);
                connection.Open();
                OdbcDataReader reader = command.ExecuteReader();
 
                //Print Column Names
                for (int i=0; i< reader.FieldCount; i++)
                {
                    Console.Write(reader.GetName(i) + "\t");
                }
 
                Console.Write("\n");
 
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}\t{2}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                    }
                }
 
                reader.Close();
                command.Dispose();
            }
 
        }
    }
}