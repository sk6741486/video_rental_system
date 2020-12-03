using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace video_rental_system
{
    public partial class video_rental_system : Form
    {
        DB_Class Obj_data = new DB_Class();
        public video_rental_system()
        {
            InitializeComponent();
            Customer_Load();
            Movies_Load();
            Rental_Load();
        }
        public void Customer_Load()
        {
            grid_customer.DataSource = null;
            try
            {
                grid_customer.DataSource = Obj_data.FillCustomer_Data();
                grid_customer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Movies_Load()
        {
            grid_movie.DataSource = null;
            try
            {
                grid_movie.DataSource = Obj_data.FillMovies_Data();
                grid_movie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Rental_Load()
        {
            grid_rental.DataSource = null;
            try
            {
                grid_rental.DataSource = Obj_data.FillRental_Data();
                grid_rental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ADD_CA_Click(object sender, EventArgs e)
        {
            if (FirstName_tb.Text != "" && LastName_tb.Text != "" && Address_tb.Text != "" && Phone_tb.Text != "")
            {
                string message = Obj_data.CustomerInsert(FirstName_tb.Text, LastName_tb.Text, Phone_tb.Text, Address_tb.Text);
                MessageBox.Show(message);
                FirstName_tb.Text = "";
                LastName_tb.Text = "";
                Phone_tb.Text = "";
                Address_tb.Text = "";
                Customer_Load();
            }
            else
            {
                MessageBox.Show("Fill required details then move ahead");
            }
        }

        private void video_rental_system_Load(object sender, EventArgs e)
        {

        }

        private void UPDATE_CL_Click(object sender, EventArgs e)
        {
            if (FirstName_tb.Text != "" && LastName_tb.Text != "" && Address_tb.Text != "" && Phone_tb.Text != "")
            {
                string message = Obj_data.CustomerUpdate(FirstName_tb.Text, LastName_tb.Text, Phone_tb.Text, Address_tb.Text);
                MessageBox.Show(message);
                FirstName_tb.Text = "";
                LastName_tb.Text = "";
                Phone_tb.Text = "";
                Address_tb.Text = "";
                Customer_Load();

            }
            else
            {
                MessageBox.Show("please select the data which you want to update");
            }
        }

        private void grid_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string newvalue = grid_customer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " + e.ColumnIndex.ToString() + " Value = " + newvalue;
                Obj_data.CustomerID = Convert.ToInt32(grid_customer.Rows[e.RowIndex].Cells[0].Value);
                FirstName_tb.Text = grid_customer.Rows[e.RowIndex].Cells[1].Value.ToString();
                LastName_tb.Text = grid_customer.Rows[e.RowIndex].Cells[2].Value.ToString();
                Phone_tb.Text = grid_customer.Rows[e.RowIndex].Cells[4].Value.ToString();
                Address_tb.Text = grid_customer.Rows[e.RowIndex].Cells[3].Value.ToString();
                CustName_tb.Text = grid_customer.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + grid_customer.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong", ex.Message);
            }
        }

      
        private void DELETE_CL_Click(object sender, EventArgs e)
        {
            string message = Obj_data.CustomerDelete();
            MessageBox.Show(message);
            FirstName_tb.Text = "";
            LastName_tb.Text = "";
            Phone_tb.Text = "";
            Address_tb.Text = "";
            Customer_Load();
        }

        private void ADD_btn_Click(object sender, EventArgs e)
        {
            if (Rating_tb.Text != "" && Title_tb.Text != "" && Year_tb.Text != "" && Rental_Cost.Text != "" && Copies_tb.Text != "" && Plot_tb.Text != "" && Genre_tb.Text != "")
            {
                string message = Obj_data.MovieInsert(Rating_tb.Text, Title_tb.Text, Year_tb.Text, Rental_Cost.Text, Copies_tb.Text, Plot_tb.Text, Genre_tb.Text);
                MessageBox.Show(message);
                Rating_tb.Text = "";
                Title_tb.Text = "";
                Year_tb.Text = "";
                Rental_Cost.Text = "";
                Copies_tb.Text = "";
                Plot_tb.Text = "";
                Genre_tb.Text = "";
                Movies_Load();
            }
            else
            {
                MessageBox.Show("Fill required details then move ahead");
            }
       }

        private void Issue_Movie_Click(object sender, EventArgs e)
        {
            if (movie_tb.Text != "" && CustName_tb.Text != "")
            {
                string message = Obj_data.IssueMovie(Convert.ToDateTime(dateRented_tb.Text));
                MessageBox.Show(message);
                Rating_tb.Text = "";
                Title_tb.Text = "";
                Year_tb.Text = "";
                Rental_Cost.Text = "";
                Copies_tb.Text = "";
                Plot_tb.Text = "";
                Genre_tb.Text = "";
                movie_tb.Text = "";
                FirstName_tb.Text = "";
                LastName_tb.Text = "";
                Address_tb.Text = "";
                Phone_tb.Text = "";
                CustName_tb.Text = "";
               
                Rental_Load();
            }
            else
            {
                // code to show the message if user did not fill all the details
                MessageBox.Show("Please fill all the required details and add the new details with the help of ADD button");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grid_movie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string newvalue = grid_movie.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " + e.ColumnIndex.ToString() + " Value = " + newvalue;
                Obj_data.MovieID = Convert.ToInt32(grid_movie.Rows[e.RowIndex].Cells[0].Value);
                Rating_tb.Text = grid_movie.Rows[e.RowIndex].Cells[1].Value.ToString();
                Title_tb.Text = grid_movie.Rows[e.RowIndex].Cells[2].Value.ToString();
                Year_tb.Text = grid_movie.Rows[e.RowIndex].Cells[3].Value.ToString();
                Rental_Cost.Text =grid_movie.Rows[e.RowIndex].Cells[4].Value.ToString();
                Copies_tb.Text = grid_movie.Rows[e.RowIndex].Cells[5].Value.ToString();
                Plot_tb.Text = grid_movie.Rows[e.RowIndex].Cells[6].Value.ToString();
                Genre_tb.Text = grid_movie.Rows[e.RowIndex].Cells[7].Value.ToString();
                movie_tb.Text = grid_movie.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {

                // code to show the message if user did not fill all the details
                MessageBox.Show("Something is wrong", ex.Message);
            }

        }

        private void grid_rental_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string newvalue = grid_rental.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " + e.ColumnIndex.ToString() + " Value = " + newvalue;
                Obj_data.RentalMovieID = Convert.ToInt32(grid_rental.Rows[e.RowIndex].Cells[0].Value);
                movie_tb.Text = grid_rental.Rows[e.RowIndex].Cells[1].Value.ToString();
                CustName_tb.Text = grid_rental.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateRented_tb.Text = grid_rental.Rows[e.RowIndex].Cells[3].Value.ToString();
                dateReturned_tb.Text = grid_rental.Rows[e.RowIndex].Cells[4].Value.ToString();

                movie_tb.Text = grid_movie.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {

                // code to show the message if user did not fill all the details
                MessageBox.Show("Something is wrong", ex.Message);
            }

        }

        private void Return_Movie_Click(object sender, EventArgs e)
        {
            if (movie_tb.Text != "" && CustName_tb.Text != "")
            {
                string message = Obj_data.ReturnMovie(Convert.ToDateTime(dateReturned_tb.Text));
               MessageBox.Show(message);
                Rating_tb.Text = "";
                Title_tb.Text = "";
                Year_tb.Text = "";
                Rental_Cost.Text = "";
                Copies_tb.Text = "";
                Plot_tb.Text = "";
                Genre_tb.Text = "";
                movie_tb.Text = "";
                FirstName_tb.Text = "";
                LastName_tb.Text = "";
                Phone_tb.Text = "";
                Address_tb.Text = "";
                CustName_tb.Text = "";
                Rental_Load();
            }
            else
            {
                // code to show the message if user did not fill all the details
                MessageBox.Show("Please fill all the required details and add new detail with the help of ADD button ");
            }
        }

        private void UPDATE_btn_Click(object sender, EventArgs e)
        {
            if (Rating_tb.Text != "" && Title_tb.Text != "" && Year_tb.Text != "" && Rental_Cost.Text != "" && Copies_tb.Text != "" && Plot_tb.Text != "" && Genre_tb.Text != "")
            {
                string message = Obj_data.MovieUpdate(Rating_tb.Text, Title_tb.Text, Year_tb.Text, Rental_Cost.Text, Copies_tb.Text, Plot_tb.Text, Genre_tb.Text);
                MessageBox.Show(message);
                Rating_tb.Text = "";
                Title_tb.Text = "";
                Year_tb.Text = "";
                Rental_Cost.Text = "";
                Copies_tb.Text = "";
                Plot_tb.Text = "";
                Genre_tb.Text = "";
                Movies_Load();
            }
            else
            {
                // code to show the message if user did not fill all the details
                MessageBox.Show("fullfill the all givin detail then move ahead");
            }

        }

        private void DELET_btn_Click(object sender, EventArgs e)
        {
            string message = Obj_data.MovieDelete();
            MessageBox.Show(message);
            Rating_tb.Text = "";
            Title_tb.Text = "";
            Year_tb.Text = "";
            Rental_Cost.Text = "";
            Copies_tb.Text = "";
            Plot_tb.Text = "";
            Genre_tb.Text = "";
            movie_tb.Text = "";
            Movies_Load();
        }

        private void AllMovies_Click(object sender, EventArgs e)
        {
            Rental_Load();
        }

        private void RentedOut_Click(object sender, EventArgs e)
        {
            grid_rental.DataSource = null;
            try
            {
                grid_rental.DataSource = Obj_data.RentedOut_Data();
                grid_rental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void popularcust_Click(object sender, EventArgs e)
        {
            grid_popularcustomer.DataSource = null;
            try
            {
                grid_popularcustomer.DataSource = Obj_data.popcust_Data();
                grid_popularcustomer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void popularmov_Click(object sender, EventArgs e)
        {
            popular_movie.DataSource = null;
            try
            {
                popular_movie.DataSource = Obj_data.popmovie_Data();
                popular_movie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void popular_movie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
 }
    
    
    


