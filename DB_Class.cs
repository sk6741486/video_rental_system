using System;
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
        string QueryString;
       public string ConnString = @"Data Source=LAPTOP-39KQ6SLL\SQLEXPRESS;Initial Catalog=Video_Rental_System;Integrated Security=True";
        public int CustomerID, MoviesID, MovieID, RentalMovieID;
        public DB_Class()
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
                QueryString = "Insert into Customer(FirstName,LastName,Address, Phone) Values(@FirstName,@LastName,@Address, @Ph)";
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
        public string CustomerUpdate(string FName, string LName, string Mobile, string Address)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Insert into Customer(FirstName,LastName,Address, Phone) Values(@FirstName,@LastName,@Address, @Mobile)";
                Cmd.Parameters.AddWithValue("@FirstName", FName);
                Cmd.Parameters.AddWithValue("@LastName", LName);
                Cmd.Parameters.AddWithValue("@Address", Address);
                Cmd.Parameters.AddWithValue("@Phone", Mobile);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();

                // Executed query
                Cmd.ExecuteNonQuery();
                return "successfully updated";
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
        public string CustomerDelete()
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Delete from Customer where CustID =@CustID";
                Cmd.Parameters.AddWithValue("@CustID", CustomerID);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Customer Data Deleted Successfully";
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

        public string MovieInsert(string Rating, string Title, string Year, string Rental_Cost, string Copies, string Plot, string Genre)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Insert into Movies(Rating,Title,Year,Rental_Cost,Copies,Plot,Genre) Values(@Rating,@Title,@Year,@Rental_Cost,@Copies,@Plot,@Genre)";
                Cmd.Parameters.AddWithValue("@Rating", Rating);
                Cmd.Parameters.AddWithValue("@Title", Title);
                Cmd.Parameters.AddWithValue("@Year", Year);
                Cmd.Parameters.AddWithValue("@Rental_Cost", Rental_Cost);
                Cmd.Parameters.AddWithValue("@Copies", Copies);
                Cmd.Parameters.AddWithValue("@Plot", Plot);
                Cmd.Parameters.AddWithValue("@Genre", Genre);
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
        public string IssueMovie(DateTime Issue_date)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Insert into RentedMovies(Movie_Name,CustomerName,DateRented,DateReturned) values(@MovieID,@CustID,@Issue_date,Null)";
                Cmd.Parameters.AddWithValue("@CustID", CustomerID);
                Cmd.Parameters.AddWithValue("@MovieID", MovieID);
                Cmd.Parameters.AddWithValue("@Issue_date", Issue_date);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Movies issued to customer";
            }
            catch (Exception ex)
            {
                // code to show error Message
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
        public string ReturnMovie(DateTime Return_Date)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Update into Update_Return(MovieIDFK,CustIDFK,DateRented,DateReturn) values(@MovieID,@CustID,@Return_Date,Null)";
                Cmd.Parameters.AddWithValue("@CustID", CustomerID);
                Cmd.Parameters.AddWithValue("@MovieID", MovieID);
                Cmd.Parameters.AddWithValue("@Return_date", Return_Date);

                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Movies is Returned to customer";
            }
            catch (Exception ex)
            {
                // code to show error Message
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
        public string MovieUpdate(string rating, string title, string year, string Rental_Cost, string copies, string plot, string genre)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "update Movies set rating=@rating,title=@title,year=@year,rental_cost=@Rental_Cost,copies=@copies,plot=@plot,genre=@genre where MovieID=@MovieID";
                Cmd.Parameters.AddWithValue("@rating", rating);
                Cmd.Parameters.AddWithValue("@title", title);
                Cmd.Parameters.AddWithValue("@year", year);
                Cmd.Parameters.AddWithValue("@Rental_Cost", Rental_Cost);
                Cmd.Parameters.AddWithValue("@Copies", copies);
                Cmd.Parameters.AddWithValue("@Plot", plot);
                Cmd.Parameters.AddWithValue("@Genre", genre);
                Cmd.Parameters.AddWithValue("@MovieID", MovieID);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Movies Details are updated completely";
            }
            catch (Exception ex)
            {
                // code to show error Message
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
        public string MovieDelete()
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Delete from Movies where MovieID =@MovieID";
                Cmd.Parameters.AddWithValue("@MovieID", MovieID);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Movie Details Deleted Completely";
            }
            catch (Exception ex)
            {
                // code to show error Message
                return ex.Message;
            }
            finally
            {
                // code to close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }
        public DataTable AllMovies()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From AllMovies";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }
        public DataTable RentedOut_Data()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From rentOut";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }
        public DataTable popmovie_Data()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From popularmovie";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }
        public DataTable popcust_Data()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From popularcustomer";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }
    }
}

