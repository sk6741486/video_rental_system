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
    }
    }


