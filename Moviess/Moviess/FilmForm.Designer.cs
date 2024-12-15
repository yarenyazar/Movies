namespace Moviess
{
    partial class FilmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmForm));
            this.btnAddFilm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.watchDateTextBox = new System.Windows.Forms.TextBox();
            this.filmNameTextBox = new System.Windows.Forms.TextBox();
            this.ratingNumericUpdwn = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ratingNumericUpdwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddFilm
            // 
            this.btnAddFilm.BackColor = System.Drawing.Color.Black;
            this.btnAddFilm.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFilm.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddFilm.Location = new System.Drawing.Point(632, 415);
            this.btnAddFilm.Name = "btnAddFilm";
            this.btnAddFilm.Size = new System.Drawing.Size(75, 32);
            this.btnAddFilm.TabIndex = 14;
            this.btnAddFilm.Text = "Add";
            this.btnAddFilm.UseVisualStyleBackColor = false;
            this.btnAddFilm.Click += new System.EventHandler(this.btnAddFilm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(409, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "Rating:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "Watch Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(341, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Movie Name:";
            // 
            // watchDateTextBox
            // 
            this.watchDateTextBox.BackColor = System.Drawing.Color.Black;
            this.watchDateTextBox.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchDateTextBox.ForeColor = System.Drawing.Color.White;
            this.watchDateTextBox.Location = new System.Drawing.Point(575, 280);
            this.watchDateTextBox.Name = "watchDateTextBox";
            this.watchDateTextBox.Size = new System.Drawing.Size(187, 29);
            this.watchDateTextBox.TabIndex = 10;
            // 
            // filmNameTextBox
            // 
            this.filmNameTextBox.BackColor = System.Drawing.Color.Black;
            this.filmNameTextBox.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmNameTextBox.ForeColor = System.Drawing.Color.White;
            this.filmNameTextBox.Location = new System.Drawing.Point(575, 222);
            this.filmNameTextBox.Name = "filmNameTextBox";
            this.filmNameTextBox.Size = new System.Drawing.Size(187, 29);
            this.filmNameTextBox.TabIndex = 9;
            // 
            // ratingNumericUpdwn
            // 
            this.ratingNumericUpdwn.BackColor = System.Drawing.Color.Black;
            this.ratingNumericUpdwn.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingNumericUpdwn.ForeColor = System.Drawing.Color.White;
            this.ratingNumericUpdwn.Location = new System.Drawing.Point(575, 341);
            this.ratingNumericUpdwn.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ratingNumericUpdwn.Name = "ratingNumericUpdwn";
            this.ratingNumericUpdwn.Size = new System.Drawing.Size(187, 29);
            this.ratingNumericUpdwn.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(471, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "ADD MOVIE";
            // 
            // FilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(826, 509);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddFilm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.watchDateTextBox);
            this.Controls.Add(this.filmNameTextBox);
            this.Controls.Add(this.ratingNumericUpdwn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FilmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilmForm";
            ((System.ComponentModel.ISupportInitialize)(this.ratingNumericUpdwn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddFilm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox watchDateTextBox;
        private System.Windows.Forms.TextBox filmNameTextBox;
        private System.Windows.Forms.NumericUpDown ratingNumericUpdwn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}