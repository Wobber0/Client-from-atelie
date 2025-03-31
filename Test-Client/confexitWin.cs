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
    public partial class confexitWin: Form
    {
        public confexitWin()
        {
            InitializeComponent();
        }

        private void No_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No; // Возвращаем результат
            this.Close();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes; // Возвращаем результат
            this.Close();
        }
    }
}
