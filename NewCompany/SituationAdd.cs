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
    public partial class SituationAdd : Form
    {
        public SituationAdd()
        {
            InitializeComponent();
        }

        Entities db = new Entities();
        private void SituationAdd_Load(object sender, EventArgs e)
        {
            
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {       
            //MessageBox вы уверены что хотите выйти?
            this.Visible = false;
            this.Owner.Visible = true;
            this.Close();
        }
    }
}
