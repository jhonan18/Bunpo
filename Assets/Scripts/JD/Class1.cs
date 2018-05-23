using System;
using System.Data.SqlClient;
using System.Text;
using System.Data.Sql;

class CLass1
{

    static void Main(string[] args)
    {
        string sql;
        try
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "Bumpo2018.database.windows.net";
            builder.UserID = "BunpoAdmin2018";
            builder.Password = "Bumpo@2018";
            builder.InitialCatalog = "Bumpo2018";
            sql = "insert into School ([Name]) values(@Name)";
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@Name", "agustiniano norte");
                cmd.ExecuteNonQuery();

                //  cmd.Parameters.AddWithValue("@first", textbox2.text);
                // cmd.Parameters.AddWithValue("@last", textbox3.text);
                //  cmd.ExecuteNonQuery();
                // Console.WriteLine("Row inserted !! ");


            }
        }
        catch (SqlException e)
        {
            Console.WriteLine(e.ToString());
        }
        Console.ReadLine();
    }
}


