namespace Test_Client
{
    partial class clientWin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.платежиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отччетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моиДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПарольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нашиУслугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sidBox = new System.Windows.Forms.TextBox();
            this.commBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SandyBrown;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.бДToolStripMenuItem,
            this.отччетToolStripMenuItem,
            this.статистикаToolStripMenuItem,
            this.нашиУслугиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.menuStrip1.Size = new System.Drawing.Size(800, 58);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.выходToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(85, 28);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // бДToolStripMenuItem
            // 
            this.бДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказыToolStripMenuItem,
            this.платежиToolStripMenuItem});
            this.бДToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.бДToolStripMenuItem.Name = "бДToolStripMenuItem";
            this.бДToolStripMenuItem.Size = new System.Drawing.Size(145, 28);
            this.бДToolStripMenuItem.Text = "Мои заказы";
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(235, 28);
            this.заказыToolStripMenuItem.Text = "Просмотреть";
            this.заказыToolStripMenuItem.Click += new System.EventHandler(this.заказыToolStripMenuItem_Click);
            // 
            // платежиToolStripMenuItem
            // 
            this.платежиToolStripMenuItem.Name = "платежиToolStripMenuItem";
            this.платежиToolStripMenuItem.Size = new System.Drawing.Size(235, 28);
            this.платежиToolStripMenuItem.Text = "Создать новый";
            this.платежиToolStripMenuItem.Click += new System.EventHandler(this.платежиToolStripMenuItem_Click);
            // 
            // отччетToolStripMenuItem
            // 
            this.отччетToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.отччетToolStripMenuItem.Name = "отччетToolStripMenuItem";
            this.отччетToolStripMenuItem.Size = new System.Drawing.Size(164, 28);
            this.отччетToolStripMenuItem.Text = "Мои платежи";
            this.отччетToolStripMenuItem.Click += new System.EventHandler(this.отччетToolStripMenuItem_Click);
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.статистикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.моиДанныеToolStripMenuItem,
            this.сменитьПарольToolStripMenuItem});
            this.статистикаToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(122, 28);
            this.статистикаToolStripMenuItem.Text = "Профиль";
            // 
            // моиДанныеToolStripMenuItem
            // 
            this.моиДанныеToolStripMenuItem.Name = "моиДанныеToolStripMenuItem";
            this.моиДанныеToolStripMenuItem.Size = new System.Drawing.Size(256, 28);
            this.моиДанныеToolStripMenuItem.Text = "Мои данные";
            // 
            // сменитьПарольToolStripMenuItem
            // 
            this.сменитьПарольToolStripMenuItem.Name = "сменитьПарольToolStripMenuItem";
            this.сменитьПарольToolStripMenuItem.Size = new System.Drawing.Size(256, 28);
            this.сменитьПарольToolStripMenuItem.Text = "Сменить пароль";
            // 
            // нашиУслугиToolStripMenuItem
            // 
            this.нашиУслугиToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.нашиУслугиToolStripMenuItem.Name = "нашиУслугиToolStripMenuItem";
            this.нашиУслугиToolStripMenuItem.Size = new System.Drawing.Size(158, 28);
            this.нашиУслугиToolStripMenuItem.Text = "Наши услуги";
            this.нашиУслугиToolStripMenuItem.Click += new System.EventHandler(this.нашиУслугиToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(756, 379);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // sidBox
            // 
            this.sidBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sidBox.Location = new System.Drawing.Point(25, 44);
            this.sidBox.Multiline = true;
            this.sidBox.Name = "sidBox";
            this.sidBox.Size = new System.Drawing.Size(255, 81);
            this.sidBox.TabIndex = 3;
            // 
            // commBox
            // 
            this.commBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commBox.Location = new System.Drawing.Point(25, 164);
            this.commBox.MaxLength = 200;
            this.commBox.Multiline = true;
            this.commBox.Name = "commBox";
            this.commBox.Size = new System.Drawing.Size(255, 117);
            this.commBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Тип заказа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Комментарий к заказу:";
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.SandyBrown;
            this.create.FlatAppearance.BorderSize = 0;
            this.create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create.Location = new System.Drawing.Point(69, 299);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(161, 59);
            this.create.TabIndex = 7;
            this.create.Text = "Создать";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.sidBox);
            this.panel1.Controls.Add(this.create);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.commBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(489, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 379);
            this.panel1.TabIndex = 8;
            // 
            // clientWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "clientWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "clientWin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.clientWin_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem платежиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отччетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem моиДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПарольToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нашиУслугиToolStripMenuItem;
        private System.Windows.Forms.TextBox sidBox;
        private System.Windows.Forms.TextBox commBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Panel panel1;
    }
}