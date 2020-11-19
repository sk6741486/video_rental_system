
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.customer = new System.Windows.Forms.TabPage();
            this.grid_customer = new System.Windows.Forms.DataGridView();
            this.movie = new System.Windows.Forms.TabPage();
            this.grid_movie = new System.Windows.Forms.DataGridView();
            this.rental = new System.Windows.Forms.TabPage();
            this.grid_rental = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Customer_Detail = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.movie_idfk_tb = new System.Windows.Forms.TextBox();
            this.MovieIDFK = new System.Windows.Forms.Label();
            this.CustIDFK = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.DateRented = new System.Windows.Forms.Label();
            this.DateReturned = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.ADD = new System.Windows.Forms.Button();
            this.DELET = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.LastName = new System.Windows.Forms.Label();
            this.Adress = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.RentalCost = new System.Windows.Forms.Label();
            this.Copies = new System.Windows.Forms.Label();
            this.Plot = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.ADD_CA = new System.Windows.Forms.Button();
            this.DELET_CL = new System.Windows.Forms.Button();
            this.UPDATE_CL = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.ADD_btn = new System.Windows.Forms.Button();
            this.DELET_btn = new System.Windows.Forms.Button();
            this.UPDATE_btn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_customer)).BeginInit();
            this.movie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_movie)).BeginInit();
            this.rental.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_rental)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.customer);
            this.tabControl1.Controls.Add(this.movie);
            this.tabControl1.Controls.Add(this.rental);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(442, 245);
            this.tabControl1.TabIndex = 0;
            // 
            // customer
            // 
            this.customer.Controls.Add(this.grid_customer);
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
            this.grid_customer.Location = new System.Drawing.Point(6, 6);
            this.grid_customer.Name = "grid_customer";
            this.grid_customer.Size = new System.Drawing.Size(422, 207);
            this.grid_customer.TabIndex = 0;
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
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UPDATE);
            this.panel1.Controls.Add(this.DELET);
            this.panel1.Controls.Add(this.ADD);
            this.panel1.Controls.Add(this.DateReturned);
            this.panel1.Controls.Add(this.DateRented);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.CustIDFK);
            this.panel1.Controls.Add(this.MovieIDFK);
            this.panel1.Controls.Add(this.movie_idfk_tb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(478, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 232);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.UPDATE_CL);
            this.panel3.Controls.Add(this.DELET_CL);
            this.panel3.Controls.Add(this.ADD_CA);
            this.panel3.Controls.Add(this.textBox7);
            this.panel3.Controls.Add(this.textBox6);
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.Phone);
            this.panel3.Controls.Add(this.Adress);
            this.panel3.Controls.Add(this.LastName);
            this.panel3.Controls.Add(this.FirstName);
            this.panel3.Controls.Add(this.Customer_Detail);
            this.panel3.Location = new System.Drawing.Point(491, 292);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(312, 275);
            this.panel3.TabIndex = 3;
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
            this.panel2.Controls.Add(this.UPDATE_btn);
            this.panel2.Controls.Add(this.DELET_btn);
            this.panel2.Controls.Add(this.ADD_btn);
            this.panel2.Controls.Add(this.textBox14);
            this.panel2.Controls.Add(this.textBox13);
            this.panel2.Controls.Add(this.textBox12);
            this.panel2.Controls.Add(this.textBox11);
            this.panel2.Controls.Add(this.textBox10);
            this.panel2.Controls.Add(this.textBox9);
            this.panel2.Controls.Add(this.textBox8);
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 0;
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
            // movie_idfk_tb
            // 
            this.movie_idfk_tb.Location = new System.Drawing.Point(14, 43);
            this.movie_idfk_tb.Name = "movie_idfk_tb";
            this.movie_idfk_tb.Size = new System.Drawing.Size(116, 20);
            this.movie_idfk_tb.TabIndex = 1;
            // 
            // MovieIDFK
            // 
            this.MovieIDFK.AutoSize = true;
            this.MovieIDFK.Location = new System.Drawing.Point(199, 43);
            this.MovieIDFK.Name = "MovieIDFK";
            this.MovieIDFK.Size = new System.Drawing.Size(60, 13);
            this.MovieIDFK.TabIndex = 2;
            this.MovieIDFK.Text = "MovieIDFK";
            // 
            // CustIDFK
            // 
            this.CustIDFK.AutoSize = true;
            this.CustIDFK.Location = new System.Drawing.Point(199, 84);
            this.CustIDFK.Name = "CustIDFK";
            this.CustIDFK.Size = new System.Drawing.Size(52, 13);
            this.CustIDFK.TabIndex = 3;
            this.CustIDFK.Text = "CustIDFK";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(13, 159);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(115, 20);
            this.textBox3.TabIndex = 6;
            // 
            // DateRented
            // 
            this.DateRented.AutoSize = true;
            this.DateRented.Location = new System.Drawing.Point(199, 121);
            this.DateRented.Name = "DateRented";
            this.DateRented.Size = new System.Drawing.Size(65, 13);
            this.DateRented.TabIndex = 7;
            this.DateRented.Text = "DateRented";
            // 
            // DateReturned
            // 
            this.DateReturned.AutoSize = true;
            this.DateReturned.Location = new System.Drawing.Point(199, 159);
            this.DateReturned.Name = "DateReturned";
            this.DateReturned.Size = new System.Drawing.Size(74, 13);
            this.DateReturned.TabIndex = 8;
            this.DateReturned.Text = "DateReturned";
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
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(15, 200);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(75, 23);
            this.ADD.TabIndex = 9;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            // 
            // DELET
            // 
            this.DELET.Location = new System.Drawing.Point(119, 200);
            this.DELET.Name = "DELET";
            this.DELET.Size = new System.Drawing.Size(75, 23);
            this.DELET.TabIndex = 10;
            this.DELET.Text = "DELET";
            this.DELET.UseVisualStyleBackColor = true;
            // 
            // UPDATE
            // 
            this.UPDATE.Location = new System.Drawing.Point(217, 200);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(75, 23);
            this.UPDATE.TabIndex = 11;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = true;
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
            // Adress
            // 
            this.Adress.AutoSize = true;
            this.Adress.Location = new System.Drawing.Point(225, 118);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(39, 13);
            this.Adress.TabIndex = 3;
            this.Adress.Text = "Adress";
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
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Location = new System.Drawing.Point(240, 51);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(38, 13);
            this.Rating.TabIndex = 2;
            this.Rating.Text = "Rating";
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
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(240, 108);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(29, 13);
            this.Year.TabIndex = 4;
            this.Year.Text = "Year";
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
            // Copies
            // 
            this.Copies.AutoSize = true;
            this.Copies.Location = new System.Drawing.Point(240, 160);
            this.Copies.Name = "Copies";
            this.Copies.Size = new System.Drawing.Size(39, 13);
            this.Copies.TabIndex = 6;
            this.Copies.Text = "Copies";
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
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Location = new System.Drawing.Point(240, 216);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(36, 13);
            this.Genre.TabIndex = 8;
            this.Genre.Text = "Genre";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(26, 48);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(26, 80);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(26, 115);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(26, 154);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 8;
            // 
            // ADD_CA
            // 
            this.ADD_CA.Location = new System.Drawing.Point(26, 221);
            this.ADD_CA.Name = "ADD_CA";
            this.ADD_CA.Size = new System.Drawing.Size(75, 23);
            this.ADD_CA.TabIndex = 9;
            this.ADD_CA.Text = "ADD";
            this.ADD_CA.UseVisualStyleBackColor = true;
            // 
            // DELET_CL
            // 
            this.DELET_CL.Location = new System.Drawing.Point(127, 221);
            this.DELET_CL.Name = "DELET_CL";
            this.DELET_CL.Size = new System.Drawing.Size(75, 23);
            this.DELET_CL.TabIndex = 10;
            this.DELET_CL.Text = "DELET";
            this.DELET_CL.UseVisualStyleBackColor = true;
            // 
            // UPDATE_CL
            // 
            this.UPDATE_CL.Location = new System.Drawing.Point(227, 221);
            this.UPDATE_CL.Name = "UPDATE_CL";
            this.UPDATE_CL.Size = new System.Drawing.Size(75, 23);
            this.UPDATE_CL.TabIndex = 11;
            this.UPDATE_CL.Text = "UPDATE";
            this.UPDATE_CL.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(46, 48);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 9;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(46, 73);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 10;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(46, 105);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 11;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(46, 131);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 12;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(46, 157);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 13;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(46, 183);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 14;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(46, 209);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 15;
            // 
            // ADD_btn
            // 
            this.ADD_btn.Location = new System.Drawing.Point(46, 258);
            this.ADD_btn.Name = "ADD_btn";
            this.ADD_btn.Size = new System.Drawing.Size(75, 23);
            this.ADD_btn.TabIndex = 16;
            this.ADD_btn.Text = "ADD";
            this.ADD_btn.UseVisualStyleBackColor = true;
            // 
            // DELET_btn
            // 
            this.DELET_btn.Location = new System.Drawing.Point(190, 258);
            this.DELET_btn.Name = "DELET_btn";
            this.DELET_btn.Size = new System.Drawing.Size(75, 23);
            this.DELET_btn.TabIndex = 17;
            this.DELET_btn.Text = "DELET";
            this.DELET_btn.UseVisualStyleBackColor = true;
            // 
            // UPDATE_btn
            // 
            this.UPDATE_btn.Location = new System.Drawing.Point(316, 258);
            this.UPDATE_btn.Name = "UPDATE_btn";
            this.UPDATE_btn.Size = new System.Drawing.Size(75, 23);
            this.UPDATE_btn.TabIndex = 18;
            this.UPDATE_btn.Text = "UPDATE";
            this.UPDATE_btn.UseVisualStyleBackColor = true;
            // 
            // video_rental_system
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 581);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "video_rental_system";
            this.Text = "video_rental_system";
            this.tabControl1.ResumeLayout(false);
            this.customer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_customer)).EndInit();
            this.movie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_movie)).EndInit();
            this.rental.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_rental)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage customer;
        private System.Windows.Forms.TabPage movie;
        private System.Windows.Forms.TabPage rental;
        private System.Windows.Forms.DataGridView grid_customer;
        private System.Windows.Forms.DataGridView grid_movie;
        private System.Windows.Forms.DataGridView grid_rental;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Customer_Detail;
        private System.Windows.Forms.Label MovieIDFK;
        private System.Windows.Forms.TextBox movie_idfk_tb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DateReturned;
        private System.Windows.Forms.Label DateRented;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label CustIDFK;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Button DELET;
        private System.Windows.Forms.Button ADD;
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button UPDATE_CL;
        private System.Windows.Forms.Button DELET_CL;
        private System.Windows.Forms.Button ADD_CA;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button UPDATE_btn;
        private System.Windows.Forms.Button DELET_btn;
        private System.Windows.Forms.Button ADD_btn;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
    }
}

