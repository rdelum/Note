using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectSQL_Button_Click(object sender, EventArgs e)
        {
            ConfigureDataBase configureDataBase = new ConfigureDataBase();
            configureDataBase.Show();
        }

        private static void ReadSingleRow(IDataRecord record)
        {
            Note note = new Note();
            note.Title = (record[0]).ToString();
            note.TextBox = (record[1]).ToString();

            Console.WriteLine(String.Format("{0}, {1}", record[0], record[1]));
        }

        private void Button_AddNote_Click(object sender, EventArgs e)
        {
            var connectionString = getConnection();

            var queryString = $"INSERT INTO notes ( Title, TextBox) VALUES({textBox_Title.Text}, {textBox_NoteContent.Text}) ";

            using (SqlConnection connection = new SqlConnection(
                connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"INSERT INTO NOTES(Title, Textbox) 
                            VALUES(@param1,@param2)";

                    cmd.Parameters.AddWithValue("@param1", textBox_Title.Text);
                    cmd.Parameters.AddWithValue("@param2", textBox_NoteContent.Text);

                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(($"Dodano tytuł {textBox_Title.Text} \noraz wiadomość {textBox_NoteContent.Text}"));
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error Message");
                    }

                }

            }
        }

        private string getConnection()
        {
            return Properties.Settings.Default.CheckNT
               ? $"Data Source={Properties.Settings.Default.SerwerName};Initial Catalog={Properties.Settings.Default.DatabaseName};Integrated Security=SSPI"
               : $"Data Source={Properties.Settings.Default.SerwerName};Initial Catalog={Properties.Settings.Default.DatabaseName};User ID={Properties.Settings.Default.Login};Password={Properties.Settings.Default.Password}";
        }

        private void button_EditNote_Click(object sender, EventArgs e)
        {
            var connectionString = getConnection();

            var queryString = $"update notes set TextBox = {textBox_TitleEdit.Text} where ID = {textBoxEditID.Text} VALUES({textBox_Title.Text}, {textBox_NoteContent.Text}) ";

            using (SqlConnection connection = new SqlConnection(
                connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"update notes set TextBox = {textBox_TitleEdit.Text} where ID = {textBoxEditID.Text} VALUES(@param1,@param2)";

                    cmd.Parameters.AddWithValue("@param1", textBox_Title.Text);
                    cmd.Parameters.AddWithValue("@param2", textBox_NoteContent.Text);
                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(($"Zaktualizowano {textBox_Title.Text} \noraz wiadomość {textBox_NoteContent.Text}"));
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error Message");
                    }

                }
            }
        }
    }
}
