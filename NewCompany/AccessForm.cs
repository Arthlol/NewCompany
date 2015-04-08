using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCompany
{
    public partial class AccessForm : Form
    {
        public AccessForm()
        {
            InitializeComponent();
        }

        private string login = "admin";
        private string password = "123";
        private void AccessForm_Load(object sender, EventArgs e)
        {
        }

        private void AccessButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == password && LoginTextBox.Text == login)
            {
                this.Owner.Visible = false;
                this.Visible = false;
                var analyseForm = new Оценка();
                analyseForm.Show(this.Owner);
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверная учетная запись");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Owner.Visible = true;
            this.Close();
        }


    }
}
