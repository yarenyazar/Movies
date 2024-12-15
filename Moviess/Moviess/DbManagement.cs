using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moviess
{
    public class DbManagement
    {
        public static readonly string dbFileName = "filmUygulama.db";
        public static readonly string connectionString = $"Data source={dbFileName}";
        public static string AuthUserName = "";
        public static DataSet dataSet = new DataSet();

        public static void CreateDatabase()
        {
            if (!System.IO.File.Exists(dbFileName))
            {
                try
                {
                    // veritabanı dosyası oluşturma
                    SQLiteConnection.CreateFile(dbFileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public static void CreateTables()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string userTableQuery = @"CREATE TABLE IF NOT EXISTS Users (
                                                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                                 Username TEXT NOT NULL UNIQUE,
                                                 Password TEXT NOT NULL)";

                    string filmTableQuery = @"CREATE TABLE IF NOT EXISTS Films (
                                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                               Auth_Username TEXT NOT NULL,
                                               FilmName TEXT NOT NULL,
                                               WatchDate TEXT NOT NULL,
                                               Rating INTEGER NOT NULL,
                                               FOREIGN KEY(Auth_Username) REFERENCES Users(Username))";

                    // tablo sorguları
                    SQLiteCommand cmd = new SQLiteCommand(userTableQuery, conn);
                    cmd.CommandText = userTableQuery;
                    cmd.ExecuteNonQuery();
                    SQLiteCommand cmd2 = new SQLiteCommand(filmTableQuery, conn);
                    cmd2.CommandText = filmTableQuery;
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static bool login(string userName, string password)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Username FROM Users WHERE @username = Username AND @password = Password";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", userName);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    AuthUserName = reader["Username"].ToString();
                                    MessageBox.Show(AuthUserName);
                                }
                                return true;
                            }
                            else 
                                return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static void addUser(string userName,string password)
        {
            try
            {
                string query = @"INSERT INTO Users(Username,Password) Values (@username,@password)";
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using(SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", userName);
                        cmd.Parameters.AddWithValue ("@password", password);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("You have successfully registered!");
                    }
                }

            }
            catch (Exception ex)
            {           
                 MessageBox.Show(ex.Message);
            }

        }
        public static void addFilm(string movieName, string watchDate, int rating)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO Films(Auth_Username,FilmName,WatchDate,Rating) Values(@authUserName,@filmName,@watchDate,@rating)";

                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@authUserName", AuthUserName);
                    cmd.Parameters.AddWithValue("@filmName", movieName);
                    cmd.Parameters.AddWithValue("@watchDate", watchDate);
                    cmd.Parameters.AddWithValue("@rating", rating);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your movie has been added to your list!");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
        }
        public static void getFilms()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT FilmName, WatchDate, Rating FROM Films WHERE Auth_Username = @authUserName";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@authUserName", AuthUserName);

                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

                        // bir önceki kullanıcının dataSete kaydettiği bilgileri temizle
                        if (dataSet.Tables.Contains("Films"))
                        {
                            dataSet.Tables["Films"].Clear();
                        }

                        // filmleri dataSete kaydet
                        adapter.Fill(dataSet, "Films");
                    }

                    conn.Close();
                    MessageBox.Show("Movies uploaded successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
