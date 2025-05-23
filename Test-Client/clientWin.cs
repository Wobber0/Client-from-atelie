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
using MySql.Data.MySqlClient;

namespace Test_Client
{
    public partial class clientWin: Form
    {
        string connectionString = "Server=localhost;Port=3306;Database=atelie;Username=root;Password=root;";
        string sid;
        string price;
        public clientWin()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(clientWin_FormClosing);
            spravka.Hide();
            ShowInGrid($@"select
                                    s.name AS `Услуга`,
                                    o.comment as `Комментарий`,
                                    o.create_date as `Дата создания`,
                                    o.status as `Статус`, 
                                    o.cost as `Стоимость` 
                                from `order` o
                                inner join 
                                    `service` s ON o.service_id = s.id
                                where client_id = {usersID.Value}; ");
        }

        void ShowInGrid(string query)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            conn.Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создаем форму подтверждения
            confexitWin confirmForm = new confexitWin();
            DialogResult result = confirmForm.ShowDialog();

            if (result == DialogResult.Yes)
            {
                // Закрываем текущую форму и открываем авторизацию
                this.Hide();
                authorizationWin authForm = new authorizationWin();
                authForm.Show();
            }
            else
            {
                // Просто закрываем диалог, основная форма остается
                confirmForm.Close();
            }
        }

        private void clientWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spravka.Hide();
            if (dataGridView1.Width == 446)
            {
                dataGridView1.Width = 756;
            }
            ShowInGrid($@"select
                                    s.name AS `Услуга`,
                                    o.comment as `Комментарий`,
                                    o.create_date as `Дата создания`,
                                    o.status as `Статус`, 
                                    o.cost as `Стоимость` 
                                from `order` o
                                inner join 
                                    `service` s ON o.service_id = s.id
                                where client_id = {usersID.Value}; ");
        }

        private void отччетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spravka.Hide();
            if (dataGridView1.Width == 446)
            {
                dataGridView1.Width = 756;
            }
            ShowInGrid($@"select
	                                p.date as `Дата создания`,
	                                p.amount as `Стоимость`,
	                                s.name as `Тип заказа`,
	                                p.status as `Статус`
                                from `payment` p
                                inner join
                                    `service` s ON p.order_service_id = s.id
                                where order_client_id = {usersID.Value}; ");
        }

        private void нашиУслугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spravka.Hide();
            if ( dataGridView1.Width == 446)
            {
                dataGridView1.Width = 756;
            }
            ShowInGrid(@"select
	                                id as 'Номер',
	                                name as 'Название',
	                                base_price as 'Базовая цена',
	                                due_time as 'Время выполнения(дни)'
                                from service;");
        }

        private void платежиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spravka.Show();
            if (dataGridView1.Width == 756)
            {
                dataGridView1.Width = 446;
            }
            ShowInGrid(@"select
	                                id as 'Номер',
	                                name as 'Название',
	                                base_price as 'Базовая цена',
	                                due_time as 'Время выполнения(дни)'
                                from service;");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string value = cell.Value?.ToString() ?? "Пусто";
                sidBox.Text = $"{value}";
                var cell1 = dataGridView1.Rows[e.RowIndex].Cells[0];
                sid = cell1.Value?.ToString() ?? "Пусто";
                var cell2 = dataGridView1.Rows[e.RowIndex].Cells[2];
                price = cell2.Value?.ToString() ?? "Пусто";
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            //int sid = 4;
            DateTime date = DateTime.Now;
            try
            {
                // создаём объект для подключения к БД
                MySqlConnection conn = new MySqlConnection(connectionString);
                // устанавливаем соединение с БД
                conn.Open();
                //создаем запрос обновления параметра бана и аутентификации
                //проблемы с изменеием аутентификации
                string query = $"insert into `order` (service_id, comment, create_date, status, cost, client_id) value ({sid}, '{commBox.Text}', '{date.ToString("yyyy-MM-dd")}', 'Создано', {price}, {usersID.Value});;";
                MySqlCommand command = new MySqlCommand(query, conn);
                // выполняем запрос
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Новый заказ создан!", "Система ателье ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Не получилось добавить нового пользователя!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void моиМеркиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myInfo info = new myInfo();
            info.ShowDialog();
        }
    }
}
