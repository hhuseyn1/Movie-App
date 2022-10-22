namespace Movie_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flwLayPanel_Movies = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.MovieSearch_btn = new System.Windows.Forms.Button();
            this.MovieSearch_txtbox = new System.Windows.Forms.TextBox();
            this.btn_Home = new System.Windows.Forms.Button();
            this.lbl_MovieSiteName = new System.Windows.Forms.Label();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // flwLayPanel_Movies
            // 
            this.flwLayPanel_Movies.Location = new System.Drawing.Point(2, 89);
            this.flwLayPanel_Movies.Name = "flwLayPanel_Movies";
            this.flwLayPanel_Movies.Size = new System.Drawing.Size(1192, 581);
            this.flwLayPanel_Movies.TabIndex = 3;
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnl_Header.Controls.Add(this.lbl_MovieSiteName);
            this.pnl_Header.Controls.Add(this.btn_Home);
            this.pnl_Header.Controls.Add(this.MovieSearch_btn);
            this.pnl_Header.Controls.Add(this.MovieSearch_txtbox);
            this.pnl_Header.Location = new System.Drawing.Point(2, -19);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1192, 111);
            this.pnl_Header.TabIndex = 2;
            // 
            // MovieSearch_btn
            // 
            this.MovieSearch_btn.Location = new System.Drawing.Point(1096, 47);
            this.MovieSearch_btn.Name = "MovieSearch_btn";
            this.MovieSearch_btn.Size = new System.Drawing.Size(75, 23);
            this.MovieSearch_btn.TabIndex = 1;
            this.MovieSearch_btn.Text = "Search";
            this.MovieSearch_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MovieSearch_btn.UseVisualStyleBackColor = true;
            this.MovieSearch_btn.Click += new System.EventHandler(this.MovieSearch_btn_Click);
            // 
            // MovieSearch_txtbox
            // 
            this.MovieSearch_txtbox.Location = new System.Drawing.Point(879, 42);
            this.MovieSearch_txtbox.Multiline = true;
            this.MovieSearch_txtbox.Name = "MovieSearch_txtbox";
            this.MovieSearch_txtbox.Size = new System.Drawing.Size(200, 28);
            this.MovieSearch_txtbox.TabIndex = 0;
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.ForeColor = System.Drawing.Color.White;
            this.btn_Home.Location = new System.Drawing.Point(773, 47);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(75, 23);
            this.btn_Home.TabIndex = 3;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // lbl_MovieSiteName
            // 
            this.lbl_MovieSiteName.AutoSize = true;
            this.lbl_MovieSiteName.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_MovieSiteName.ForeColor = System.Drawing.Color.White;
            this.lbl_MovieSiteName.Location = new System.Drawing.Point(10, 42);
            this.lbl_MovieSiteName.Name = "lbl_MovieSiteName";
            this.lbl_MovieSiteName.Size = new System.Drawing.Size(214, 32);
            this.lbl_MovieSiteName.TabIndex = 4;
            this.lbl_MovieSiteName.Text = "CinemaHuseyn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 668);
            this.Controls.Add(this.flwLayPanel_Movies);
            this.Controls.Add(this.pnl_Header);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flwLayPanel_Movies;
        private Panel pnl_Header;
        private Button MovieSearch_btn;
        private TextBox MovieSearch_txtbox;
        private Label lbl_MovieSiteName;
        public Button btn_Home;
    }
}