using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Test_Client
{
    public partial class registrWin: Form
    {
        string connStr = "server=localhost;user=root;database=atelie;password=root;";
        public registrWin()
        {
            InitializeComponent();
        }

        private void RegBut_Click(object sender, EventArgs e)
        {
            try {
                // создаём объект для подключения к БД
                MySqlConnection conn = new MySqlConnection(connStr);
                // устанавливаем соединение с БД
                conn.Open();
                //создаем запрос обновления параметра бана и аутентификации
                //проблемы с изменеием аутентификации
                string query = $"insert into atelie.client (name,phone,address,login,password,ban,auth) value ('{FIBox.Text}', '{numberBox.Text}', '{addressBox.Text}', '{loginBox.Text}', '{passwordBox.Text}', 3, 0);";
                MySqlCommand command = new MySqlCommand(query, conn);
                // выполняем запрос
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Учетная запись создана.", "База данных пользователей.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Yes; // Возвращаем результат
                this.Close();
            }
            catch {
                MessageBox.Show("Не получилось осздать учетную запись.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
