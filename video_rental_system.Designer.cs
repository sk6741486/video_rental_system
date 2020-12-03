
namespace video_rental_system
{
    partial class video_rental_system
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Return_Movie = new System.Windows.Forms.Button();
            this.Issue_Movie = new System.Windows.Forms.Button();
            this.dateReturned_tb = new System.Windows.Forms.DateTimePicker();
            this.dateRented_tb = new System.Windows.Forms.DateTimePicker();
            this.DateReturned = new System.Windows.Forms.Label();
            this.DateRented = new System.Windows.Forms.Label();
            this.CustName_tb = new System.Windows.Forms.TextBox();
            this.Customer_Name = new System.Windows.Forms.Label();
            this.Movie_Name = new System.Windows.Forms.Label();
            this.movie_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UPDATE_CL = new System.Windows.Forms.Button();
            this.DELETE_CL = new System.Windows.Forms.Button();
            this.ADD_CA = new System.Windows.Forms.Button();
            this.Phone_tb = new System.Windows.Forms.TextBox();
            this.Address_tb = new System.Windows.Forms.TextBox();
            this.LastName_tb = new System.Windows.Forms.TextBox();
            this.FirstName_tb = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.Label();
            this.Adress = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.Customer_Detail = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UPDATE_btn = new System.Windows.Forms.Button();
            this.DELET_btn = new System.Windows.Forms.Button();
            this.ADD_btn = new System.Windows.Forms.Button();
            this.Genre_tb = new System.Windows.Forms.TextBox();
            this.Plot_tb = new System.Windows.Forms.TextBox();
            this.Copies_tb = new System.Windows.Forms.TextBox();
            this.Rental_Cost = new System.Windows.Forms.TextBox();
            this.Year_tb = new System.Windows.Forms.TextBox();
            this.Title_tb = new System.Windows.Forms.TextBox();
            this.Rating_tb = new System.Windows.Forms.TextBox();
            this.Genre = new System.Windows.Forms.Label();
            this.Plot = new System.Windows.Forms.Label();
            this.Copies = new System.Windows.Forms.Label();
            this.RentalCost = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AllMovies = new System.Windows.Forms.Button();
            this.RentedOut = new System.Windows.Forms.Button();
            this.popularcust = new System.Windows.Forms.Button();
            this.popularmov = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.popular_movie = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grid_popularcustomer = new System.Windows.Forms.DataGridView();
            this.rental = new System.Windows.Forms.TabPage();
            this.grid_rental = new System.Windows.Forms.DataGridView();
            this.movie = new System.Windows.Forms.TabPage();
            this.grid_movie = new System.Windows.Forms.DataGridView();
            this.customer = new System.Windows.Forms.TabPage();
            this.grid_customer = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.popularcustomer = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popular_movie)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_popularcustomer)).BeginInit();
            this.rental.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_rental)).BeginInit();
            this.movie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_movie)).BeginInit();
            this.customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_customer)).BeginInit();
            this.popularcustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.Return_Movie);
            this.panel1.Controls.Add(this.Issue_Movie);
            this.panel1.Controls.Add(this.dateReturned_tb);
            this.panel1.Controls.Add(this.dateRented_tb);
            this.panel1.Controls.Add(this.DateReturned);
            this.panel1.Controls.Add(this.DateRented);
            this.panel1.Controls.Add(this.CustName_tb);
            this.panel1.Controls.Add(this.Customer_Name);
            this.panel1.Controls.Add(this.Movie_Name);
            this.panel1.Controls.Add(this.movie_tb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(478, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 232);
            this.panel1.TabIndex = 1;
            // 
            // Return_Movie
            // 
            this.Return_Movie.Location = new System.Drawing.Point(212, 196);
            this.Return_Movie.Name = "Return_Movie";
            this.Return_Movie.Size = new System.Drawing.Size(103, 23);
            this.Return_Movie.TabIndex = 15;
            this.Return_Movie.Text = "Return Movie";
            this.Return_Movie.UseVisualStyleBackColor = true;
            this.Return_Movie.Click += new System.EventHandler(this.Return_Movie_Click);
            // 
            // Issue_Movie
            // 
            this.Issue_Movie.Location = new System.Drawing.Point(39, 196);
            this.Issue_Movie.Name = "Issue_Movie";
            this.Issue_Movie.Size = new System.Drawing.Size(117, 23);
            this.Issue_Movie.TabIndex = 14;
            this.Issue_Movie.Text = "Issue Movie";
            this.Issue_Movie.UseVisualStyleBackColor = true;
            this.Issue_Movie.Click += new System.EventHandler(this.Issue_Movie_Click);
            // 
            // dateReturned_tb
            // 
            this.dateReturned_tb.Location = new System.Drawing.Point(14, 153);
            this.dateReturned_tb.Name = "dateReturned_tb";
            this.dateReturned_tb.Size = new System.Drawing.Size(180, 20);
            this.dateReturned_tb.TabIndex = 13;
            // 
            // dateRented_tb
            // 
            this.dateRented_tb.Location = new System.Drawing.Point(14, 121);
            this.dateRented_tb.Name = "dateRented_tb";
            this.dateRented_tb.Size = new System.Drawing.Size(180, 20);
            this.dateRented_tb.TabIndex = 12;
            // 
            // DateReturned
            // 
            this.DateReturned.AutoSize = true;
            this.DateReturned.Location = new System.Drawing.Point(260, 153);
            this.DateReturned.Name = "DateReturned";
            this.DateReturned.Size = new System.Drawing.Size(74, 13);
            this.DateReturned.TabIndex = 8;
            this.DateReturned.Text = "DateReturned";
            // 
            // DateRented
            // 
            this.DateRented.AutoSize = true;
            this.DateRented.Location = new System.Drawing.Point(260, 121);
            this.DateRented.Name = "DateRented";
            this.DateRented.Size = new System.Drawing.Size(65, 13);
            this.DateRented.TabIndex = 7;
            this.DateRented.Text = "DateRented";
            // 
            // CustName_tb
            // 
            this.CustName_tb.Location = new System.Drawing.Point(15, 84);
            this.CustName_tb.Name = "CustName_tb";
            this.CustName_tb.Size = new System.Drawing.Size(115, 20);
            this.CustName_tb.TabIndex = 4;
            // 
            // Customer_Name
            // 
            this.Customer_Name.AutoSize = true;
            this.Customer_Name.Location = new System.Drawing.Point(263, 84);
            this.Customer_Name.Name = "Customer_Name";
            this.Customer_Name.Size = new System.Drawing.Size(82, 13);
            this.Customer_Name.TabIndex = 3;
            this.Customer_Name.Text = "Customer Name";
            // 
            // Movie_Name
            // 
            this.Movie_Name.AutoSize = true;
            this.Movie_Name.Location = new System.Drawing.Point(255, 43);
            this.Movie_Name.Name = "Movie_Name";
            this.Movie_Name.Size = new System.Drawing.Size(65, 13);
            this.Movie_Name.TabIndex = 2;
            this.Movie_Name.Text = "Movie name";
            // 
            // movie_tb
            // 
            this.movie_tb.Location = new System.Drawing.Point(14, 43);
            this.movie_tb.Name = "movie_tb";
            this.movie_tb.Size = new System.Drawing.Size(116, 20);
            this.movie_tb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rental_Details";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.UPDATE_CL);
            this.panel3.Controls.Add(this.DELETE_CL);
            this.panel3.Controls.Add(this.ADD_CA);
            this.panel3.Controls.Add(this.Phone_tb);
            this.panel3.Controls.Add(this.Address_tb);
            this.panel3.Controls.Add(this.LastName_tb);
            this.panel3.Controls.Add(this.FirstName_tb);
            this.panel3.Controls.Add(this.Phone);
            this.panel3.Controls.Add(this.Adress);
            this.panel3.Controls.Add(this.LastName);
            this.panel3.Controls.Add(this.FirstName);
            this.panel3.Controls.Add(this.Customer_Detail);
            this.panel3.Location = new System.Drawing.Point(465, 292);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 275);
            this.panel3.TabIndex = 3;
            // 
            // UPDATE_CL
            // 
            this.UPDATE_CL.Location = new System.Drawing.Point(138, 221);
            this.UPDATE_CL.Name = "UPDATE_CL";
            this.UPDATE_CL.Size = new System.Drawing.Size(75, 23);
            this.UPDATE_CL.TabIndex = 11;
            this.UPDATE_CL.Text = "UPDATE";
            this.UPDATE_CL.UseVisualStyleBackColor = true;
            this.UPDATE_CL.Click += new System.EventHandler(this.UPDATE_CL_Click);
            // 
            // DELETE_CL
            // 
            this.DELETE_CL.Location = new System.Drawing.Point(257, 221);
            this.DELETE_CL.Name = "DELETE_CL";
            this.DELETE_CL.Size = new System.Drawing.Size(75, 23);
            this.DELETE_CL.TabIndex = 10;
            this.DELETE_CL.Text = "DELETE";
            this.DELETE_CL.UseVisualStyleBackColor = true;
            this.DELETE_CL.Click += new System.EventHandler(this.DELETE_CL_Click);
            // 
            // ADD_CA
            // 
            this.ADD_CA.Location = new System.Drawing.Point(26, 221);
            this.ADD_CA.Name = "ADD_CA";
            this.ADD_CA.Size = new System.Drawing.Size(75, 23);
            this.ADD_CA.TabIndex = 9;
            this.ADD_CA.Text = "ADD";
            this.ADD_CA.UseVisualStyleBackColor = true;
            this.ADD_CA.Click += new System.EventHandler(this.ADD_CA_Click);
            // 
            // Phone_tb
            // 
            this.Phone_tb.Location = new System.Drawing.Point(26, 154);
            this.Phone_tb.Name = "Phone_tb";
            this.Phone_tb.Size = new System.Drawing.Size(100, 20);
            this.Phone_tb.TabIndex = 8;
            // 
            // Address_tb
            // 
            this.Address_tb.Location = new System.Drawing.Point(26, 115);
            this.Address_tb.Name = "Address_tb";
            this.Address_tb.Size = new System.Drawing.Size(100, 20);
            this.Address_tb.TabIndex = 7;
            // 
            // LastName_tb
            // 
            this.LastName_tb.Location = new System.Drawing.Point(26, 80);
            this.LastName_tb.Name = "LastName_tb";
            this.LastName_tb.Size = new System.Drawing.Size(100, 20);
            this.LastName_tb.TabIndex = 6;
            // 
            // FirstName_tb
            // 
            this.FirstName_tb.Location = new System.Drawing.Point(26, 48);
            this.FirstName_tb.Name = "FirstName_tb";
            this.FirstName_tb.Size = new System.Drawing.Size(100, 20);
            this.FirstName_tb.TabIndex = 5;
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(224, 157);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(38, 13);
            this.Phone.TabIndex = 4;
            this.Phone.Text = "Phone";
            // 
            // Adress
            // 
            this.Adress.AutoSize = true;
            this.Adress.Location = new System.Drawing.Point(225, 118);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(39, 13);
            this.Adress.TabIndex = 3;
            this.Adress.Text = "Adress";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(224, 83);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(55, 13);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "LastName";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(229, 48);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(54, 13);
            this.FirstName.TabIndex = 1;
            this.FirstName.Text = "FirstName";
            // 
            // Customer_Detail
            // 
            this.Customer_Detail.AutoSize = true;
            this.Customer_Detail.Location = new System.Drawing.Point(118, 17);
            this.Customer_Detail.Name = "Customer_Detail";
            this.Customer_Detail.Size = new System.Drawing.Size(84, 13);
            this.Customer_Detail.TabIndex = 0;
            this.Customer_Detail.Text = "Customer_Detail";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.UPDATE_btn);
            this.panel2.Controls.Add(this.DELET_btn);
            this.panel2.Controls.Add(this.ADD_btn);
            this.panel2.Controls.Add(this.Genre_tb);
            this.panel2.Controls.Add(this.Plot_tb);
            this.panel2.Controls.Add(this.Copies_tb);
            this.panel2.Controls.Add(this.Rental_Cost);
            this.panel2.Controls.Add(this.Year_tb);
            this.panel2.Controls.Add(this.Title_tb);
            this.panel2.Controls.Add(this.Rating_tb);
            this.panel2.Controls.Add(this.Genre);
            this.panel2.Controls.Add(this.Plot);
            this.panel2.Controls.Add(this.Copies);
            this.panel2.Controls.Add(this.RentalCost);
            this.panel2.Controls.Add(this.Year);
            this.panel2.Controls.Add(this.Title);
            this.panel2.Controls.Add(this.Rating);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 294);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // UPDATE_btn
            // 
            this.UPDATE_btn.Location = new System.Drawing.Point(203, 258);
            this.UPDATE_btn.Name = "UPDATE_btn";
            this.UPDATE_btn.Size = new System.Drawing.Size(75, 23);
            this.UPDATE_btn.TabIndex = 18;
            this.UPDATE_btn.Text = "UPDATE";
            this.UPDATE_btn.UseVisualStyleBackColor = true;
            this.UPDATE_btn.Click += new System.EventHandler(this.UPDATE_btn_Click);
            // 
            // DELET_btn
            // 
            this.DELET_btn.Location = new System.Drawing.Point(337, 258);
            this.DELET_btn.Name = "DELET_btn";
            this.DELET_btn.Size = new System.Drawing.Size(75, 23);
            this.DELET_btn.TabIndex = 17;
            this.DELET_btn.Text = "DELETE";
            this.DELET_btn.UseVisualStyleBackColor = true;
            this.DELET_btn.Click += new System.EventHandler(this.DELET_btn_Click);
            // 
            // ADD_btn
            // 
            this.ADD_btn.Location = new System.Drawing.Point(46, 258);
            this.ADD_btn.Name = "ADD_btn";
            this.ADD_btn.Size = new System.Drawing.Size(75, 23);
            this.ADD_btn.TabIndex = 16;
            this.ADD_btn.Text = "ADD";
            this.ADD_btn.UseVisualStyleBackColor = true;
            this.ADD_btn.Click += new System.EventHandler(this.ADD_btn_Click);
            // 
            // Genre_tb
            // 
            this.Genre_tb.Location = new System.Drawing.Point(46, 209);
            this.Genre_tb.Name = "Genre_tb";
            this.Genre_tb.Size = new System.Drawing.Size(100, 20);
            this.Genre_tb.TabIndex = 15;
            // 
            // Plot_tb
            // 
            this.Plot_tb.Location = new System.Drawing.Point(46, 183);
            this.Plot_tb.Name = "Plot_tb";
            this.Plot_tb.Size = new System.Drawing.Size(100, 20);
            this.Plot_tb.TabIndex = 14;
            // 
            // Copies_tb
            // 
            this.Copies_tb.Location = new System.Drawing.Point(46, 157);
            this.Copies_tb.Name = "Copies_tb";
            this.Copies_tb.Size = new System.Drawing.Size(100, 20);
            this.Copies_tb.TabIndex = 13;
            // 
            // Rental_Cost
            // 
            this.Rental_Cost.Location = new System.Drawing.Point(46, 131);
            this.Rental_Cost.Name = "Rental_Cost";
            this.Rental_Cost.Size = new System.Drawing.Size(100, 20);
            this.Rental_Cost.TabIndex = 12;
            // 
            // Year_tb
            // 
            this.Year_tb.Location = new System.Drawing.Point(46, 105);
            this.Year_tb.Name = "Year_tb";
            this.Year_tb.Size = new System.Drawing.Size(100, 20);
            this.Year_tb.TabIndex = 11;
            // 
            // Title_tb
            // 
            this.Title_tb.Location = new System.Drawing.Point(46, 73);
            this.Title_tb.Name = "Title_tb";
            this.Title_tb.Size = new System.Drawing.Size(100, 20);
            this.Title_tb.TabIndex = 10;
            // 
            // Rating_tb
            // 
            this.Rating_tb.Location = new System.Drawing.Point(46, 48);
            this.Rating_tb.Name = "Rating_tb";
            this.Rating_tb.Size = new System.Drawing.Size(100, 20);
            this.Rating_tb.TabIndex = 9;
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Location = new System.Drawing.Point(240, 216);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(36, 13);
            this.Genre.TabIndex = 8;
            this.Genre.Text = "Genre";
            // 
            // Plot
            // 
            this.Plot.AutoSize = true;
            this.Plot.Location = new System.Drawing.Point(240, 186);
            this.Plot.Name = "Plot";
            this.Plot.Size = new System.Drawing.Size(25, 13);
            this.Plot.TabIndex = 7;
            this.Plot.Text = "Plot";
            // 
            // Copies
            // 
            this.Copies.AutoSize = true;
            this.Copies.Location = new System.Drawing.Point(240, 160);
            this.Copies.Name = "Copies";
            this.Copies.Size = new System.Drawing.Size(39, 13);
            this.Copies.TabIndex = 6;
            this.Copies.Text = "Copies";
            // 
            // RentalCost
            // 
            this.RentalCost.AutoSize = true;
            this.RentalCost.Location = new System.Drawing.Point(240, 134);
            this.RentalCost.Name = "RentalCost";
            this.RentalCost.Size = new System.Drawing.Size(59, 13);
            this.RentalCost.TabIndex = 5;
            this.RentalCost.Text = "RentalCost";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(240, 108);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(29, 13);
            this.Year.TabIndex = 4;
            this.Year.Text = "Year";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(240, 76);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(27, 13);
            this.Title.TabIndex = 3;
            this.Title.Text = "Title";
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Location = new System.Drawing.Point(240, 51);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(38, 13);
            this.Rating.TabIndex = 2;
            this.Rating.Text = "Rating";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Movie_Detail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 0;
            // 
            // AllMovies
            // 
            this.AllMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AllMovies.Location = new System.Drawing.Point(831, 292);
            this.AllMovies.Name = "AllMovies";
            this.AllMovies.Size = new System.Drawing.Size(75, 36);
            this.AllMovies.TabIndex = 5;
            this.AllMovies.Text = "AllMovies";
            this.AllMovies.UseVisualStyleBackColor = false;
            this.AllMovies.Click += new System.EventHandler(this.AllMovies_Click);
            // 
            // RentedOut
            // 
            this.RentedOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RentedOut.Location = new System.Drawing.Point(831, 348);
            this.RentedOut.Name = "RentedOut";
            this.RentedOut.Size = new System.Drawing.Size(75, 36);
            this.RentedOut.TabIndex = 6;
            this.RentedOut.Text = "RentedOut";
            this.RentedOut.UseVisualStyleBackColor = false;
            this.RentedOut.Click += new System.EventHandler(this.RentedOut_Click);
            // 
            // popularcust
            // 
            this.popularcust.Location = new System.Drawing.Point(808, 403);
            this.popularcust.Name = "popularcust";
            this.popularcust.Size = new System.Drawing.Size(98, 23);
            this.popularcust.TabIndex = 8;
            this.popularcust.Text = "popular customer";
            this.popularcust.UseVisualStyleBackColor = true;
            this.popularcust.Click += new System.EventHandler(this.popularcust_Click);
            // 
            // popularmov
            // 
            this.popularmov.Location = new System.Drawing.Point(808, 444);
            this.popularmov.Name = "popularmov";
            this.popularmov.Size = new System.Drawing.Size(98, 23);
            this.popularmov.TabIndex = 9;
            this.popularmov.Text = "popular movie";
            this.popularmov.UseVisualStyleBackColor = true;
            this.popularmov.Click += new System.EventHandler(this.popularmov_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.popular_movie);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(434, 219);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "popular movie";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // popular_movie
            // 
            this.popular_movie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popular_movie.Location = new System.Drawing.Point(3, 0);
            this.popular_movie.Name = "popular_movie";
            this.popular_movie.Size = new System.Drawing.Size(428, 219);
            this.popular_movie.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grid_popularcustomer);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(434, 219);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "popular customer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grid_popularcustomer
            // 
            this.grid_popularcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_popularcustomer.Location = new System.Drawing.Point(3, 3);
            this.grid_popularcustomer.Name = "grid_popularcustomer";
            this.grid_popularcustomer.Size = new System.Drawing.Size(428, 216);
            this.grid_popularcustomer.TabIndex = 0;
            // 
            // rental
            // 
            this.rental.Controls.Add(this.grid_rental);
            this.rental.Location = new System.Drawing.Point(4, 22);
            this.rental.Name = "rental";
            this.rental.Padding = new System.Windows.Forms.Padding(3);
            this.rental.Size = new System.Drawing.Size(434, 219);
            this.rental.TabIndex = 2;
            this.rental.Text = "rental";
            this.rental.UseVisualStyleBackColor = true;
            // 
            // grid_rental
            // 
            this.grid_rental.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.grid_rental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_rental.Location = new System.Drawing.Point(6, 6);
            this.grid_rental.Name = "grid_rental";
            this.grid_rental.Size = new System.Drawing.Size(422, 207);
            this.grid_rental.TabIndex = 0;
            this.grid_rental.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_rental_CellContentClick);
            // 
            // movie
            // 
            this.movie.Controls.Add(this.grid_movie);
            this.movie.Location = new System.Drawing.Point(4, 22);
            this.movie.Name = "movie";
            this.movie.Padding = new System.Windows.Forms.Padding(3);
            this.movie.Size = new System.Drawing.Size(434, 219);
            this.movie.TabIndex = 1;
            this.movie.Text = "movie";
            this.movie.UseVisualStyleBackColor = true;
            // 
            // grid_movie
            // 
            this.grid_movie.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grid_movie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_movie.Location = new System.Drawing.Point(6, 6);
            this.grid_movie.Name = "grid_movie";
            this.grid_movie.Size = new System.Drawing.Size(422, 207);
            this.grid_movie.TabIndex = 0;
            this.grid_movie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_movie_CellContentClick);
            // 
            // customer
            // 
            this.customer.Controls.Add(this.grid_customer);
            this.customer.Controls.Add(this.button1);
            this.customer.Location = new System.Drawing.Point(4, 22);
            this.customer.Name = "customer";
            this.customer.Padding = new System.Windows.Forms.Padding(3);
            this.customer.Size = new System.Drawing.Size(434, 219);
            this.customer.TabIndex = 0;
            this.customer.Text = "customer";
            this.customer.UseVisualStyleBackColor = true;
            // 
            // grid_customer
            // 
            this.grid_customer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grid_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_customer.GridColor = System.Drawing.Color.Gainsboro;
            this.grid_customer.Location = new System.Drawing.Point(9, 9);
            this.grid_customer.Name = "grid_customer";
            this.grid_customer.Size = new System.Drawing.Size(422, 207);
            this.grid_customer.TabIndex = 0;
            this.grid_customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_customer_CellContentClick);
            this.grid_customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_customer_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // popularcustomer
            // 
            this.popularcustomer.Controls.Add(this.customer);
            this.popularcustomer.Controls.Add(this.movie);
            this.popularcustomer.Controls.Add(this.rental);
            this.popularcustomer.Controls.Add(this.tabPage1);
            this.popularcustomer.Controls.Add(this.tabPage2);
            this.popularcustomer.Location = new System.Drawing.Point(12, 12);
            this.popularcustomer.Name = "popularcustomer";
            this.popularcustomer.SelectedIndex = 0;
            this.popularcustomer.Size = new System.Drawing.Size(442, 245);
            this.popularcustomer.TabIndex = 0;
            // 
            // video_rental_system
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(904, 581);
            this.Controls.Add(this.popularmov);
            this.Controls.Add(this.popularcust);
            this.Controls.Add(this.RentedOut);
            this.Controls.Add(this.AllMovies);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.popularcustomer);
            this.Name = "video_rental_system";
            this.Text = "video_rental_system";
            this.Load += new System.EventHandler(this.video_rental_system_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popular_movie)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_popularcustomer)).EndInit();
            this.rental.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_rental)).EndInit();
            this.movie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_movie)).EndInit();
            this.customer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_customer)).EndInit();
            this.popularcustomer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Customer_Detail;
        private System.Windows.Forms.Label Movie_Name;
        private System.Windows.Forms.TextBox movie_tb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DateReturned;
        private System.Windows.Forms.Label DateRented;
        private System.Windows.Forms.TextBox CustName_tb;
        private System.Windows.Forms.Label Customer_Name;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Adress;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.Label Plot;
        private System.Windows.Forms.Label Copies;
        private System.Windows.Forms.Label RentalCost;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.TextBox FirstName_tb;
        private System.Windows.Forms.TextBox LastName_tb;
        private System.Windows.Forms.TextBox Address_tb;
        private System.Windows.Forms.Button UPDATE_CL;
        private System.Windows.Forms.Button DELETE_CL;
        private System.Windows.Forms.Button ADD_CA;
        private System.Windows.Forms.TextBox Phone_tb;
        private System.Windows.Forms.TextBox Title_tb;
        private System.Windows.Forms.TextBox Rating_tb;
        private System.Windows.Forms.Button UPDATE_btn;
        private System.Windows.Forms.Button DELET_btn;
        private System.Windows.Forms.Button ADD_btn;
        private System.Windows.Forms.TextBox Genre_tb;
        private System.Windows.Forms.TextBox Plot_tb;
        private System.Windows.Forms.TextBox Copies_tb;
        private System.Windows.Forms.TextBox Rental_Cost;
        private System.Windows.Forms.TextBox Year_tb;
        private System.Windows.Forms.DateTimePicker dateReturned_tb;
        private System.Windows.Forms.DateTimePicker dateRented_tb;
        private System.Windows.Forms.Button Return_Movie;
        private System.Windows.Forms.Button Issue_Movie;
        private System.Windows.Forms.Button AllMovies;
        private System.Windows.Forms.Button RentedOut;
        private System.Windows.Forms.Button popularcust;
        private System.Windows.Forms.Button popularmov;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView popular_movie;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView grid_popularcustomer;
        private System.Windows.Forms.TabPage rental;
        private System.Windows.Forms.DataGridView grid_rental;
        private System.Windows.Forms.TabPage movie;
        private System.Windows.Forms.DataGridView grid_movie;
        private System.Windows.Forms.TabPage customer;
        private System.Windows.Forms.DataGridView grid_customer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl popularcustomer;
    }
}

