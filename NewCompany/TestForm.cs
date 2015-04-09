using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
        int curPos = 0;
        Entities db = new Entities();
        private int Sess = 0;
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
                    number = random.Next(1, 25);
                } while (questions.Contains(number));
                questions.Add(number);
            }
            NameLabel.Text = db.Situation.Find(questions[curPos]).Name;
            ContentLabel.Text = db.Situation.Find(questions[curPos]).Description;
            Sess = db.Session.OrderByDescending(x => x.Id).First().Id;
        }

        private void NextStepButton_Click(object sender, EventArgs e)
        {
            int changes = 0;
            DialogResult d = DialogResult.Abort;
            if (HasText(Group1.Text, Action1.Text))
            {
                changes++;
                var ans = new Answer();
                ans.Action = Action1.Text;
                ans.PeopleGroup = Group1.Text;
                ans.SessionId = Sess;
                ans.SituationId = questions[curPos];
                db.Answer.Add(ans);
            } if (HasText(Group2.Text, Action2.Text))
            {
                changes++;
                var ans = new Answer();
                ans.Action = Action2.Text;
                ans.PeopleGroup = Group2.Text;
                ans.SessionId = Sess;
                ans.SituationId = questions[curPos];
                db.Answer.Add(ans);
            }
            if (HasText(Group3.Text, Action3.Text))
            {
                changes++;
                var ans = new Answer();
                ans.Action = Action3.Text;
                ans.PeopleGroup = Group3.Text;
                ans.SessionId = Sess;
                ans.SituationId = questions[curPos];
                db.Answer.Add(ans);
            }
            if (HasText(Group4.Text, Action4.Text))
            {
                changes++;
                var ans = new Answer();
                ans.Action = Action4.Text;
                ans.PeopleGroup = Group4.Text;
                ans.SessionId = Sess;
                ans.SituationId = questions[curPos];
                db.Answer.Add(ans);
            }
            if (changes == 0)
            {
               d = MessageBox.Show("Введите хотя бы один вариант решения проблемы.", "Внимание", MessageBoxButtons.OKCancel);
            }
            db.SaveChanges();
            if (d != DialogResult.OK)
            {
                curPos++;
                Reload();
            }
        }

        private bool HasText(string GroupText, string ActionText)
        {
            return (!string.IsNullOrWhiteSpace(GroupText) && !string.IsNullOrWhiteSpace(ActionText));
        }

        private void Reload()
        {
            if (curPos > 4)
            {
                this.Visible = false;
                this.Owner.Visible = true;
                this.Close();

            }
            else if (curPos == 4)
            {
                NameLabel.Text = db.Situation.Find(questions[curPos]).Name;
                ContentLabel.Text = db.Situation.Find(questions[curPos]).Description;
                Group1.Text = "";
                Group2.Text = "";
                Group3.Text = "";
                Group4.Text = "";
                Action1.Text = "";
                Action2.Text = "";
                Action3.Text = "";
                Action4.Text = "";
                NextStepButton.Text = "Завершить тестирование";
            }
            else
            {

                NameLabel.Text = db.Situation.Find(questions[curPos]).Name;
                ContentLabel.Text = db.Situation.Find(questions[curPos]).Description;
                Group1.Text = "";
                Group2.Text = "";
                Group3.Text = "";
                Group4.Text = "";
                Action1.Text = "";
                Action2.Text = "";
                Action3.Text = "";
                Action4.Text = "";
            }
        }
    }
}



