﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video_rental_system
{
    public class DB_Class
    {
        private SqlConnection Obj_Conn = new SqlConnection();
        private SqlCommand Cmd = new SqlCommand();
        private SqlDataReader Data_Reader;
        private SqlDataAdapter da = new SqlDataAdapter();
        string QueryString; public DB_Class()
        {
            string ConnString = @"Data Source=LAPTOP-39KQ6SLL\SQLEXPRESS;Initial Catalog=Video_Rental_System;Integrated Security=True";
            Obj_Conn.ConnectionString = ConnString;
        }

        public DataTable FillCustomer_Data()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From Customer";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }

        public DataTable FillMovies_Data()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From Movies";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }
        public DataTable FillRental_Data()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From RentedMovies";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }

        public string CustomerInsert(string FName, string LName, string Mobile, string Address)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Insert into Customer(FirstName,LastName,Address, Phone) Values(@FirstName,@LastName,@Address, @Mobile)";
                Cmd.Parameters.AddWithValue("@FirstName", FName);
                Cmd.Parameters.AddWithValue("@LastName", LName);
                Cmd.Parameters.AddWithValue("@Address", Address);
                Cmd.Parameters.AddWithValue("@Mobile", Mobile);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "successfully inserted";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }
        }
}
