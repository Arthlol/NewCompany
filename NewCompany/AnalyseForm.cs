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
    public partial class Оценка : Form
    {

        int SessionId = 0;
        public Оценка()
        {
            InitializeComponent();
        }
        Entities db = new Entities();
        private void Оценка_Load(object sender, EventArgs e)
        {
            UpdateCombobox();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(comboBox.SelectedValue.ToString(), out SessionId))
            {
                var AnswerList = db.Answer.Where(x => x.SessionId == SessionId).GroupBy(x => x.SituationId);
                AnswerLabel.Text = "";
                var Score = db.Session.Find(SessionId).Score.ToString();
                ScoreTextBox.Text = Score;
                foreach (var s in AnswerList)
                {
                    AnswerLabel.Text += "○ " + db.Situation.Find(s.FirstOrDefault().SituationId).Name;
                    AnswerLabel.Text += " - " + db.Situation.Find(s.FirstOrDefault().SituationId).Description;
                    AnswerLabel.Text += "\n";
                    foreach (var element in s)
                    {
                        AnswerLabel.Text += " • " + element.PeopleGroup + " - " + element.Action + "\r\n";
                    }
                    AnswerLabel.Text += "\n";
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ScoreTextBox.Text.Length == 0)
                e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
            else
            {
                e.Handled = !(e.KeyChar == (char)Keys.Back);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ScoreTextBox.Text.Length == 0)
                MessageBox.Show("Введите оценку", "Внимание");
            else
            {
                int Score = 0;
                int.TryParse(ScoreTextBox.Text, out Score);
                var item = db.Session.Find(SessionId);
                item.Score = Score;
                db.SaveChanges();
                comboBox.Text = comboBox.Text.Substring(3) + " " + Score.ToString();
                UpdateCombobox();
            }
        }

        public void UpdateCombobox()
        {
            int val = comboBox.SelectedIndex == -1 ? 1 : comboBox.SelectedIndex;
            var SituaionList = db.Session.ToList();
            comboBox.DataSource = db.Session.ToList();
            foreach (var element in SituaionList)
            {
                element.Surname = "";
                if (element.Score == null)
                    element.Surname += "!";
                element.Surname += element.Surname + " " + element.Name + ", " + element.Group;
                if (element.Score != null)
                    element.Surname += " " + element.Score.ToString();
            }
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Surname";
            comboBox.SelectedIndex = val;
        }
    }
}
