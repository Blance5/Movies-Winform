using System.Data.SQLite;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string greatestLeast = String.Empty;

        private void button1_Click(object sender, EventArgs e)
        {

            if (greatestRad.Checked)
            {
                greatestLeast = "DESC";
            }
            else
            {
                greatestLeast = "ASC";
            }

            output.Rows.Clear();
            output.Columns.Clear();

            output.ColumnHeadersVisible = true;
            output.Columns.Add("Column1", "Movies");
            output.Columns.Add("Column2", "Ratings");

            string connectionString = "Data Source=C:\\Users\\benjamin.lance\\Documents\\Visual Studio 2022\\MoviesWinforms\\movies.db;";

            string selectQuery = $"SELECT title, rating FROM movies, ratings WHERE movies.id = ratings.movie_id ORDER BY rating {greatestLeast}, title ASC LIMIT 750;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {

                                float rating = reader.GetFloat(1);
                                string title = reader.GetString(0);

                                DataGridViewRow row = new DataGridViewRow();
                                row.CreateCells(output, title, rating);

                                output.Rows.Add(row);

                            }
                        }
                    }
                }
                connection.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (greatestRad.Checked)
            {
                greatestLeast = "DESC";
            }
            else
            {
                greatestLeast = "ASC";
            }

            output.Rows.Clear();
            output.Columns.Clear();

            output.ColumnHeadersVisible = true;
            output.Columns.Add("Column1", "Movies");
            output.Columns.Add("Column2", "Number of Actors");

            string connectionString = "Data Source=C:\\Users\\benjamin.lance\\Documents\\Visual Studio 2022\\MoviesWinforms\\movies.db;";

            string selectQuery = $"SELECT COUNT(person_id), title FROM stars, movies WHERE movies.id = stars.movie_id GROUP BY movie_id ORDER BY COUNT(person_id) {greatestLeast}, title ASC LIMIT 750;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {

                                int actors = reader.GetInt32(0);
                                string title = reader.GetString(1);

                                DataGridViewRow row = new DataGridViewRow();
                                row.CreateCells(output, title, actors);

                                output.Rows.Add(row);

                            }
                        }
                    }
                }
                connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (greatestRad.Checked)
            {
                greatestLeast = "DESC";
            }
            else
            {
                greatestLeast = "ASC";
            }

            output.Rows.Clear();
            output.Columns.Clear();

            output.ColumnHeadersVisible = true;
            output.Columns.Add("Column1", "Movies");
            output.Columns.Add("Column2", "Votes");

            string connectionString = "Data Source=C:\\Users\\benjamin.lance\\Documents\\Visual Studio 2022\\MoviesWinforms\\movies.db;";

            string selectQuery = $"SELECT title, votes FROM movies, ratings WHERE movies.id = ratings.movie_id ORDER BY votes {greatestLeast}, title ASC LIMIT 750;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {

                                int votes = reader.GetInt32(1);
                                string title = reader.GetString(0);

                                DataGridViewRow row = new DataGridViewRow();
                                row.CreateCells(output, title, votes);

                                output.Rows.Add(row);

                            }
                        }
                    }
                }
                connection.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Gotfocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Enter start of a movie name...")
            {
                textBox.Text = string.Empty;
                textBox.ForeColor = Color.Black;
            }
        }
        private void textBox1_LostFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Enter start of a movie name...";
                textBox.ForeColor = Color.Gray;
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            /*
            string dashes = null;

            output.Text = $"List of movies that start with \"{startTB.Text}\"";

            for (int i = 0; i < output.Text.Length; i++)
            {
                dashes += "-";
            }

            output.Text = output.Text + "\n" + dashes + "\n";

            string input = startTB.Text + "%";

            string connectionString = "Data Source=C:\\Users\\benjamin.lance\\Documents\\Visual Studio 2022\\WinFormsApp1\\movies.db;";

            string selectQuery = $"SELECT title FROM movies WHERE title LIKE '{input}' LIMIT 10;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string title = reader.GetString(0);
                                output.Text = output.Text + title + "\n";
                            }
                        }
                    }
                }
                connection.Close();
            }
            */
            string left = null;
            string right = null;

            greatestLeast = String.Empty;
            if (leastRad.Checked)
            {
                greatestLeast = "DESC";
            }
            if (startRad.Checked)
            {
                right = "%";
                left = String.Empty;
            }
            else if (containRad.Checked)
            {
                left = "%";
                right = "%";
            }
            else if (endRad.Checked)
            {
                left = "%";
                right = String.Empty;
            }
            else
            {
                startRad.Checked = true;
                right = "%";
                left = String.Empty;
            }

            output.Rows.Clear();
            output.Columns.Clear();

            output.ColumnHeadersVisible = true;
            output.Columns.Add("Column1", $"Movies Starting With {startTB.Text}..");

            string input = startTB.Text;

            string connectionString = "Data Source=C:\\Users\\benjamin.lance\\Documents\\Visual Studio 2022\\MoviesWinforms\\movies.db;";

            string selectQuery = $"SELECT DISTINCT title FROM movies WHERE title LIKE '{left}{input}{right}' ORDER BY title {greatestLeast} LIMIT 750;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {

                                string data1 = reader.GetString(0);

                                DataGridViewRow row = new DataGridViewRow();
                                row.CreateCells(output, data1);

                                output.Rows.Add(row);

                            }
                        }
                    }
                }
                connection.Close();
            }
        }

        private void output_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void greatestRadClick(object sender, EventArgs e)
        {
            leastRad.Checked = false;
            greatestRad.Checked = true;
        }

        private void leastRadClick(object sender, EventArgs e)
        {
            greatestRad.Checked = false;
            leastRad.Checked = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void startRadClick(object sender, EventArgs e)
        {

        }

        private void containRadClick(object sender, EventArgs e)
        {

        }

        private void endRadClick(object sender, EventArgs e)
        {

        }

        private void greatestRad_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}