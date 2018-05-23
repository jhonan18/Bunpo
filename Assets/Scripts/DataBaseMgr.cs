using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data.SqlClient;
using System;

public static class DataBaseMgr {


    public static int getIdLastStudent()
    {
        string sql;
        try
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "Bumpo2018.database.windows.net";
            builder.UserID = "BunpoAdmin2018";
            builder.Password = "Bumpo@2018";
            builder.InitialCatalog = "Bumpo2018";
            sql = "select top 1 Student_ID from Student order by Student_ID DESC";
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return int.Parse(reader["Student_ID"].ToString());
                    }
                }
                connection.Close();
            }
        }
        catch (SqlException e)
        {
            Console.WriteLine(e.ToString());
        }
        return -1;
    }

    public static int getIdStudentAlias(string alias)
    {
        string sql;
        try
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "Bumpo2018.database.windows.net";
            builder.UserID = "BunpoAdmin2018";
            builder.Password = "Bumpo@2018";
            builder.InitialCatalog = "Bumpo2018";
            sql = "select Student_ID from Student where NickName = @nick; ";
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@nick", alias);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return int.Parse(reader["Student_ID"].ToString());
                    }
                }
                connection.Close();
            }
        }
        catch (SqlException e)
        {
            Console.WriteLine(e.ToString());
        }
        return -1;
    }

    public static void nuevoEstudiante(string nombre, int curso, string alias, string password)
    {
        string sql;
        try
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "Bumpo2018.database.windows.net";
            builder.UserID = "BunpoAdmin2018";
            builder.Password = "Bumpo@2018";
            builder.InitialCatalog = "Bumpo2018";
            sql = "insert into Student (Course_ID, Nombre, NickName, Password) values(@curso, @nombre, @alias, @password)";
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@curso", curso);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@alias", alias);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        catch (SqlException e)
        {
            Console.WriteLine(e.ToString());
        }

    }

    public static void actualizarEstudiante(int student_id, string json, float puntaje, int oner, int odif, int sner, int sdif, int vner, int vdif, int pner, int pdif, int cner, int cdif)
    {
        string sql;
        try
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "Bumpo2018.database.windows.net";
            builder.UserID = "BunpoAdmin2018";
            builder.Password = "Bumpo@2018";
            builder.InitialCatalog = "Bumpo2018";
            sql = "update Student set Json = @json, Puntaje = @puntaje, OracionNER = @oner, OracionDif = @odif, SujetoNER = @sner, SujetoDif = @sdif, VerboNER = @vner, VerboDif = @vdif, PredicadoNER = @pner, PredicadoDif = @pdif, ComplejoNER = @cner, ComplejoDif = @cdif " +
                "where Student_ID = @id;";
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@json", json);
                cmd.Parameters.AddWithValue("@puntaje", puntaje);
                cmd.Parameters.AddWithValue("@oner", oner);
                cmd.Parameters.AddWithValue("@odif", odif);
                cmd.Parameters.AddWithValue("@sner", sner);
                cmd.Parameters.AddWithValue("@sdif", sdif);
                cmd.Parameters.AddWithValue("@vner", vner);
                cmd.Parameters.AddWithValue("@vdif", vdif);
                cmd.Parameters.AddWithValue("@pner", pner);
                cmd.Parameters.AddWithValue("@id", student_id);
                cmd.Parameters.AddWithValue("@pdif", pdif);
                cmd.Parameters.AddWithValue("@cner", cner);
                cmd.Parameters.AddWithValue("@cdif", cdif);
                cmd.ExecuteNonQuery();

                connection.Close();
            }
        }
        catch (SqlException e)
        {
            Debug.Log("Shit");
            Console.WriteLine(e.ToString());
        }

    }

    public static Dictionary<int,string> getSchools()
    {
        Dictionary<int, string> schools = new Dictionary<int, string>();
        string sql;
        try
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "Bumpo2018.database.windows.net";
            builder.UserID = "BunpoAdmin2018";
            builder.Password = "Bumpo@2018";
            builder.InitialCatalog = "Bumpo2018";

            sql = "select * from School;";
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        schools.Add(int.Parse(reader["School_ID"].ToString()),reader["Name"].ToString());
                    }
                }
                connection.Close();
                return schools;
            }
        }
        catch (SqlException e)
        {
            
            Console.WriteLine(e.ToString());
        }
        return null;
    }

    public static Dictionary<int, string> getCourses(int school)
    {
        Dictionary<int, string> courses = new Dictionary<int, string>();
        string sql;
        try
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "Bumpo2018.database.windows.net";
            builder.UserID = "BunpoAdmin2018";
            builder.Password = "Bumpo@2018";
            builder.InitialCatalog = "Bumpo2018";

            sql = "select * from Course where School_ID = @SID;";
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@SID", school);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        courses.Add(int.Parse(reader["Course_ID"].ToString()), reader["Name"].ToString());
                    }
                }
                connection.Close();
                return courses;
            }
        }
        catch (SqlException e)
        {

            Console.WriteLine(e.ToString());
        }
        return null;
    }

    public static void cargarInfoJson()
    {

    }

    public static List<List<string>> getTop(int curso)
    {
        List<List<string>> tops = new List<List<string>>();
        string sql;
        try
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "Bumpo2018.database.windows.net";
            builder.UserID = "BunpoAdmin2018";
            builder.Password = "Bumpo@2018";
            builder.InitialCatalog = "Bumpo2018";

            sql = "select NickName, Puntaje from Student where Course_ID = @CID order by Puntaje DESC;";
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@CID", curso);



                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    List<string> aux = new List<string>();
                    while (reader.Read())
                    {
                        aux.Add(reader["NickName"].ToString());
                        aux.Add(reader["Puntaje"].ToString());

                        tops.Add(aux);
                        aux = new List<string>();
                    }
                }
                connection.Close();
                return tops;
            }
        }
        catch (SqlException e)
        {

            Console.WriteLine(e.ToString());
        }
        return null;
    }

}
