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
    public partial class TestForm : Form
    {

        List<int> questions = new List<int>();
        int curPos = 1;
        Entities db = new Entities();
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int number;
                do
                {
                    number = random.Next(1, 6);
                } while (questions.Contains(number));
                questions.Add(number);
            }
            NameLabel.Text = db.Situation.Find(questions[curPos]).Name;
            ContentLabel.Text = db.Situation.Find(questions[curPos]).Description;
        }

        private void NextStepButton_Click(object sender, EventArgs e)
        {
            curPos++;
            this.Refresh();
        }
    }
}
