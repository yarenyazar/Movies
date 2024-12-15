namespace Moviess
{
    partial class FilmListForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewFilms = new System.Windows.Forms.DataGridView();
            this.addMovie = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilms)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(99, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Movie List:";
            // 
            // dataGridViewFilms
            // 
            this.dataGridViewFilms.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilms.Location = new System.Drawing.Point(105, 90);
            this.dataGridViewFilms.Name = "dataGridViewFilms";
            this.dataGridViewFilms.RowHeadersWidth = 51;
            this.dataGridViewFilms.RowTemplate.Height = 24;
            this.dataGridViewFilms.Size = new System.Drawing.Size(1035, 654);
            this.dataGridViewFilms.TabIndex = 2;
            // 
            // addMovie
            // 
            this.addMovie.BackColor = System.Drawing.Color.Black;
            this.addMovie.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.addMovie.Location = new System.Drawing.Point(576, 33);
            this.addMovie.Name = "addMovie";
            this.addMovie.Size = new System.Drawing.Size(339, 34);
            this.addMovie.TabIndex = 10;
            this.addMovie.Text = "Add Movie";
            this.addMovie.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addMovie.UseVisualStyleBackColor = false;
            this.addMovie.Click += new System.EventHandler(this.addMovie_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Black;
            this.btnSignOut.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSignOut.Location = new System.Drawing.Point(1003, 33);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(137, 34);
            this.btnSignOut.TabIndex = 11;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // FilmListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1253, 777);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.addMovie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewFilms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FilmListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilmListForm";
            this.Load += new System.EventHandler(this.FilmListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewFilms;
        private System.Windows.Forms.Button addMovie;
        private System.Windows.Forms.Button btnSignOut;
    }
}