namespace Movie_App.MyControls
{
    partial class MovieControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_MovieGenre = new System.Windows.Forms.Label();
            this.lbl_MovieLang = new System.Windows.Forms.Label();
            this.lbl_MovieName = new System.Windows.Forms.Label();
            this.pctBox_Movie = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_Movie)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_MovieGenre
            // 
            this.lbl_MovieGenre.AutoSize = true;
            this.lbl_MovieGenre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_MovieGenre.Location = new System.Drawing.Point(5, 319);
            this.lbl_MovieGenre.Name = "lbl_MovieGenre";
            this.lbl_MovieGenre.Size = new System.Drawing.Size(84, 17);
            this.lbl_MovieGenre.TabIndex = 8;
            this.lbl_MovieGenre.Text = "Movie_Genre";
            // 
            // lbl_MovieLang
            // 
            this.lbl_MovieLang.AutoSize = true;
            this.lbl_MovieLang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_MovieLang.Location = new System.Drawing.Point(2, 348);
            this.lbl_MovieLang.Name = "lbl_MovieLang";
            this.lbl_MovieLang.Size = new System.Drawing.Size(106, 17);
            this.lbl_MovieLang.TabIndex = 7;
            this.lbl_MovieLang.Text = "Movie_Language";
            // 
            // lbl_MovieName
            // 
            this.lbl_MovieName.AutoSize = true;
            this.lbl_MovieName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_MovieName.Location = new System.Drawing.Point(52, 275);
            this.lbl_MovieName.Name = "lbl_MovieName";
            this.lbl_MovieName.Size = new System.Drawing.Size(99, 20);
            this.lbl_MovieName.TabIndex = 6;
            this.lbl_MovieName.Text = "Movie_Name";
            this.lbl_MovieName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pctBox_Movie
            // 
            this.pctBox_Movie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctBox_Movie.Location = new System.Drawing.Point(3, 3);
            this.pctBox_Movie.Name = "pctBox_Movie";
            this.pctBox_Movie.Size = new System.Drawing.Size(214, 245);
            this.pctBox_Movie.TabIndex = 5;
            this.pctBox_Movie.TabStop = false;
            // 
            // MovieControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_MovieGenre);
            this.Controls.Add(this.lbl_MovieLang);
            this.Controls.Add(this.lbl_MovieName);
            this.Controls.Add(this.pctBox_Movie);
            this.Name = "MovieControl";
            this.Size = new System.Drawing.Size(217, 373);
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_Movie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_MovieGenre;
        private Label lbl_MovieLang;
        public Label lbl_MovieName;
        public PictureBox pctBox_Movie;
    }
}
