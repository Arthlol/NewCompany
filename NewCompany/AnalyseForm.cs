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
        public Оценка()
        {
            InitializeComponent();
        }
        Entities db = new Entities();
        private void Оценка_Load(object sender, EventArgs e)
        {
            var AnswerList = db.Answer.ToList();
            var SessionList = db.Session.ToList();
            var SituaionList = db.Session.ToList();
            comboBox.DataSource = db.Session.ToList();
            foreach (var element in SituaionList )
            {
                element.Surname = element.Surname + " " + element.Name + ", " + element.Group;
            }
            comboBox.ValueMember =  "Id";
            comboBox.DisplayMember = "Surname";
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = comboBox.SelectedValue.ToString();
            int SessionId = 0;
            if (int.TryParse(comboBox.SelectedValue.ToString(), out SessionId))
            {
                var AnswerList = db.Answer.Where(x => x.SessionId == SessionId).GroupBy(x => x.SituationId);

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
    }
}
