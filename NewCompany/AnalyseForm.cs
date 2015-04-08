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
            comboBox.ValueMember =  "Id";
            comboBox.DisplayMember = "Surname";
            foreach (var element in AnswerList)
            {
                AnswerTextBox.Text += "Кому: " + element.Action + " " + "Что: " + element.PeopleGroup +"\r\n";
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.Text = comboBox.SelectedValue.ToString();
#warning ошибка при конверте 
            /*
            var AnswerList = db.Answer.Where(x => x.SessionId == Convert.ToInt32(comboBox.SelectedValue)).ToList();
            foreach (var element in AnswerList)
            {
                AnswerTextBox.Text += "Кому: " + element.Action + " " + "Что: " + element.PeopleGroup + "\r\n";
            }*/
        }
    }
}
