namespace Test
{
    partial class authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(authorization));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.autorizating = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.shovpbtn = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox1.Controls.Add(this.shovpbtn);
            this.groupBox1.Controls.Add(this.autorizating);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.passwordBox);
            this.groupBox1.Controls.Add(this.loginBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(101, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Войдите в аккаунт:";
            // 
            // autorizating
            // 
            this.autorizating.BackColor = System.Drawing.Color.Bisque;
            this.autorizating.FlatAppearance.BorderSize = 0;
            this.autorizating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autorizating.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autorizating.Location = new System.Drawing.Point(107, 313);
            this.autorizating.Name = "autorizating";
            this.autorizating.Size = new System.Drawing.Size(161, 59);
            this.autorizating.TabIndex = 3;
            this.autorizating.Text = "Войти";
            this.autorizating.UseVisualStyleBackColor = false;
            this.autorizating.Click += new System.EventHandler(this.autorizating_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(82, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(82, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин*";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(86, 221);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(212, 33);
            this.passwordBox.TabIndex = 2;
            this.passwordBox.UseSystemPasswordChar = true;
            this.passwordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordBox_KeyDown);
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(86, 114);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(212, 33);
            this.loginBox.TabIndex = 1;
            this.loginBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginBox_KeyDown);
            // 
            // shovpbtn
            // 
            this.shovpbtn.AutoSize = true;
            this.shovpbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shovpbtn.Location = new System.Drawing.Point(86, 261);
            this.shovpbtn.Name = "shovpbtn";
            this.shovpbtn.Size = new System.Drawing.Size(164, 25);
            this.shovpbtn.TabIndex = 4;
            this.shovpbtn.Text = "Показать пароль";
            this.shovpbtn.UseVisualStyleBackColor = true;
            this.shovpbtn.CheckedChanged += new System.EventHandler(this.shovpbtn_CheckedChanged);
            // 
            // authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 533);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutorWin_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox shovpbtn;
        private System.Windows.Forms.Button autorizating;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox loginBox;
    }
}

