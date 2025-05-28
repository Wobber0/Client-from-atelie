using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test;

namespace Test_Client
{
    public partial class myInfo: Form
    {
        bool first_try = false;
        string connStr = "server=localhost;user=root;database=atelie;password=root;";
        public myInfo()
        {
            InitializeComponent();
            try
            {
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            string query = $"SELECT * FROM measurements WHERE id_client = {usersID.Value};";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            //добавление вариантов для бокса с логинами
            while (reader.Read())
            {
                ChestBox.Text = reader["chest"].ToString();
                waistBox.Text = reader["waist"].ToString();
                hipBox.Text = reader["hip"].ToString();
                heightBox.Text = reader["height"].ToString();
                armBox.Text = reader["arm_length"].ToString();
            }
            connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if ((ChestBox.Text == "") && (waistBox.Text == "") && (hipBox.Text == "") && (heightBox.Text == "") && (armBox.Text == ""))
            {
                first_try = true;
            }
            try
            {
                MySqlConnection connection = new MySqlConnection(connStr);
                connection.Open();
                string query = $"SELECT * FROM client WHERE id = {usersID.Value};";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                //добавление вариантов для бокса с логинами
                while (reader.Read())
                {
                    FIBox.Text = reader["name"].ToString();
                    numberBox.Text = reader["phone"].ToString();
                    addressBox.Text = reader["address"].ToString();
                    loginBox.Text = reader["login"].ToString();
                    passwordBox.Text = reader["password"].ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!first_try)
                {
                // создаём объект для подключения к БД
                MySqlConnection conn = new MySqlConnection(connStr);
                // устанавливаем соединение с БД
                conn.Open();
                //создаем запрос обновления параметра бана и аутентификации
                string query = $"UPDATE measurements SET chest = '{ChestBox.Text}', waist = '{waistBox.Text}', hip = '{hipBox.Text}', height = '{heightBox.Text}', arm_length = '{armBox.Text}' WHERE (id_client = '{usersID.Value}');";
                MySqlCommand command = new MySqlCommand(query, conn);
                // выполняем запрос
                command.ExecuteNonQuery();
                conn.Close();
                    MessageBox.Show("Данные сохранены.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // создаём объект для подключения к БД
                    MySqlConnection conn = new MySqlConnection(connStr);
                    // устанавливаем соединение с БД
                    conn.Open();
                    //создаем запрос обновления параметра бана и аутентификации
                    string query = $"INSERT INTO measurements (id_client, chest, waist, hip, height, arm_length, other) VALUES ('{usersID.Value}', '{ChestBox.Text}', '{waistBox.Text}', '{hipBox.Text}', '{heightBox.Text}', '{armBox.Text}', NULL);";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    // выполняем запрос
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Данные сохранены.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveD_Click(object sender, EventArgs e)
        {
            try
            {
                // создаём объект для подключения к БД
                MySqlConnection conn = new MySqlConnection(connStr);
                // устанавливаем соединение с БД
                conn.Open();
                //создаем запрос обновления параметра бана и аутентификации
                string query = $"UPDATE client SET name = '{FIBox.Text}', phone = '{numberBox.Text}', address = '{addressBox.Text}', login = '{loginBox.Text}', password = '{passwordBox.Text}' WHERE (id_client = '{usersID.Value}');";
                MySqlCommand command = new MySqlCommand(query, conn);
                // выполняем запрос
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Данные сохранены.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
