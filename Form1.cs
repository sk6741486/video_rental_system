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
    }
}
    

