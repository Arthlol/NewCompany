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
        readonly Entities bd = new Entities();
        Entities db = new Entities();
        int SessionId = 0;
        private List<Session> SessionList = new List<Session>();
        public Оценка()
        {
            InitializeComponent();
        }
        
        private void Оценка_Load(object sender, EventArgs e)
        {
            SessionList = bd.Session.ToList();
            foreach (var element in SessionList)
            {
                element.Name = element.Surname + " " + element.Name;
            }
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
                int LastScore = item.Score ?? -1;
                item.Score = Score;
                db.SaveChanges();
                if (LastScore == -1)
                comboBox.Text = comboBox.Text.Substring(2);
                comboBox.Text += " → " + Score.ToString();
                UpdateCombobox();
            }
        }

        public void UpdateCombobox()
        {
            int val = comboBox.SelectedIndex == -1 ? 0 : comboBox.SelectedIndex;
            comboBox.DataSource = SessionList;
            foreach (var element in SessionList)
            {
                element.Surname = "";
                if (element.Score == null)
                    element.Surname = "! ";
                element.Surname += element.Name + ", " + element.Group;
                if (element.Score != null)
                    element.Surname += ": " + element.Score.ToString();
            }
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Surname";
            comboBox.SelectedIndex = val;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Owner.Visible = true;
            this.Close();
        }
    }
}
