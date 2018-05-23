using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data.SqlClient;
using System;


public class PRUEBA : MonoBehaviour {

    // Use this for initialization
    void Start() {
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
                cmd.Parameters.AddWithValue("@Name", "bumpo12");
                cmd.ExecuteNonQuery();

                //  cmd.Parameters.AddWithValue("@first", textbox2.text);
                // cmd.Parameters.AddWithValue("@last", textbox3.text);
                //  cmd.ExecuteNonQuery();
                // Console.WriteLine("Row inserted !! ");

                connection.Close();
            }

			sql = "select * from School;";
			using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand(sql, connection);
				cmd.Parameters.AddWithValue("@Name", "bumpo12");

				using (SqlDataReader reader = cmd.ExecuteReader())
				{
                    if (reader.Read())
					{
						Debug.Log(String.Format("{0}",reader["Name"]));
					}
				}
				//  cmd.Parameters.AddWithValue("@first", textbox2.text);
				// cmd.Parameters.AddWithValue("@last", textbox3.text);
				//  cmd.ExecuteNonQuery();
				// Console.WriteLine("Row inserted !! ");

				connection.Close();
			}



        }
        catch (SqlException e)
        {
            Console.WriteLine(e.ToString());
        }
        
    }
        


	
	// Update is called once per frame
	void Update () {
		
	}
}
